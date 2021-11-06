using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json;
using InventoryManager.Data;
using ZorkBuilder.ViewModels;
using ZorkBuilder.Controls;

namespace ZorkBuilder.Forms

{
    public partial class MainForm : Form
    {
        public static string AssemblyTitle = Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyTitleAttribute>().Title;
        private WorldViewModel viewModel;
        private bool isWorldLoaded;
        private readonly Dictionary<EquipLocations, EquippedItemControl> _EquippedItemControlMap;

        private WorldViewModel ViewModel
        {
            get => viewModel;
            set
            {
                if (viewModel != value)
                {
                    viewModel = value;
                    worldViewModelBindingSource.DataSource = viewModel;
                }
            }
        }

        private bool IsWorldLoaded 
        {
            get => isWorldLoaded;
            set
            {
                isWorldLoaded = value;
                mainTabControl.Enabled = isWorldLoaded;
                saveToolStripMenuItem.Enabled = isWorldLoaded;
                saveAsToolStripMenuItem.Enabled = isWorldLoaded;
                closeWorldToolStripMenuItem.Enabled = isWorldLoaded;
            }
        }

        public MainForm()
        {
            InitializeComponent();
            ViewModel = new WorldViewModel();
            IsWorldLoaded = false;
            _EquippedItemControlMap = new Dictionary<EquipLocations, EquippedItemControl>
            {
                { EquipLocations.LeftHand, westDirectionControl },
                { EquipLocations.RightHand, eastDirectionControl },
                { EquipLocations.Head, northDirectionControl },
                { EquipLocations.Feet, southDirectionControl }
            };
        }

        private void PlayersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            deleteRoomButton.Enabled = roomListBox.SelectedItem != null;

            Player selectedPlayer = roomListBox.SelectedItem as Player;
            foreach (var control in _EquippedItemControlMap.Values)
            {
                control.Player = selectedPlayer;
            }
        }

        private void AddPlayerButton_Click(object sender, EventArgs e)
        {
            using (AddPlayerForm addPlayerForm = new AddPlayerForm())
            {
                if (addPlayerForm.ShowDialog() == DialogResult.OK)
                {
                    Player player = new Player { Name = addPlayerForm.PlayerName };
                    ViewModel.Players.Add(player);
                }
            }
        }

        private void DeletePlayerButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete this player?", AssemblyTitle, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ViewModel.Players.Remove((Player)roomListBox.SelectedItem);
                roomListBox.SelectedItem = ViewModel.Players.FirstOrDefault();
            }
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            using (AddItemForm addItemForm = new AddItemForm())
            {
                if (addItemForm.ShowDialog() == DialogResult.OK)
                {
                    Item item = new Item {Name = addItemForm.ItemName };
                    ViewModel.Rooms.Add(item);
                }
            }
        }

        private void NewWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ViewModel.Filename = saveFileDialog.FileName;
                ViewModel.CreateGame();

                if(IsWorldLoaded == false)
                {
                    IsWorldLoaded = true;
                }

                ViewModel.World = JsonConvert.DeserializeObject<World>(File.ReadAllText(saveFileDialog.FileName));
            }
        }

        private void OpenWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ViewModel.World = JsonConvert.DeserializeObject<World>(File.ReadAllText(openFileDialog.FileName));
                ViewModel.Filename = openFileDialog.FileName;

                Player selectedPlayer = roomListBox.SelectedItem as Player;
                foreach (var control in _EquippedItemControlMap.Values)
                {
                    control.Player = selectedPlayer;
                }

                IsWorldLoaded = true;
            }
        }
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e) => ViewModel.SaveGame();

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ViewModel.Filename = saveFileDialog.FileName;
                ViewModel.SaveGame();
            }
        }
        private void CloseWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewModel.World = null;
            IsWorldLoaded = false;
        }
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
