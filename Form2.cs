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
    public partial class AddPhonePage : Form
    {
        public AddPhonePage()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                string brand = txtbrand.Text;
                string model = txtModel.Text;
                int size = int.Parse(txtSize.Text);
                double price = double.Parse(txtPrice.Text); 
                int stock = int.Parse(txtStock.Text);
                SmartPhone newPhone = new SmartPhone(Brand: brand, Model: model, Size: size, Price: price, Stock: stock, Save: true);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid values for Size, Price and Stock.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
