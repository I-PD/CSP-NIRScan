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

            // Exibir o LoginForm
            var loginForm = new LoginForm();
            if (loginForm.ShowDialog() != DialogResult.OK)
                return;  // Sai se cancelar

            //Se login OK, passa o token para a MainWindow
            Application.Run(new MainWindow(args, TokenManager.JwtToken,loginForm.Username));
        }
    }   
}
