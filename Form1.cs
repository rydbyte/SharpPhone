using System.ComponentModel.Design.Serialization;
using System.Text.Json;

namespace SharpPhone
{
    public partial class MainPage : Form
    {

        public MainPage()
        {
            InitializeComponent();

            foreach (SmartPhone phone in SharpPhoneDataBase.phoneList)
            {
                listPhones.Items.Add($"{phone.brand}, Model: {phone.model}, Stock: {phone.stock}");
            }
        }

        private void btnAddphone_Click(object sender, EventArgs e)
        {
            AddPhonePage Page = new AddPhonePage();
            Page.ShowDialog();
            if (Page.DialogResult == DialogResult.OK)
            {
                listPhones.Items.Clear();
                foreach (SmartPhone phone in SharpPhoneDataBase.phoneList)
                {
                    listPhones.Items.Add($"{phone.brand}, Model: {phone.model}, Stock: {phone.stock}");
                }
            }
        }

        private void listPhones_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            int index = listPhones.SelectedIndex;
            if (index <= -1)
            {
                MessageBox.Show("Please select a phone to modify.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ModifyPhonePage Page = new ModifyPhonePage(
                index: index,
                brand: SharpPhoneDataBase.phoneList[index].brand,
                model: SharpPhoneDataBase.phoneList[index].model,
                size:  SharpPhoneDataBase.phoneList[index].size,
                price: SharpPhoneDataBase.phoneList[index].price,
                stock: SharpPhoneDataBase.phoneList[index].stock
                );
            Page.ShowDialog();
            if (Page.DialogResult == DialogResult.OK)
            {
                listPhones.Items.Clear();
                foreach (SmartPhone phone in SharpPhoneDataBase.phoneList)
                {
                    listPhones.Items.Add($"{phone.brand}, Model: {phone.model}, Stock: {phone.stock}");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = listPhones.SelectedIndex;

            if (index < 0)
            {
                MessageBox.Show("Please select a phone to delete.");
                return;
            }

            int idToDelete = SharpPhoneDataBase.phoneList[index].id;

            JsonStore.Delete(idToDelete);

            listPhones.Items.Clear();
            foreach (SmartPhone phone in SharpPhoneDataBase.phoneList)
            {
                listPhones.Items.Add($"{phone.brand}, Model: {phone.model}, Stock: {phone.stock}");
            }
        }
    }
}
