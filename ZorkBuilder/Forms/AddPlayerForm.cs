using System;
using System.Windows.Forms;

namespace ZorkBuilder.Forms
{
    public partial class AddPlayerForm : Form
    {
        public AddPlayerForm()
        {
            InitializeComponent();
        }
        public string PlayerName
        {
            get => playerNameTextBox.Text;
            set => playerNameTextBox.Text = value;
        }
        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            okButton.Enabled = !string.IsNullOrEmpty(PlayerName);
        }
    }
}
