using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Manicomio.SwosPlayerFinder.Core;

namespace Manicomio.SwosPlayerFinder.Windows
{
    public partial class MainForm : Form, ISearchView
    {
        private SearchPresenter _presenter;

        public MainForm()
        {
            _presenter = new SearchPresenter(this);
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            PositionComboBox.SelectedIndex = 0;
            SetValuesComboBoxDefaultValues();
            SetSkillComboBoxesDefaultValues();

            _presenter.GetLatestFolder();
        }

        private void SetValuesComboBoxDefaultValues()
        {
            ValueFromComboBox.SelectedIndex = 0;
            ValueToComboBox.SelectedIndex = ValueToComboBox.Items.Count - 1;
        }

        private void SetSkillComboBoxesDefaultValues()
        {
            PassingFromComboBox.SelectedIndex = 0;
            PassingToComboBox.SelectedIndex = 7;

            ShootingFromComboBox.SelectedIndex = 0;
            ShootingToComboBox.SelectedIndex = 7;

            HeadingFromComboBox.SelectedIndex = 0;
            HeadingToComboBox.SelectedIndex = 7;

            TacklingFromComboBox.SelectedIndex = 0;
            TacklingToComboBox.SelectedIndex = 7;

            ControlFromComboBox.SelectedIndex = 0;
            ControlToComboBox.SelectedIndex = 7;

            SpeedFromComboBox.SelectedIndex = 0;
            SpeedToComboBox.SelectedIndex = 7;

            FinishingFromComboBox.SelectedIndex = 0;
            FinishingToComboBox.SelectedIndex = 7;
        }

        private void LoadDataButton_Click(object sender, EventArgs e)
        {
            Application.UseWaitCursor = true;
            
            _presenter.LoadPlayers(DataFolderTextBox.Text);
            //_presenter.
            SearchGroupBox.Enabled = true;

            Application.UseWaitCursor = false;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void DisplaySearchResults(List<Player> foundPlayers)
        {
            PlayerListView.Items.Clear();

            foreach (var player in foundPlayers)
            {
                ListViewItem item = PlayerListView.Items.Add(player.Name);

                item.SubItems.AddRange(
                    new[]
                        {
                            player.Nationality,
                            player.Team.Name,
                            player.Team.Nationality,
                            GetPositionCode(player.Position),
                            player.Value.ToString(),
                            player.Skills.Passing.ToString(),
                            player.Skills.Shooting.ToString(),
                            player.Skills.Heading.ToString(),
                            player.Skills.Tackling.ToString(),
                            player.Skills.Control.ToString(),
                            player.Skills.Speed.ToString(),
                            player.Skills.Finishing.ToString()
                        }
                    );
            }

            ShowingPlayersCountLabel.Text = string.Format("Showing {0} players", foundPlayers.Count);
        }

        public void UpdateLoadedPlayerCount(int count)
        {
            PlayersLoadedCountLabel.Text = string.Format("{0} players loaded", count);
        }

        public void SetLatestFolder(string folder)
        {
            DataFolderTextBox.Text = folder;
        }

        private string GetPositionCode(Position position)
        {
            switch (position)
            {
                case Position.Goalkeeper:
                    return "G";
                case Position.RightBack:
                    return "RB";
                case Position.LeftBack:
                    return "LB";
                case Position.Defender:
                    return "D";
                case Position.RightWing:
                    return "RW";
                case Position.LeftWing:
                    return "LW";
                case Position.Midfielder:
                    return "M";
                case Position.Attacker:
                    return "A";
                default:
                    return string.Empty;
            }
        }

        private void UpdateListButton_Click(object sender, EventArgs e)
        {
            var criteria = new Criteria
                {
                    PassingFrom = Convert.ToInt32(PassingFromComboBox.SelectedItem),
                    PassingTo = Convert.ToInt32(PassingToComboBox.SelectedItem),
                    ShootingFrom = Convert.ToInt32(ShootingFromComboBox.SelectedItem),
                    ShootingTo = Convert.ToInt32(ShootingToComboBox.SelectedItem),
                    HeadingFrom = Convert.ToInt32(HeadingFromComboBox.SelectedItem),
                    HeadingTo = Convert.ToInt32(HeadingToComboBox.SelectedItem),
                    TacklingFrom = Convert.ToInt32(TacklingFromComboBox.SelectedItem),
                    TacklingTo = Convert.ToInt32(TacklingToComboBox.SelectedItem),
                    ControlFrom = Convert.ToInt32(ControlFromComboBox.SelectedItem),
                    ControlTo = Convert.ToInt32(ControlToComboBox.SelectedItem),
                    SpeedFrom = Convert.ToInt32(SpeedFromComboBox.SelectedItem),
                    SpeedTo = Convert.ToInt32(SpeedToComboBox.SelectedItem),
                    FinishingFrom = Convert.ToInt32(FinishingFromComboBox.SelectedItem),
                    FinishingTo = Convert.ToInt32(FinishingToComboBox.SelectedItem),
                    ValueFrom = Convert.ToInt32(ValueFromComboBox.SelectedItem),
                    ValueTo = Convert.ToInt32(ValueToComboBox.SelectedItem)
                };

            criteria.Positions = GetSelectedPositions();

            _presenter.PerformSearch(criteria);
        }

        private List<Position> GetSelectedPositions()
        {
            var positions = new List<Position>();

            if (PositionComboBox.SelectedItem.ToString().Contains("G"))
            {
                positions.Add(Position.Goalkeeper);
            }

            if (PositionComboBox.SelectedItem.ToString().Contains("D"))
            {
                positions.Add(Position.Defender);
            }

            if (PositionComboBox.SelectedItem.ToString().Contains("LB"))
            {
                positions.Add(Position.LeftBack);
            }

            if (PositionComboBox.SelectedItem.ToString().Contains("RB"))
            {
                positions.Add(Position.RightBack);
            }

            if (PositionComboBox.SelectedItem.ToString().Contains("LW"))
            {
                positions.Add(Position.LeftWing);
            }

            if (PositionComboBox.SelectedItem.ToString().Contains("M"))
            {
                positions.Add(Position.Midfielder);
            }

            if (PositionComboBox.SelectedItem.ToString().Contains("RW"))
            {
                positions.Add(Position.RightWing);
            }

            if (PositionComboBox.SelectedItem.ToString().Contains("A"))
            {
                positions.Add(Position.Attacker);
            }

            if (PositionComboBox.SelectedIndex == 0)
            {
                positions.Add(Position.Attacker);
                positions.Add(Position.Defender);
                positions.Add(Position.Goalkeeper);
                positions.Add(Position.LeftBack);
                positions.Add(Position.LeftWing);
                positions.Add(Position.Midfielder);
                positions.Add(Position.RightBack);
                positions.Add(Position.RightWing);
            }

            return positions;
        }

        private void BrowseDataButton_Click(object sender, EventArgs e)
        {
            var browserDialog = new FolderBrowserDialog();
            DialogResult result = browserDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                DataFolderTextBox.Text = browserDialog.SelectedPath;
            }
        }


    }
}
