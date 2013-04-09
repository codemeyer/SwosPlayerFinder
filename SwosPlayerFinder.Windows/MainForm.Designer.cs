namespace Manicomio.SwosPlayerFinder.Windows
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
            this.SearchGroupBox = new System.Windows.Forms.GroupBox();
            this.FinishingToComboBox = new System.Windows.Forms.ComboBox();
            this.FinishingFromComboBox = new System.Windows.Forms.ComboBox();
            this.SpeedToComboBox = new System.Windows.Forms.ComboBox();
            this.SpeedFromComboBox = new System.Windows.Forms.ComboBox();
            this.ControlToComboBox = new System.Windows.Forms.ComboBox();
            this.ControlFromComboBox = new System.Windows.Forms.ComboBox();
            this.TacklingToComboBox = new System.Windows.Forms.ComboBox();
            this.TacklingFromComboBox = new System.Windows.Forms.ComboBox();
            this.HeadingToComboBox = new System.Windows.Forms.ComboBox();
            this.ShootingToComboBox = new System.Windows.Forms.ComboBox();
            this.HeadingFromComboBox = new System.Windows.Forms.ComboBox();
            this.ShootingFromComboBox = new System.Windows.Forms.ComboBox();
            this.PassingToComboBox = new System.Windows.Forms.ComboBox();
            this.PassingFromComboBox = new System.Windows.Forms.ComboBox();
            this.PlayerListView = new System.Windows.Forms.ListView();
            this.NameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NationalityColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TeamColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TeamNationalityColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PositionColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ValueColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PassingColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ShootingColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HeadingColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TacklingColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ControlColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SpeedColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FinishingColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ShowingPlayersCountLabel = new System.Windows.Forms.Label();
            this.TeamTextBox = new System.Windows.Forms.TextBox();
            this.UpdateListButton = new System.Windows.Forms.Button();
            this.NationalityComboBox = new System.Windows.Forms.ComboBox();
            this.ValueToComboBox = new System.Windows.Forms.ComboBox();
            this.ValueFromComboBox = new System.Windows.Forms.ComboBox();
            this.PositionComboBox = new System.Windows.Forms.ComboBox();
            this.BrowseDataButton = new System.Windows.Forms.Button();
            this.LoadDataButton = new System.Windows.Forms.Button();
            this.DataLabel = new System.Windows.Forms.Label();
            this.DataFolderTextBox = new System.Windows.Forms.TextBox();
            this.TopGroupBox = new System.Windows.Forms.GroupBox();
            this.PlayersLoadedCountLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SearchGroupBox.SuspendLayout();
            this.TopGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchGroupBox
            // 
            this.SearchGroupBox.Controls.Add(this.FinishingToComboBox);
            this.SearchGroupBox.Controls.Add(this.FinishingFromComboBox);
            this.SearchGroupBox.Controls.Add(this.SpeedToComboBox);
            this.SearchGroupBox.Controls.Add(this.SpeedFromComboBox);
            this.SearchGroupBox.Controls.Add(this.ControlToComboBox);
            this.SearchGroupBox.Controls.Add(this.ControlFromComboBox);
            this.SearchGroupBox.Controls.Add(this.TacklingToComboBox);
            this.SearchGroupBox.Controls.Add(this.TacklingFromComboBox);
            this.SearchGroupBox.Controls.Add(this.HeadingToComboBox);
            this.SearchGroupBox.Controls.Add(this.ShootingToComboBox);
            this.SearchGroupBox.Controls.Add(this.HeadingFromComboBox);
            this.SearchGroupBox.Controls.Add(this.ShootingFromComboBox);
            this.SearchGroupBox.Controls.Add(this.PassingToComboBox);
            this.SearchGroupBox.Controls.Add(this.PassingFromComboBox);
            this.SearchGroupBox.Controls.Add(this.PlayerListView);
            this.SearchGroupBox.Controls.Add(this.ShowingPlayersCountLabel);
            this.SearchGroupBox.Controls.Add(this.TeamTextBox);
            this.SearchGroupBox.Controls.Add(this.UpdateListButton);
            this.SearchGroupBox.Controls.Add(this.NationalityComboBox);
            this.SearchGroupBox.Controls.Add(this.ValueToComboBox);
            this.SearchGroupBox.Controls.Add(this.ValueFromComboBox);
            this.SearchGroupBox.Controls.Add(this.PositionComboBox);
            this.SearchGroupBox.Enabled = false;
            this.SearchGroupBox.Location = new System.Drawing.Point(12, 80);
            this.SearchGroupBox.Name = "SearchGroupBox";
            this.SearchGroupBox.Size = new System.Drawing.Size(1021, 591);
            this.SearchGroupBox.TabIndex = 1;
            this.SearchGroupBox.TabStop = false;
            this.SearchGroupBox.Text = "Search";
            // 
            // FinishingToComboBox
            // 
            this.FinishingToComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FinishingToComboBox.FormattingEnabled = true;
            this.FinishingToComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.FinishingToComboBox.Location = new System.Drawing.Point(921, 50);
            this.FinishingToComboBox.Name = "FinishingToComboBox";
            this.FinishingToComboBox.Size = new System.Drawing.Size(34, 21);
            this.FinishingToComboBox.TabIndex = 19;
            // 
            // FinishingFromComboBox
            // 
            this.FinishingFromComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FinishingFromComboBox.FormattingEnabled = true;
            this.FinishingFromComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.FinishingFromComboBox.Location = new System.Drawing.Point(921, 22);
            this.FinishingFromComboBox.Name = "FinishingFromComboBox";
            this.FinishingFromComboBox.Size = new System.Drawing.Size(34, 21);
            this.FinishingFromComboBox.TabIndex = 18;
            // 
            // SpeedToComboBox
            // 
            this.SpeedToComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SpeedToComboBox.FormattingEnabled = true;
            this.SpeedToComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.SpeedToComboBox.Location = new System.Drawing.Point(881, 50);
            this.SpeedToComboBox.Name = "SpeedToComboBox";
            this.SpeedToComboBox.Size = new System.Drawing.Size(34, 21);
            this.SpeedToComboBox.TabIndex = 17;
            // 
            // SpeedFromComboBox
            // 
            this.SpeedFromComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SpeedFromComboBox.FormattingEnabled = true;
            this.SpeedFromComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.SpeedFromComboBox.Location = new System.Drawing.Point(881, 22);
            this.SpeedFromComboBox.Name = "SpeedFromComboBox";
            this.SpeedFromComboBox.Size = new System.Drawing.Size(34, 21);
            this.SpeedFromComboBox.TabIndex = 16;
            // 
            // ControlToComboBox
            // 
            this.ControlToComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ControlToComboBox.FormattingEnabled = true;
            this.ControlToComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.ControlToComboBox.Location = new System.Drawing.Point(841, 50);
            this.ControlToComboBox.Name = "ControlToComboBox";
            this.ControlToComboBox.Size = new System.Drawing.Size(34, 21);
            this.ControlToComboBox.TabIndex = 15;
            // 
            // ControlFromComboBox
            // 
            this.ControlFromComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ControlFromComboBox.FormattingEnabled = true;
            this.ControlFromComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.ControlFromComboBox.Location = new System.Drawing.Point(841, 22);
            this.ControlFromComboBox.Name = "ControlFromComboBox";
            this.ControlFromComboBox.Size = new System.Drawing.Size(34, 21);
            this.ControlFromComboBox.TabIndex = 14;
            // 
            // TacklingToComboBox
            // 
            this.TacklingToComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TacklingToComboBox.FormattingEnabled = true;
            this.TacklingToComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.TacklingToComboBox.Location = new System.Drawing.Point(801, 50);
            this.TacklingToComboBox.Name = "TacklingToComboBox";
            this.TacklingToComboBox.Size = new System.Drawing.Size(34, 21);
            this.TacklingToComboBox.TabIndex = 13;
            // 
            // TacklingFromComboBox
            // 
            this.TacklingFromComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TacklingFromComboBox.FormattingEnabled = true;
            this.TacklingFromComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.TacklingFromComboBox.Location = new System.Drawing.Point(801, 22);
            this.TacklingFromComboBox.Name = "TacklingFromComboBox";
            this.TacklingFromComboBox.Size = new System.Drawing.Size(34, 21);
            this.TacklingFromComboBox.TabIndex = 12;
            // 
            // HeadingToComboBox
            // 
            this.HeadingToComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HeadingToComboBox.FormattingEnabled = true;
            this.HeadingToComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.HeadingToComboBox.Location = new System.Drawing.Point(761, 50);
            this.HeadingToComboBox.Name = "HeadingToComboBox";
            this.HeadingToComboBox.Size = new System.Drawing.Size(34, 21);
            this.HeadingToComboBox.TabIndex = 11;
            // 
            // ShootingToComboBox
            // 
            this.ShootingToComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ShootingToComboBox.FormattingEnabled = true;
            this.ShootingToComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.ShootingToComboBox.Location = new System.Drawing.Point(721, 50);
            this.ShootingToComboBox.Name = "ShootingToComboBox";
            this.ShootingToComboBox.Size = new System.Drawing.Size(34, 21);
            this.ShootingToComboBox.TabIndex = 9;
            // 
            // HeadingFromComboBox
            // 
            this.HeadingFromComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HeadingFromComboBox.FormattingEnabled = true;
            this.HeadingFromComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.HeadingFromComboBox.Location = new System.Drawing.Point(761, 22);
            this.HeadingFromComboBox.Name = "HeadingFromComboBox";
            this.HeadingFromComboBox.Size = new System.Drawing.Size(34, 21);
            this.HeadingFromComboBox.TabIndex = 10;
            // 
            // ShootingFromComboBox
            // 
            this.ShootingFromComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ShootingFromComboBox.FormattingEnabled = true;
            this.ShootingFromComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.ShootingFromComboBox.Location = new System.Drawing.Point(721, 22);
            this.ShootingFromComboBox.Name = "ShootingFromComboBox";
            this.ShootingFromComboBox.Size = new System.Drawing.Size(34, 21);
            this.ShootingFromComboBox.TabIndex = 8;
            // 
            // PassingToComboBox
            // 
            this.PassingToComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PassingToComboBox.FormattingEnabled = true;
            this.PassingToComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.PassingToComboBox.Location = new System.Drawing.Point(681, 50);
            this.PassingToComboBox.Name = "PassingToComboBox";
            this.PassingToComboBox.Size = new System.Drawing.Size(34, 21);
            this.PassingToComboBox.TabIndex = 7;
            // 
            // PassingFromComboBox
            // 
            this.PassingFromComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PassingFromComboBox.FormattingEnabled = true;
            this.PassingFromComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.PassingFromComboBox.Location = new System.Drawing.Point(681, 22);
            this.PassingFromComboBox.Name = "PassingFromComboBox";
            this.PassingFromComboBox.Size = new System.Drawing.Size(34, 21);
            this.PassingFromComboBox.TabIndex = 6;
            // 
            // PlayerListView
            // 
            this.PlayerListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameColumnHeader,
            this.NationalityColumnHeader,
            this.TeamColumnHeader,
            this.TeamNationalityColumnHeader,
            this.PositionColumnHeader,
            this.ValueColumnHeader,
            this.PassingColumnHeader,
            this.ShootingColumnHeader,
            this.HeadingColumnHeader,
            this.TacklingColumnHeader,
            this.ControlColumnHeader,
            this.SpeedColumnHeader,
            this.FinishingColumnHeader});
            this.PlayerListView.FullRowSelect = true;
            this.PlayerListView.HideSelection = false;
            this.PlayerListView.Location = new System.Drawing.Point(6, 77);
            this.PlayerListView.Name = "PlayerListView";
            this.PlayerListView.Size = new System.Drawing.Size(1009, 484);
            this.PlayerListView.TabIndex = 20;
            this.PlayerListView.UseCompatibleStateImageBehavior = false;
            this.PlayerListView.View = System.Windows.Forms.View.Details;
            // 
            // NameColumnHeader
            // 
            this.NameColumnHeader.Text = "Name";
            this.NameColumnHeader.Width = 200;
            // 
            // NationalityColumnHeader
            // 
            this.NationalityColumnHeader.Text = "Nationality";
            this.NationalityColumnHeader.Width = 100;
            // 
            // TeamColumnHeader
            // 
            this.TeamColumnHeader.Text = "Team";
            this.TeamColumnHeader.Width = 150;
            // 
            // TeamNationalityColumnHeader
            // 
            this.TeamNationalityColumnHeader.Text = "Team Nat.";
            this.TeamNationalityColumnHeader.Width = 100;
            // 
            // PositionColumnHeader
            // 
            this.PositionColumnHeader.Text = "Pos";
            // 
            // ValueColumnHeader
            // 
            this.ValueColumnHeader.Text = "Value";
            this.ValueColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PassingColumnHeader
            // 
            this.PassingColumnHeader.Text = "P";
            this.PassingColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PassingColumnHeader.Width = 40;
            // 
            // ShootingColumnHeader
            // 
            this.ShootingColumnHeader.Text = "S";
            this.ShootingColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ShootingColumnHeader.Width = 40;
            // 
            // HeadingColumnHeader
            // 
            this.HeadingColumnHeader.Text = "H";
            this.HeadingColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.HeadingColumnHeader.Width = 40;
            // 
            // TacklingColumnHeader
            // 
            this.TacklingColumnHeader.Text = "T";
            this.TacklingColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TacklingColumnHeader.Width = 40;
            // 
            // ControlColumnHeader
            // 
            this.ControlColumnHeader.Text = "C";
            this.ControlColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ControlColumnHeader.Width = 40;
            // 
            // SpeedColumnHeader
            // 
            this.SpeedColumnHeader.Text = "V";
            this.SpeedColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SpeedColumnHeader.Width = 40;
            // 
            // FinishingColumnHeader
            // 
            this.FinishingColumnHeader.Text = "F";
            this.FinishingColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.FinishingColumnHeader.Width = 40;
            // 
            // ShowingPlayersCountLabel
            // 
            this.ShowingPlayersCountLabel.AutoSize = true;
            this.ShowingPlayersCountLabel.Location = new System.Drawing.Point(6, 564);
            this.ShowingPlayersCountLabel.Name = "ShowingPlayersCountLabel";
            this.ShowingPlayersCountLabel.Size = new System.Drawing.Size(94, 13);
            this.ShowingPlayersCountLabel.TabIndex = 20;
            this.ShowingPlayersCountLabel.Text = "Showing 0 players";
            // 
            // TeamTextBox
            // 
            this.TeamTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TeamTextBox.Location = new System.Drawing.Point(312, 50);
            this.TeamTextBox.Name = "TeamTextBox";
            this.TeamTextBox.Size = new System.Drawing.Size(142, 21);
            this.TeamTextBox.TabIndex = 2;
            this.TeamTextBox.Visible = false;
            // 
            // UpdateListButton
            // 
            this.UpdateListButton.Location = new System.Drawing.Point(6, 22);
            this.UpdateListButton.Name = "UpdateListButton";
            this.UpdateListButton.Size = new System.Drawing.Size(131, 49);
            this.UpdateListButton.TabIndex = 0;
            this.UpdateListButton.Text = "Update";
            this.UpdateListButton.UseVisualStyleBackColor = true;
            this.UpdateListButton.Click += new System.EventHandler(this.UpdateListButton_Click);
            // 
            // NationalityComboBox
            // 
            this.NationalityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NationalityComboBox.FormattingEnabled = true;
            this.NationalityComboBox.Location = new System.Drawing.Point(209, 50);
            this.NationalityComboBox.Name = "NationalityComboBox";
            this.NationalityComboBox.Size = new System.Drawing.Size(97, 21);
            this.NationalityComboBox.TabIndex = 1;
            this.NationalityComboBox.Visible = false;
            // 
            // ValueToComboBox
            // 
            this.ValueToComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ValueToComboBox.FormattingEnabled = true;
            this.ValueToComboBox.Items.AddRange(new object[] {
            "0",
            "25",
            "30",
            "40",
            "50",
            "65",
            "75",
            "85",
            "100",
            "110",
            "130",
            "150",
            "160",
            "180",
            "200",
            "250",
            "300",
            "350",
            "450",
            "500",
            "550",
            "600",
            "650",
            "700",
            "750",
            "800",
            "850",
            "950",
            "1000",
            "1100",
            "1300",
            "1500",
            "1600",
            "1800",
            "1900",
            "2000",
            "2250",
            "2750",
            "3000",
            "3500",
            "4500",
            "5000",
            "6000",
            "7000",
            "8000",
            "9000",
            "10000",
            "12000",
            "15000",
            "16000"});
            this.ValueToComboBox.Location = new System.Drawing.Point(621, 50);
            this.ValueToComboBox.Name = "ValueToComboBox";
            this.ValueToComboBox.Size = new System.Drawing.Size(54, 21);
            this.ValueToComboBox.TabIndex = 5;
            // 
            // ValueFromComboBox
            // 
            this.ValueFromComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ValueFromComboBox.FormattingEnabled = true;
            this.ValueFromComboBox.Items.AddRange(new object[] {
            "0",
            "25",
            "30",
            "40",
            "50",
            "65",
            "75",
            "85",
            "100",
            "110",
            "130",
            "150",
            "160",
            "180",
            "200",
            "250",
            "300",
            "350",
            "450",
            "500",
            "550",
            "600",
            "650",
            "700",
            "750",
            "800",
            "850",
            "950",
            "1000",
            "1100",
            "1300",
            "1500",
            "1600",
            "1800",
            "1900",
            "2000",
            "2250",
            "2750",
            "3000",
            "3500",
            "4500",
            "5000",
            "6000",
            "7000",
            "8000",
            "9000",
            "10000",
            "12000",
            "15000",
            "16000"});
            this.ValueFromComboBox.Location = new System.Drawing.Point(621, 22);
            this.ValueFromComboBox.Name = "ValueFromComboBox";
            this.ValueFromComboBox.Size = new System.Drawing.Size(54, 21);
            this.ValueFromComboBox.TabIndex = 4;
            // 
            // PositionComboBox
            // 
            this.PositionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PositionComboBox.FormattingEnabled = true;
            this.PositionComboBox.Items.AddRange(new object[] {
            "(any)",
            "G",
            "D",
            "RB",
            "LB",
            "D+RB+LB",
            "M",
            "RW",
            "LW",
            "M+RW+LW",
            "A"});
            this.PositionComboBox.Location = new System.Drawing.Point(558, 50);
            this.PositionComboBox.Name = "PositionComboBox";
            this.PositionComboBox.Size = new System.Drawing.Size(57, 21);
            this.PositionComboBox.TabIndex = 3;
            // 
            // BrowseDataButton
            // 
            this.BrowseDataButton.Location = new System.Drawing.Point(420, 19);
            this.BrowseDataButton.Name = "BrowseDataButton";
            this.BrowseDataButton.Size = new System.Drawing.Size(75, 23);
            this.BrowseDataButton.TabIndex = 2;
            this.BrowseDataButton.Text = "Browse";
            this.BrowseDataButton.UseVisualStyleBackColor = true;
            this.BrowseDataButton.Click += new System.EventHandler(this.BrowseDataButton_Click);
            // 
            // LoadDataButton
            // 
            this.LoadDataButton.Location = new System.Drawing.Point(501, 18);
            this.LoadDataButton.Name = "LoadDataButton";
            this.LoadDataButton.Size = new System.Drawing.Size(254, 23);
            this.LoadDataButton.TabIndex = 3;
            this.LoadDataButton.Text = "Load Data";
            this.LoadDataButton.UseVisualStyleBackColor = true;
            this.LoadDataButton.Click += new System.EventHandler(this.LoadDataButton_Click);
            // 
            // DataLabel
            // 
            this.DataLabel.AutoSize = true;
            this.DataLabel.Location = new System.Drawing.Point(11, 23);
            this.DataLabel.Name = "DataLabel";
            this.DataLabel.Size = new System.Drawing.Size(30, 13);
            this.DataLabel.TabIndex = 0;
            this.DataLabel.Text = "Data";
            // 
            // DataFolderTextBox
            // 
            this.DataFolderTextBox.Location = new System.Drawing.Point(104, 20);
            this.DataFolderTextBox.Name = "DataFolderTextBox";
            this.DataFolderTextBox.Size = new System.Drawing.Size(310, 21);
            this.DataFolderTextBox.TabIndex = 1;
            // 
            // TopGroupBox
            // 
            this.TopGroupBox.Controls.Add(this.PlayersLoadedCountLabel);
            this.TopGroupBox.Controls.Add(this.DataLabel);
            this.TopGroupBox.Controls.Add(this.BrowseDataButton);
            this.TopGroupBox.Controls.Add(this.DataFolderTextBox);
            this.TopGroupBox.Controls.Add(this.LoadDataButton);
            this.TopGroupBox.Location = new System.Drawing.Point(12, 12);
            this.TopGroupBox.Name = "TopGroupBox";
            this.TopGroupBox.Size = new System.Drawing.Size(1021, 55);
            this.TopGroupBox.TabIndex = 0;
            this.TopGroupBox.TabStop = false;
            // 
            // PlayersLoadedCountLabel
            // 
            this.PlayersLoadedCountLabel.AutoSize = true;
            this.PlayersLoadedCountLabel.Location = new System.Drawing.Point(800, 24);
            this.PlayersLoadedCountLabel.Name = "PlayersLoadedCountLabel";
            this.PlayersLoadedCountLabel.Size = new System.Drawing.Size(86, 13);
            this.PlayersLoadedCountLabel.TabIndex = 4;
            this.PlayersLoadedCountLabel.Text = "0 players loaded";
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(958, 682);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 717);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.TopGroupBox);
            this.Controls.Add(this.SearchGroupBox);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "SWOS Player Finder";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SearchGroupBox.ResumeLayout(false);
            this.SearchGroupBox.PerformLayout();
            this.TopGroupBox.ResumeLayout(false);
            this.TopGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SearchGroupBox;
        private System.Windows.Forms.ComboBox FinishingToComboBox;
        private System.Windows.Forms.ComboBox FinishingFromComboBox;
        private System.Windows.Forms.ComboBox SpeedToComboBox;
        private System.Windows.Forms.ComboBox SpeedFromComboBox;
        private System.Windows.Forms.ComboBox ControlToComboBox;
        private System.Windows.Forms.ComboBox ControlFromComboBox;
        private System.Windows.Forms.ComboBox TacklingToComboBox;
        private System.Windows.Forms.ComboBox TacklingFromComboBox;
        private System.Windows.Forms.ComboBox HeadingToComboBox;
        private System.Windows.Forms.ComboBox ShootingToComboBox;
        private System.Windows.Forms.ComboBox HeadingFromComboBox;
        private System.Windows.Forms.ComboBox ShootingFromComboBox;
        private System.Windows.Forms.ComboBox PassingToComboBox;
        private System.Windows.Forms.ComboBox PassingFromComboBox;
        private System.Windows.Forms.ListView PlayerListView;
        private System.Windows.Forms.ColumnHeader NameColumnHeader;
        private System.Windows.Forms.ColumnHeader NationalityColumnHeader;
        private System.Windows.Forms.ColumnHeader TeamColumnHeader;
        private System.Windows.Forms.ColumnHeader TeamNationalityColumnHeader;
        private System.Windows.Forms.ColumnHeader PositionColumnHeader;
        private System.Windows.Forms.ColumnHeader ValueColumnHeader;
        private System.Windows.Forms.ColumnHeader PassingColumnHeader;
        private System.Windows.Forms.ColumnHeader ShootingColumnHeader;
        private System.Windows.Forms.ColumnHeader HeadingColumnHeader;
        private System.Windows.Forms.ColumnHeader TacklingColumnHeader;
        private System.Windows.Forms.ColumnHeader ControlColumnHeader;
        private System.Windows.Forms.ColumnHeader SpeedColumnHeader;
        private System.Windows.Forms.ColumnHeader FinishingColumnHeader;
        private System.Windows.Forms.Label ShowingPlayersCountLabel;
        private System.Windows.Forms.TextBox TeamTextBox;
        private System.Windows.Forms.Button UpdateListButton;
        private System.Windows.Forms.ComboBox NationalityComboBox;
        private System.Windows.Forms.ComboBox ValueToComboBox;
        private System.Windows.Forms.ComboBox ValueFromComboBox;
        private System.Windows.Forms.ComboBox PositionComboBox;
        private System.Windows.Forms.Button BrowseDataButton;
        private System.Windows.Forms.Button LoadDataButton;
        private System.Windows.Forms.Label DataLabel;
        private System.Windows.Forms.TextBox DataFolderTextBox;
        private System.Windows.Forms.GroupBox TopGroupBox;
        private System.Windows.Forms.Label PlayersLoadedCountLabel;
        private System.Windows.Forms.Button ExitButton;
    }
}

