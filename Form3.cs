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
    public partial class ModifyPhonePage : Form
    {
        int iindex;
        public ModifyPhonePage(int index, string brand, string model, int size, double price, int stock)
        {
            InitializeComponent();
            iindex = index;
            this.txtbrand.Text = brand;
            this.txtModel.Text = model;
            this.txtSize.Text = size.ToString();
            this.txtPrice.Text = price.ToString();
            this.txtStock.Text = stock.ToString();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                SmartPhone.PhoneList[iindex].brand = txtbrand.Text;
                SmartPhone.PhoneList[iindex].model = txtModel.Text;
                SmartPhone.PhoneList[iindex].size = int.Parse(txtSize.Text);
                SmartPhone.PhoneList[iindex].price = double.Parse(txtPrice.Text);
                SmartPhone.PhoneList[iindex].stock = int.Parse(txtStock.Text);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch(FormatException) 
            {
                MessageBox.Show("Please enter valid values for Size, Price and Stock.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (OverflowException)
            {
                MessageBox.Show("Please enter valid values for Size, Price and Stock.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtbrand_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
