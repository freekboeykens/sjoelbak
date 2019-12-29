using System;
using System.Collections.Generic;
using System.Text;

namespace Cut_Throat_Cricket_Sjoelbak_Deathmatch_Scoreboard
{
    public class Hole
    {
        public Guid Id { get; } = Guid.NewGuid();

        public int Value { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is Hole other)
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
