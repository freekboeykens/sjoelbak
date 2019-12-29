using System;
using System.Collections.Generic;
using System.Text;

namespace Cut_Throat_Cricket_Sjoelbak_Deathmatch_Scoreboard
{
    public class Player
    {
        public Guid Id { get; } = Guid.NewGuid();

        public string Name { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is Player other)
            {
                return Id == other.Id;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}
