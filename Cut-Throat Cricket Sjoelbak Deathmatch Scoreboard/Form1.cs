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
        private readonly int _maxNumHits = 3;

        public Form1()
        {
            _players.Add(new Player { Id = "Freek" });
            _players.Add(new Player { Id = "Stefanie" });

            _holes.Add(new Hole { Value = 20 });
            _holes.Add(new Hole { Value = 19 });

            _board = new Scoreboard(_players, _holes, _maxNumHits);

            InitializeComponent();
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
    }
}
