
namespace ZorkBuilder.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newWorldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openWorldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeWorldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.playersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.worldViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.worldTabPage = new System.Windows.Forms.TabPage();
            this.startingListBox1 = new System.Windows.Forms.ComboBox();
            this.startingRoomLabel = new System.Windows.Forms.Label();
            this.playerNameLabel = new System.Windows.Forms.Label();
            this.deleteRoomButton = new System.Windows.Forms.Button();
            this.addRoomButton = new System.Windows.Forms.Button();
            this.roomListBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.playerNameTextBox = new System.Windows.Forms.TextBox();
            this.equippedItemsGroupBox = new System.Windows.Forms.GroupBox();
            this.southDirectionControl = new ZorkBuilder.Controls.EquippedItemControl();
            this.eastDirectionControl = new ZorkBuilder.Controls.EquippedItemControl();
            this.westDirectionControl = new ZorkBuilder.Controls.EquippedItemControl();
            this.northDirectionControl = new ZorkBuilder.Controls.EquippedItemControl();
            this.roomDescriptionGrouBox = new System.Windows.Forms.GroupBox();
            this.removeDescriptionButton = new System.Windows.Forms.Button();
            this.playerInventoryListBox = new System.Windows.Forms.ListBox();
            this.inventoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.addDescriptionButton = new System.Windows.Forms.Button();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.gameTabPage = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.mainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.worldViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            this.worldTabPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.equippedItemsGroupBox.SuspendLayout();
            this.roomDescriptionGrouBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource1)).BeginInit();
            this.mainTabControl.SuspendLayout();
            this.gameTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(561, 24);
            this.mainMenuStrip.TabIndex = 1;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newWorldToolStripMenuItem,
            this.openWorldToolStripMenuItem,
            this.closeWorldToolStripMenuItem,
            this.toolStripMenuItem1,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripMenuItem2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newWorldToolStripMenuItem
            // 
            this.newWorldToolStripMenuItem.Name = "newWorldToolStripMenuItem";
            this.newWorldToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newWorldToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.newWorldToolStripMenuItem.Text = "&New World...";
            this.newWorldToolStripMenuItem.Click += new System.EventHandler(this.NewWorldToolStripMenuItem_Click);
            // 
            // openWorldToolStripMenuItem
            // 
            this.openWorldToolStripMenuItem.Name = "openWorldToolStripMenuItem";
            this.openWorldToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openWorldToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.openWorldToolStripMenuItem.Text = "&Open World...";
            this.openWorldToolStripMenuItem.Click += new System.EventHandler(this.OpenWorldToolStripMenuItem_Click);
            // 
            // closeWorldToolStripMenuItem
            // 
            this.closeWorldToolStripMenuItem.Name = "closeWorldToolStripMenuItem";
            this.closeWorldToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.closeWorldToolStripMenuItem.Text = "&Close World";
            this.closeWorldToolStripMenuItem.Click += new System.EventHandler(this.CloseWorldToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(187, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(187, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "World Files (*json)|*json";
            // 
            // playersBindingSource
            // 
            this.playersBindingSource.DataMember = "Players";
            this.playersBindingSource.DataSource = this.worldViewModelBindingSource;
            // 
            // worldViewModelBindingSource
            // 
            this.worldViewModelBindingSource.DataSource = typeof(ZorkBuilder.ViewModels.WorldViewModel);
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "Items";
            this.itemsBindingSource.DataSource = this.worldViewModelBindingSource;
            // 
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataMember = "Inventory";
            this.inventoryBindingSource.DataSource = this.playersBindingSource;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Worldfiles(*.json)|*.json";
            this.saveFileDialog.Title = "Save world file";
            // 
            // worldTabPage
            // 
            this.worldTabPage.Controls.Add(this.playerNameLabel);
            this.worldTabPage.Controls.Add(this.playerNameTextBox);
            this.worldTabPage.Controls.Add(this.deleteRoomButton);
            this.worldTabPage.Controls.Add(this.addRoomButton);
            this.worldTabPage.Controls.Add(this.roomListBox);
            this.worldTabPage.Controls.Add(this.groupBox1);
            this.worldTabPage.Location = new System.Drawing.Point(4, 22);
            this.worldTabPage.Name = "worldTabPage";
            this.worldTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.worldTabPage.Size = new System.Drawing.Size(553, 455);
            this.worldTabPage.TabIndex = 0;
            this.worldTabPage.Text = "World";
            this.worldTabPage.UseVisualStyleBackColor = true;
            // 
            // startingListBox1
            // 
            this.startingListBox1.FormattingEnabled = true;
            this.startingListBox1.Location = new System.Drawing.Point(130, 27);
            this.startingListBox1.Name = "startingListBox1";
            this.startingListBox1.Size = new System.Drawing.Size(121, 21);
            this.startingListBox1.TabIndex = 6;
            // 
            // startingRoomLabel
            // 
            this.startingRoomLabel.AutoSize = true;
            this.startingRoomLabel.Location = new System.Drawing.Point(146, 11);
            this.startingRoomLabel.Name = "startingRoomLabel";
            this.startingRoomLabel.Size = new System.Drawing.Size(90, 13);
            this.startingRoomLabel.TabIndex = 13;
            this.startingRoomLabel.Text = "Starting Location:";
            // 
            // playerNameLabel
            // 
            this.playerNameLabel.AutoSize = true;
            this.playerNameLabel.Location = new System.Drawing.Point(45, 18);
            this.playerNameLabel.Name = "playerNameLabel";
            this.playerNameLabel.Size = new System.Drawing.Size(66, 13);
            this.playerNameLabel.TabIndex = 11;
            this.playerNameLabel.Text = "&RoomName:";
            // 
            // deleteRoomButton
            // 
            this.deleteRoomButton.Location = new System.Drawing.Point(83, 424);
            this.deleteRoomButton.Name = "deleteRoomButton";
            this.deleteRoomButton.Size = new System.Drawing.Size(75, 23);
            this.deleteRoomButton.TabIndex = 2;
            this.deleteRoomButton.Text = "&Delete";
            this.deleteRoomButton.UseVisualStyleBackColor = true;
            this.deleteRoomButton.Click += new System.EventHandler(this.DeletePlayerButton_Click);
            // 
            // addRoomButton
            // 
            this.addRoomButton.Location = new System.Drawing.Point(2, 424);
            this.addRoomButton.Name = "addRoomButton";
            this.addRoomButton.Size = new System.Drawing.Size(75, 23);
            this.addRoomButton.TabIndex = 1;
            this.addRoomButton.Text = "&Add...";
            this.addRoomButton.UseVisualStyleBackColor = true;
            this.addRoomButton.Click += new System.EventHandler(this.AddPlayerButton_Click);
            // 
            // roomListBox
            // 
            this.roomListBox.DataSource = this.playersBindingSource;
            this.roomListBox.DisplayMember = "Name";
            this.roomListBox.FormattingEnabled = true;
            this.roomListBox.Location = new System.Drawing.Point(3, 60);
            this.roomListBox.Name = "roomListBox";
            this.roomListBox.Size = new System.Drawing.Size(155, 355);
            this.roomListBox.TabIndex = 0;
            this.roomListBox.ValueMember = "Health";
            this.roomListBox.SelectedIndexChanged += new System.EventHandler(this.PlayersListBox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.startingListBox1);
            this.groupBox1.Controls.Add(this.startingRoomLabel);
            this.groupBox1.Controls.Add(this.equippedItemsGroupBox);
            this.groupBox1.Controls.Add(this.roomDescriptionGrouBox);
            this.groupBox1.Location = new System.Drawing.Point(162, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 447);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // playerNameTextBox
            // 
            this.playerNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playersBindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.playerNameTextBox.Location = new System.Drawing.Point(2, 34);
            this.playerNameTextBox.Name = "playerNameTextBox";
            this.playerNameTextBox.Size = new System.Drawing.Size(154, 20);
            this.playerNameTextBox.TabIndex = 12;
            // 
            // equippedItemsGroupBox
            // 
            this.equippedItemsGroupBox.Controls.Add(this.southDirectionControl);
            this.equippedItemsGroupBox.Controls.Add(this.eastDirectionControl);
            this.equippedItemsGroupBox.Controls.Add(this.westDirectionControl);
            this.equippedItemsGroupBox.Controls.Add(this.northDirectionControl);
            this.equippedItemsGroupBox.Location = new System.Drawing.Point(3, 53);
            this.equippedItemsGroupBox.Name = "equippedItemsGroupBox";
            this.equippedItemsGroupBox.Size = new System.Drawing.Size(374, 238);
            this.equippedItemsGroupBox.TabIndex = 2;
            this.equippedItemsGroupBox.TabStop = false;
            this.equippedItemsGroupBox.Text = "Neighbors";
            // 
            // southDirectionControl
            // 
            this.southDirectionControl.EquipLocation = InventoryManager.Data.EquipLocations.Feet;
            this.southDirectionControl.EquippedItem = null;
            this.southDirectionControl.Location = new System.Drawing.Point(127, 149);
            this.southDirectionControl.Name = "southDirectionControl";
            this.southDirectionControl.Player = null;
            this.southDirectionControl.Size = new System.Drawing.Size(122, 49);
            this.southDirectionControl.TabIndex = 3;
            // 
            // eastDirectionControl
            // 
            this.eastDirectionControl.EquipLocation = InventoryManager.Data.EquipLocations.RightHand;
            this.eastDirectionControl.EquippedItem = null;
            this.eastDirectionControl.Location = new System.Drawing.Point(251, 74);
            this.eastDirectionControl.Name = "eastDirectionControl";
            this.eastDirectionControl.Player = null;
            this.eastDirectionControl.Size = new System.Drawing.Size(122, 49);
            this.eastDirectionControl.TabIndex = 2;
            // 
            // westDirectionControl
            // 
            this.westDirectionControl.EquipLocation = InventoryManager.Data.EquipLocations.Head;
            this.westDirectionControl.EquippedItem = null;
            this.westDirectionControl.Location = new System.Drawing.Point(2, 74);
            this.westDirectionControl.Name = "westDirectionControl";
            this.westDirectionControl.Player = null;
            this.westDirectionControl.Size = new System.Drawing.Size(122, 49);
            this.westDirectionControl.TabIndex = 1;
            // 
            // northDirectionControl
            // 
            this.northDirectionControl.EquipLocation = InventoryManager.Data.EquipLocations.Head;
            this.northDirectionControl.EquippedItem = null;
            this.northDirectionControl.Location = new System.Drawing.Point(127, 10);
            this.northDirectionControl.Name = "northDirectionControl";
            this.northDirectionControl.Player = null;
            this.northDirectionControl.Size = new System.Drawing.Size(122, 49);
            this.northDirectionControl.TabIndex = 0;
            // 
            // roomDescriptionGrouBox
            // 
            this.roomDescriptionGrouBox.Controls.Add(this.removeDescriptionButton);
            this.roomDescriptionGrouBox.Controls.Add(this.playerInventoryListBox);
            this.roomDescriptionGrouBox.Controls.Add(this.addDescriptionButton);
            this.roomDescriptionGrouBox.Location = new System.Drawing.Point(6, 297);
            this.roomDescriptionGrouBox.Name = "roomDescriptionGrouBox";
            this.roomDescriptionGrouBox.Size = new System.Drawing.Size(376, 137);
            this.roomDescriptionGrouBox.TabIndex = 0;
            this.roomDescriptionGrouBox.TabStop = false;
            this.roomDescriptionGrouBox.Text = "&Room Description";
            // 
            // removeDescriptionButton
            // 
            this.removeDescriptionButton.Location = new System.Drawing.Point(188, 103);
            this.removeDescriptionButton.Name = "removeDescriptionButton";
            this.removeDescriptionButton.Size = new System.Drawing.Size(75, 23);
            this.removeDescriptionButton.TabIndex = 19;
            this.removeDescriptionButton.Text = "&Delete";
            this.removeDescriptionButton.UseVisualStyleBackColor = true;
            // 
            // playerInventoryListBox
            // 
            this.playerInventoryListBox.DataSource = this.inventoryBindingSource1;
            this.playerInventoryListBox.DisplayMember = "Name";
            this.playerInventoryListBox.FormattingEnabled = true;
            this.playerInventoryListBox.Location = new System.Drawing.Point(2, 15);
            this.playerInventoryListBox.Name = "playerInventoryListBox";
            this.playerInventoryListBox.Size = new System.Drawing.Size(368, 82);
            this.playerInventoryListBox.TabIndex = 0;
            this.playerInventoryListBox.ValueMember = "Description";
            // 
            // inventoryBindingSource1
            // 
            this.inventoryBindingSource1.DataMember = "Inventory";
            this.inventoryBindingSource1.DataSource = this.playersBindingSource;
            // 
            // addDescriptionButton
            // 
            this.addDescriptionButton.Location = new System.Drawing.Point(107, 103);
            this.addDescriptionButton.Name = "addDescriptionButton";
            this.addDescriptionButton.Size = new System.Drawing.Size(75, 23);
            this.addDescriptionButton.TabIndex = 18;
            this.addDescriptionButton.Text = "&Add...";
            this.addDescriptionButton.UseVisualStyleBackColor = true;
            // 
            // mainTabControl
            // 
            this.mainTabControl.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.mainTabControl.Controls.Add(this.worldTabPage);
            this.mainTabControl.Controls.Add(this.gameTabPage);
            this.mainTabControl.Location = new System.Drawing.Point(0, 27);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(561, 481);
            this.mainTabControl.TabIndex = 5;
            // 
            // gameTabPage
            // 
            this.gameTabPage.Controls.Add(this.label1);
            this.gameTabPage.Controls.Add(this.textBox1);
            this.gameTabPage.Controls.Add(this.button1);
            this.gameTabPage.Controls.Add(this.button2);
            this.gameTabPage.Controls.Add(this.listBox1);
            this.gameTabPage.Location = new System.Drawing.Point(4, 22);
            this.gameTabPage.Name = "gameTabPage";
            this.gameTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.gameTabPage.Size = new System.Drawing.Size(553, 455);
            this.gameTabPage.TabIndex = 1;
            this.gameTabPage.Text = "Game";
            this.gameTabPage.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "&Players";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playersBindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox1.Location = new System.Drawing.Point(192, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(154, 20);
            this.textBox1.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(273, 419);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "&Delete";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(192, 419);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "&Add...";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.playersBindingSource;
            this.listBox1.DisplayMember = "Name";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(193, 55);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(155, 355);
            this.listBox1.TabIndex = 13;
            this.listBox1.ValueMember = "Health";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 508);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.mainMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mainMenuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Manager";
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.worldViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            this.worldTabPage.ResumeLayout(false);
            this.worldTabPage.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.equippedItemsGroupBox.ResumeLayout(false);
            this.roomDescriptionGrouBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource1)).EndInit();
            this.mainTabControl.ResumeLayout(false);
            this.gameTabPage.ResumeLayout(false);
            this.gameTabPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.BindingSource worldViewModelBindingSource;
        private System.Windows.Forms.BindingSource playersBindingSource;
        private System.Windows.Forms.ToolStripMenuItem openWorldToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private System.Windows.Forms.ToolStripMenuItem closeWorldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newWorldToolStripMenuItem;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.TabPage worldTabPage;
        private System.Windows.Forms.TextBox playerNameTextBox;
        private System.Windows.Forms.Label playerNameLabel;
        private System.Windows.Forms.Button deleteRoomButton;
        private System.Windows.Forms.Button addRoomButton;
        private System.Windows.Forms.ListBox roomListBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox equippedItemsGroupBox;
        private Controls.EquippedItemControl southDirectionControl;
        private Controls.EquippedItemControl eastDirectionControl;
        private Controls.EquippedItemControl westDirectionControl;
        private Controls.EquippedItemControl northDirectionControl;
        private System.Windows.Forms.GroupBox roomDescriptionGrouBox;
        private System.Windows.Forms.Button removeDescriptionButton;
        private System.Windows.Forms.ListBox playerInventoryListBox;
        private System.Windows.Forms.Button addDescriptionButton;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.BindingSource inventoryBindingSource1;
        private System.Windows.Forms.Label startingRoomLabel;
        private System.Windows.Forms.ComboBox startingListBox1;
        private System.Windows.Forms.TabPage gameTabPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox1;
    }
}

