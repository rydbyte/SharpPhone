using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharpPhone
{
    public partial class Start : Form
    {
        private int wrongs = 0;
        public Start()
        {
            InitializeComponent();
            JsonStore.Load();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var username = txtUser.Text ?? string.Empty;
            var password = txtPass.Text ?? string.Empty;

            var user = SharpPhoneDataBase.userAccounts.FirstOrDefault(u => u.username.Equals(username, StringComparison.OrdinalIgnoreCase));

            if (user == null)
            {  
                MessageBox.Show("No user", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (user.locked)
            {
                MessageBox.Show("This account is locked due to too many failed login attempts.", "Account Locked", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (user.password == password)
            {
                user.failedAttempts = 0;
                JsonStore.Save();

                MainPage mainPage = new MainPage();
                mainPage.Show();
                Close();
                return;
            }

            user.failedAttempts++;
            if (user.failedAttempts >= 3)
            {
                user.locked = true;
            }
            JsonStore.Save();

            MessageBox.Show("Wrong Username or Password", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
 
            if (user.failedAttempts >= 3) System.Windows.Forms.Application.Exit();
        }
    }
}
