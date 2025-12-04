using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Windows.Forms;
using System;

namespace ISC_Win_WinForm_GUI
{
    internal partial class LoginForm : Form
    {
        //public string JwtToken { get; private set; }
        
        public string Username { get; private set; }

        public LoginForm()
        {
            InitializeComponent();

            this.KeyPreview = true;
            this.KeyDown += LoginForm_KeyDown;

            btnCancel.Click += (_, __) => { DialogResult = DialogResult.Cancel; };
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string user = textBox_User.Text.Trim();
            string pass = textBox_Pass.Text;

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Fill the username and password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var creds = new { username = user, password = pass };
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(creds);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var client = ApiClientHolder.Client; // ApiClientHolder.Client já está definido com a base URL
                var resp = await client.PostAsync("api/token/", content);
                //MessageBox.Show($"Login response: {resp}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (!resp.IsSuccessStatusCode)
                {
                    MessageBox.Show($"Login failed: {resp.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var body = await resp.Content.ReadAsStringAsync();
                var j = JObject.Parse(body);
                var JwtToken = j.Value<string>("access");

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", JwtToken);

                TokenManager.JwtToken = JwtToken;
                this.Username = user;

                // after you set ApiClientHolder.Client.DefaultRequestHeaders…
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Login Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // mesma lógica que tinhas no lambda do constructor:
            this.DialogResult = DialogResult.Cancel;
        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                if (textBox_User.Focused)
                {
                    if (!string.IsNullOrWhiteSpace(textBox_User.Text))
                        textBox_Pass.Focus();
                    else
                        MessageBox.Show("Please insert the username first.", "Warning");

                    return;
                }

                if (textBox_Pass.Focused)
                {
                    if (string.IsNullOrWhiteSpace(textBox_User.Text))
                    {
                        MessageBox.Show("Username is missing.", "Warning");
                        textBox_User.Focus();
                        return;
                    }

                    if (string.IsNullOrWhiteSpace(textBox_Pass.Text))
                    {
                        MessageBox.Show("Password is missing.", "Warning");
                        return;
                    }

                    btnLogin.PerformClick();
                }
            }
        }


    }
    public static class TokenManager
    {
        public static string JwtToken { get; set; }
    }
}
