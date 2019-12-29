using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cut_Throat_Cricket_Sjoelbak_Deathmatch_Scoreboard
{
    public class Scoreboard
    {
        private readonly List<Player> _players;
        private readonly List<Hole> _holes;
        private readonly int _maxNumHits;
        private Dictionary<(Player, Hole), int> _hits;
        private Dictionary<Player, int> _scores;

        public Scoreboard(
            List<Player> players,
            List<Hole> holes,
            int maxNumHits)
        {
            _players = players;
            _holes = holes;
            _maxNumHits = maxNumHits;
            _hits = new Dictionary<(Player, Hole), int>();
            _scores = new Dictionary<Player, int>();

            // initialize dictionaries
            foreach (var player in players)
            {
                _scores.Add(player, 0);

                foreach (var hole in holes)
                {
                    _hits.Add((player, hole), 0);
                }
            }
        }

        /// <summary>
        /// Adds a hit for a player and returns the updated scores
        /// </summary>
        public List<(Player, int)> AddHit(Player player, Hole hole)
        {
            _hits[(player, hole)]++;  // update # hits for this player

            if (_hits[(player, hole)] >= _maxNumHits)
            {
                UpdateScores(hole);
            }

            return _scores
                .Select(kv => (kv.Key, kv.Value))
                .OrderBy(kv => kv.Value)
                .ToList();
        }

        private void UpdateScores(Hole hole)
        {
            foreach (var player in _players)
            {
                var numHits = _hits[(player, hole)];

                if (numHits < _maxNumHits)
                {
                    _scores[player] += hole.Value;
                }
            }
        }
    }
}
