using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cut_Throat_Cricket_Sjoelbak_Deathmatch_Scoreboard
{
    public partial class Form1 : Form
    {
        private List<TextBox> _playerTextBoxes = new List<TextBox>();
        private List<TextBox> _holeTextBoxes = new List<TextBox>();
        private List<List<Button>> _hitButtons = new List<List<Button>>();
        private readonly List<Player> _players = new List<Player>();
        private readonly List<Hole> _holes = new List<Hole>();
        private readonly Scoreboard _board;
        private readonly int _maxNumHits;

        public Form1(int numPlayers, int numHoles, int maxNumHits)
        {
            _maxNumHits = maxNumHits;

            for (int i = 0; i < numPlayers; ++i)
            {
                _players.Add(new Player { Id = $"Player {i + 1}" });
            }

            for (int i = 0; i < numHoles; ++i)
            {
                _holes.Add(new Hole { Value = 20 - i });

                _board = new Scoreboard(_players, _holes, _maxNumHits);

                InitializePlayerTextBoxes();
                InitializeHoleTextBoxes();
                InitializeComponent();
            }
        }

        private void InitializePlayerTextBoxes()
        {
            var i = 0;

            foreach (var player in _players)
            {
                var textBox = new TextBox
                {
                    BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(80))))),
                    Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point),
                    ForeColor = System.Drawing.Color.Yellow,
                    Location = new System.Drawing.Point(12, 135 + i * 120),
                    Name = $"playerTextBox{i}",
                    Size = new System.Drawing.Size(300, 100),
                    TabIndex = 6,
                    Text = player.Id,
                    TextAlign = HorizontalAlignment.Center,
                    BorderStyle = BorderStyle.None
                };

                textBox.TextChanged += (sender, e) => UpdatePlayerName(sender, e, player);

                _playerTextBoxes.Add(textBox);
                Controls.Add(textBox);

                i++;
            }
        }

        private void InitializeHoleTextBoxes()
        {
            var i = 0;

            foreach (var hole in _holes)
            {
                var textBox = new TextBox
                {
                    BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(80))))),
                    Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point),
                    ForeColor = System.Drawing.Color.Yellow,
                    Location = new System.Drawing.Point(350 + i *100, 12),
                    Name = $"holeTextBox{i}",
                    Size = new System.Drawing.Size(100, 100),
                    TabIndex = 6,
                    Text = $"{hole.Value}",
                    TextAlign = HorizontalAlignment.Center,
                    BorderStyle = BorderStyle.None
                };

                textBox.TextChanged += (sender, e) => UpdateHoleValue(sender, e, hole);

                _playerTextBoxes.Add(textBox);
                Controls.Add(textBox);

                i++;
            }
        }

        private void UpdatePlayerName(object sender, EventArgs e, Player player)
        {
            if (sender is System.Windows.Forms.TextBox textBox)
            {
                player.Id = textBox.Text;
            }
        }

        private void UpdateHoleValue(object sender, EventArgs e, Hole hole)
        {
            if (sender is System.Windows.Forms.TextBox textBox)
            {
                hole.Value = int.Parse(textBox.Text);
            }
        }

        private void ButtonPlayer1Hole1_Click(object sender, EventArgs e)
        {
            UpdateText(ButtonPlayer1Hole1);
            UpdateScore(_board.AddHit(_players[0], _holes[0]));
        }

        private void ButtonPlayer1Hole2_Click(object sender, EventArgs e)
        {
            UpdateText(ButtonPlayer1Hole2);
            UpdateScore(_board.AddHit(_players[0], _holes[1]));
        }

        private void ButtonPlayer2Hole1_Click(object sender, EventArgs e)
        {
            UpdateText(ButtonPlayer2Hole1);
            UpdateScore(_board.AddHit(_players[1], _holes[0]));
        }

        private void ButtonPlayer2Hole2_Click(object sender, EventArgs e)
        {
            UpdateText(ButtonPlayer2Hole2);
            UpdateScore(_board.AddHit(_players[1], _holes[1]));
        }

        private void UpdateScore(List<(Player, int)> scores)
        {
            var text = new List<string>();
            var rank = 1;

            foreach (var score in scores)
            {
                text.Add($"{rank++}    {score.Item1.Id}\t{score.Item2}");
            }

            Scores.DataSource = text;
        }

        private void UpdateText(ButtonBase button)
        {
            if (button.Text.Length < _maxNumHits)
            {
                button.Text += "X";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
