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
        private readonly List<Player> _players = new List<Player>();
        private readonly List<Hole> _holes = new List<Hole>();
        private readonly Scoreboard _board;
        private readonly int _maxNumHits;

        public Form1(int numPlayers, int numHoles, int maxNumHits)
        {
            _maxNumHits = maxNumHits;

            for (int i = 0; i < numPlayers; ++i)
            {
                _players.Add(new Player { Name = $"Player {i + 1}" });
            }

            for (int i = 0; i < numHoles; ++i)
            {
                _holes.Add(new Hole { Value = 20 - i });
            }

            _board = new Scoreboard(_players, _holes, _maxNumHits);

            InitializePlayerTextBoxes();
            InitializeHoleTextBoxes();
            InitializeHitButtons();
            InitializeComponent();
        }

        private void InitializePlayerTextBoxes()
        {
            for (int i = 0; i < _players.Count; ++i)
            {
                var player = _players[i];
                var textBox = new TextBox
                {
                    BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(80))))),
                    Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point),
                    ForeColor = System.Drawing.Color.Gold,
                    Location = new System.Drawing.Point(12, 135 + i * 120),
                    Size = new System.Drawing.Size(300, 100),
                    TabIndex = 6,
                    Text = player.Name,
                    TextAlign = HorizontalAlignment.Center,
                    BorderStyle = BorderStyle.None
                };

                textBox.TextChanged += (sender, e) => PlayerNameTextChanged(sender, e, player);

                Controls.Add(textBox);
            }
        }

        private void InitializeHoleTextBoxes()
        {
            for (var i = 0; i < _holes.Count; ++i)
            {
                var hole = _holes[i];
                var textBox = new TextBox
                {
                    BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(80))))),
                    Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point),
                    ForeColor = System.Drawing.Color.Gold,
                    Location = new System.Drawing.Point(350 + i * 120, 40),
                    Size = new System.Drawing.Size(100, 100),
                    TabIndex = 6,
                    Text = $"{hole.Value}",
                    TextAlign = HorizontalAlignment.Center,
                    BorderStyle = BorderStyle.None
                };

                textBox.TextChanged += (sender, e) => HoleValueTextChanged(sender, e, hole);

                Controls.Add(textBox);
            }
        }

        private void InitializeHitButtons()
        {
            for (var p = 0; p < _players.Count; ++p)
            {
                var player = _players[p];

                for (var h = 0; h < _holes.Count; ++h)
                {
                    var hole = _holes[h];
                    var button = new Button
                    {
                        BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(80))))),
                        Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point),
                        ForeColor = System.Drawing.Color.Tomato,
                        Location = new System.Drawing.Point(360 + h * 120, 145 + p * 120),
                        Size = new System.Drawing.Size(80, 40),
                        TabIndex = 2,
                        UseVisualStyleBackColor = true
                    };

                    button.Click += (sender, e) => HitButtonClick(sender, e, player, hole);
                    Controls.Add(button);
                }
            }
        }

        private void PlayerNameTextChanged(object sender, EventArgs e, Player player)
        {
            if (sender is TextBox textBox)
            {
                player.Name = textBox.Text.PadRight(16);
            }
        }

        private void HoleValueTextChanged(object sender, EventArgs e, Hole hole)
        {
            if (sender is TextBox textBox)
            {
                hole.Value = int.Parse(textBox.Text);
            }
        }

        private void HitButtonClick(object sender, EventArgs e, Player player, Hole hole)
        {
            if (sender is Button button)
            {
                if (button.Text.Length < _maxNumHits)
                {
                    button.Text += "X";
                }

                UpdateScore(_board.AddHit(player, hole));
            }
        }

        private void UpdateScore(List<(Player, int)> scores)
        {
            var indices = new List<string>();
            var names = new List<string>();
            var points = new List<string>();
            var rank = 1;

            foreach (var score in scores)
            {
                indices.Add($"{rank++}");
                names.Add(score.Item1.Name);
                points.Add($"{score.Item2}");
            }

            rankingIndices.DataSource = indices;
            rankingNames.DataSource = names;
            rankingScores.DataSource = points;
        }
    }
}
