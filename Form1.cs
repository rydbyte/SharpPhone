using System.ComponentModel.Design.Serialization;
using System.Text.Json;

namespace SharpPhone
{
    public partial class MainPage : Form
    {

        public MainPage()
        {
            InitializeComponent();

            SmartPhone.LoadFromFile("C:\\Users\\ryanl\\source\\repos\\SharpPhone\\phones.json");

            listPhones.Items.Clear();
            foreach (var phone in SmartPhone.PhoneList)
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
                foreach (var phone in SmartPhone.PhoneList)
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
                brand: SmartPhone.PhoneList[index].brand,
                model: SmartPhone.PhoneList[index].model,
                size: SmartPhone.PhoneList[index].size,
                price: SmartPhone.PhoneList[index].price,
                stock: SmartPhone.PhoneList[index].stock
                );
            Page.ShowDialog();
            if (Page.DialogResult == DialogResult.OK)
            {
                listPhones.Items.Clear();
                foreach (var phone in SmartPhone.PhoneList)
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

            int idToDelete = SmartPhone.PhoneList[index].id;

            SmartPhone.DeletePhone(idToDelete);

            listPhones.Items.Clear();
            foreach (var phone in SmartPhone.PhoneList)
            {
                listPhones.Items.Add($"{phone.brand}, Model: {phone.model}, {phone.stock}");
            }
        }

    }
}
