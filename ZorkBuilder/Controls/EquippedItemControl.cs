using System.Collections.Generic;
using System.Windows.Forms;
using InventoryManager.Data;

namespace ZorkBuilder.Controls
{
    public partial class EquippedItemControl : UserControl
    {
        public Player Player
        {
            get => _Player;
            set
            {
                if (_Player != value)
                {
                    _Player = value;
                    if (_Player != null)
                    {
                        var inventory = new List<Item>(_Player.Inventory);
                        inventory.Insert(0, NullItem);
                        equippedItemComboBox.SelectedIndexChanged -= EquippedItemComboBox_SelectedIndexChanged;
                        equippedItemComboBox.DataSource = inventory;
                        EquippedItem = _Player.EquippedItems.TryGetValue(EquipLocation, out Item equippedItem) ? equippedItem: NullItem;

                        equippedItemComboBox.SelectedIndexChanged += EquippedItemComboBox_SelectedIndexChanged;
                    }
                    else
                    {
                        equippedItemComboBox.DataSource = null;
                    }
                }
            }
        }

        private static readonly Item NullItem = new Item() { Name = "Null" };
        public Item EquippedItem
        {
            get => (Item)equippedItemComboBox.SelectedItem;
            set => equippedItemComboBox.SelectedItem = value;
        }
        public EquippedItemControl()
        {
            InitializeComponent();
        }

        private Player _Player;

        private EquipLocations _EquipLocation;

        public EquipLocations EquipLocation
        {
            get => _EquipLocation;
            set
            {
                _EquipLocation = value;
                equipLocationTextBox.Text = _EquipLocation.ToString();
            }
        }
        public void SetEquippedItem(Item value)
        {
            equippedItemComboBox.SelectedItem = value;
        }

        private void EquippedItemComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (_Player != null)
            {
                Item equippedItem = EquippedItem;
                if (equippedItem == NullItem)
                {
                    _Player.EquippedItems.Remove(EquipLocation);
                }
                else
                {
                    _Player.EquippedItems[EquipLocation] = equippedItem;
                }

            }
        }
    }
}
