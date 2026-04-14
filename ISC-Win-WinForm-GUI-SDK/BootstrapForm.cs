using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace ISC_Win_WinForm_GUI
{
    public partial class BootstrapForm : Form
    {
        private readonly string[] _args;
        private readonly CancellationTokenSource _cts = new CancellationTokenSource();

        private Label _lblStatus;
        private System.Windows.Forms.ProgressBar _progress;

        public BootstrapForm(string[] args)
        {
            InitializeComponent(); // importante porque existe Designer.cs
            //MessageBox.Show("BOOTSTRAP A CORRER", "Debug");
            _args = args ?? Array.Empty<string>();
            BuildUi();
        }

        private void BuildUi()
        {
            Text = "Starting...";
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Width = 520;
            Height = 160;

            _lblStatus = new Label
            {
                AutoSize = false,
                Text = "Starting API...",
                Left = 20,
                Top = 20,
                Width = 460,
                Height = 30
            };

            _progress = new ProgressBar
            {
                Left = 20,
                Top = 60,
                Width = 460,
                Height = 20,
                Style = ProgressBarStyle.Marquee
            };

            Controls.Add(_lblStatus);
            Controls.Add(_progress);
        }

        protected override async void OnShown(EventArgs e)
        {
            base.OnShown(e);
            //MessageBox.Show(AppDomain.CurrentDomain.BaseDirectory, "BaseDirectory");

            bool ok;
            try
            {
                ok = await ApiBootstrap.EnsureApiReadyAsync(SetStatus, _cts.Token);
            }
            catch (Exception ex)
            {
                SetStatus("Error on starting API.");
                MessageBox.Show(this, ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ok = false;
            }

            if (!ok)
            {
                var logPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "api_startup.log");

                MessageBox.Show(this,
                    "It wasn't possible to start API.\n\nLog:\n" + logPath,
                    "API unavailable",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                Application.Exit();
                return;
            }

            // Exibir o LoginForm (o mesmo fluxo que tinhas)
            var loginForm = new LoginForm();
            if (loginForm.ShowDialog() != DialogResult.OK)
            {
                Application.Exit();
                return;
            }

            // Se login OK, abre MainWindow
            var main = new MainWindow(_args, TokenManager.JwtToken, loginForm.Username);
            main.FormClosed += (_, __) => Application.Exit();

            Hide();
            main.Show();
        }

        private void SetStatus(string text)
        {
            if (InvokeRequired) BeginInvoke(new Action(() => _lblStatus.Text = text));
            else _lblStatus.Text = text;
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            _cts.Cancel();
            base.OnFormClosed(e);
        }
    }
}
