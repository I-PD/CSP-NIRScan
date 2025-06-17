using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Globalization;

namespace ISC_Win_WinForm_GUI
{
    /*
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        static String[] DeprecatedProductName = { "DLP-NIR-Win-SDK", "ISC-NIRScan", "ISC-WinForm-SDK", "ISC-WinForm-GUI" };
        static String TiEvmProductName = "NirscanNanoGUI";
        [STAThread]
        static void Main(string[] args)
        {
            Process currentProc = Process.GetCurrentProcess();
            String currentProcName = currentProc.ProcessName;
            String currentProdName = Application.ProductName;

            if (System.Diagnostics.Process.GetProcessesByName(TiEvmProductName).Length > 0)
            {
                DialogResult ret = Message.ShowQuestion("Existing TI EVM GUI detected!\n\nClose all the existig TI EVM GUI?");

                if (ret == DialogResult.Yes)
                {
                    Process[] p = Process.GetProcessesByName(TiEvmProductName).ToArray();
                    foreach (Process thisProc in p)
                       thisProc.Kill();
                }
                else
                {
                    Message.ShowError("GUI launch stopped!\n\nPlease close the existig TI EVM GUI before start the program.");
                    return;
                }
            }

            for (int i = 0; i < DeprecatedProductName.Length; i++)
            {
                String pattern = @DeprecatedProductName[i];
                foreach (Process p in Process.GetProcesses("."))
                {
                    MatchCollection matches = Regex.Matches(p.ProcessName, pattern);
                    if (matches.Count > 0)
                    {
                        DialogResult ret = DialogResult.Cancel;
                        if (p.MainModule.FileVersionInfo.ProductName == currentProdName && p.Id == currentProc.Id)
                            continue;

                        if (p.ProcessName.Contains("Qt"))
                            ret = Message.ShowQuestion("Existing ISC Factory GUI detected!\n\nClose the existig ISC Factory GUI?");

                        if (ret == DialogResult.Yes)
                            p.Kill();
                        else if (ret == DialogResult.No)
                        {
                            Message.ShowError("GUI launch stopped!\n\nPlease close other related GUI's before start the program.");
                            return;
                        }
                    }
                }
            }

            if (System.Diagnostics.Process.GetProcessesByName(currentProcName).Length > 1)
            {
                Process[] p = Process.GetProcessesByName(currentProcName).ToArray();
                foreach (Process thisProc in p)
                {
                    if (thisProc.Id != currentProc.Id)
                        thisProc.Kill();
                }
            }*/

    static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            // força ponto decimal por defeito
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.InvariantCulture;
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            /* 1) Show login
            using (var loginForm = new LoginForm())
            {
                if (loginForm.ShowDialog() != DialogResult.OK)
                    return;     // user cancelled

                // 2) On success, grab token/username and pass both plus args into MainWindow
                Application.Run(new MainWindow(
                    args,
                    loginForm.JwtToken,
                    loginForm.Username
                ));
            }*/

            // Exibir o LoginForm
            var loginForm = new LoginForm();
            if (loginForm.ShowDialog() != DialogResult.OK)
                return;  // Sai se cancelar

            //Se login OK, passa o token para a MainWindow
            Application.Run(new MainWindow(args, TokenManager.JwtToken,loginForm.Username));
        }

        
    }

        //Application.EnableVisualStyles();
        //Application.SetCompatibleTextRenderingDefault(false);
        //Application.Run(new MainWindow(args));
        //}
    //}
}
