using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Threading;

namespace ISC_Win_WinForm_GUI
{
    internal static class ApiBootstrap
    {
        private static Process _apiProcess;
        private static bool _startedByUs;

        private static string BaseUrl => ConfigurationManager.AppSettings["ApiBaseUrl"] ?? "http://127.0.0.1:8000/";
        private static string HealthPath => ConfigurationManager.AppSettings["ApiHealthPath"] ?? "/";
        private static string PythonExe => ConfigurationManager.AppSettings["ApiPythonExe"];
        private static string WorkingDir => ConfigurationManager.AppSettings["ApiWorkingDir"];
        private static string RunArgs => ConfigurationManager.AppSettings["ApiRunArgs"] ?? "manage.py runserver 127.0.0.1:8000 --noreload";

        private static int StartupTimeoutSeconds =>
            int.TryParse(ConfigurationManager.AppSettings["ApiStartupTimeoutSeconds"], out var s) ? s : 45;

        private static bool StopOnExit =>
            bool.TryParse(ConfigurationManager.AppSettings["StopApiOnExit"], out var b) && b;

        public static async Task<bool> EnsureApiReadyAsync(Action<string> status, CancellationToken ct)
        {
            //Log($"Bootstrap start | BaseDir={AppDomain.CurrentDomain.BaseDirectory}");
            Log($"EnsureApiReadyAsync | BaseUrl={BaseUrl} | HealthPath={HealthPath} | BaseDir={AppDomain.CurrentDomain.BaseDirectory}");
            status?.Invoke("Checking API...");

            if (await IsApiUpAsync(ct).ConfigureAwait(true))
            {
                status?.Invoke("API available.");
                return true;
            }

            status?.Invoke("Initializing API...");
            StartApiProcess(status);

            status?.Invoke("Waiting on API to get ready...");
            var ok = await WaitForApiAsync(TimeSpan.FromSeconds(StartupTimeoutSeconds), ct).ConfigureAwait(true);

            status?.Invoke(ok ? "API ready." : "Failed to start API.");
            return ok;
        }

        private static void StartApiProcess(Action<string> status)
        {
            Log($"StartApiProcess | PythonExe={PythonExe} | WorkingDir={WorkingDir} | Args={RunArgs}");
            if (_apiProcess != null && !_apiProcess.HasExited)
            {
                status?.Invoke("API was already initialized by this proccess.");
                return;
            }

            if (string.IsNullOrWhiteSpace(PythonExe) || string.IsNullOrWhiteSpace(WorkingDir))
                throw new InvalidOperationException("Faltam ApiPythonExe/ApiWorkingDir no App.config.");

            if (!File.Exists(PythonExe))
                throw new FileNotFoundException("Python do venv não encontrado (ApiPythonExe).", PythonExe);

            if (!Directory.Exists(WorkingDir))
                throw new DirectoryNotFoundException("ApiWorkingDir não existe: " + WorkingDir);

            // Validar que manage.py existe
            var managePath = Path.Combine(WorkingDir, "manage.py");
            if (!File.Exists(managePath))
                throw new FileNotFoundException("Não encontrei manage.py em ApiWorkingDir.", managePath);

            var psi = new ProcessStartInfo
            {
                FileName = PythonExe,
                Arguments = RunArgs,
                WorkingDirectory = WorkingDir,
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                CreateNoWindow = true
            };

            _apiProcess = new Process { StartInfo = psi, EnableRaisingEvents = true };

            _apiProcess.OutputDataReceived += (_, e) => { if (!string.IsNullOrWhiteSpace(e.Data)) Log("[OUT] " + e.Data); };
            _apiProcess.ErrorDataReceived += (_, e) => { if (!string.IsNullOrWhiteSpace(e.Data)) Log("[ERR] " + e.Data); };
            _apiProcess.Exited += (_, __) => Log($"[EXIT] API exited with code {_apiProcess.ExitCode}");

            _apiProcess.Start();
            //// DEBUG: se fechar logo, apanha o motivo
            //_apiProcess.WaitForExit(1500);
            //if (_apiProcess.HasExited)
            //{
            //    var err = _apiProcess.StandardError.ReadToEnd();
            //    var outp = _apiProcess.StandardOutput.ReadToEnd();
            //    Log("API exited immediately!");
            //    Log("STDOUT: " + outp);
            //    Log("STDERR: " + err);

            //    throw new Exception("A API fechou imediatamente ao arrancar.\n\nSTDERR:\n" + err);
            //}
            _apiProcess.BeginOutputReadLine();
            _apiProcess.BeginErrorReadLine();

            _startedByUs = true;
        }

        // Considera "UP" se houver QUALQUER resposta HTTP (200, 404, 302, etc.)
        private static async Task<bool> IsApiUpAsync(CancellationToken ct)
        {
            try
            {
                using (var http = new HttpClient { Timeout = TimeSpan.FromSeconds(2) })
                {
                    var url = new Uri(new Uri(BaseUrl), HealthPath);
                    using (var resp = await http.GetAsync(url, ct).ConfigureAwait(false))
                        return true;
                }
            }
            catch
            {
                return false;
            }
        }

        private static async Task<bool> WaitForApiAsync(TimeSpan timeout, CancellationToken ct)
        {
            var sw = Stopwatch.StartNew();

            while (sw.Elapsed < timeout)
            {
                ct.ThrowIfCancellationRequested();

                if (_apiProcess != null && _apiProcess.HasExited)
                    return false;

                if (await IsApiUpAsync(ct).ConfigureAwait(false))
                    return true;

                await Task.Delay(500, ct).ConfigureAwait(false);
            }

            return false;
        }

        public static void StopApiIfStartedByUs()
        {
            if (!StopOnExit) return;
            if (!_startedByUs) return;
            if (_apiProcess == null) return;

            try
            {
                if (!_apiProcess.HasExited)
                    _apiProcess.Kill();
            }
            catch { /* ignore */ }
        }

        private static void Log(string line)
        {
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "api_startup.log");
            File.AppendAllText(path, $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} {line}{Environment.NewLine}");
        }
    }
}