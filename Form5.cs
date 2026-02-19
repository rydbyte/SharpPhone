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
    public partial class Hide : Form
    {
        public Hide()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ShowInTaskbar = false;
            Start start = new Start();
            start.Show();
        }

        private void Hide_Load(object sender, EventArgs e)
        {
            this.Size = new Size(0, 0);
        }
    }
}
