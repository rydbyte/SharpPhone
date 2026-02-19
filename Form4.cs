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
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "E" && txtPass.Text == "E" && wrongs != 3)
            {
                MainPage mainPage = new MainPage();
                mainPage.Show();
                Close();

            }
            else if (wrongs < 3)
            {
                MessageBox.Show("Wrong Password or User", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                wrongs++;
            }
            else 
            {
                System.Windows.Forms.Application.Exit();
            }
        }
    }
}
