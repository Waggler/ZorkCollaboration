using System;
using System.Windows.Forms;

namespace ZorkBuilder.Forms
{
    public partial class AddItemForm : Form
    {
        public AddItemForm()
        {
            InitializeComponent();
        }
        public string ItemName
        {
            get => itemNameTextBox.Text;
            set => itemNameTextBox.Text = value;
        }
        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            okButton.Enabled = !string.IsNullOrEmpty(ItemName);
        }
    }
}
