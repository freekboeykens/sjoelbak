using System;
using System.Collections.Generic;
using System.Text;

namespace Cut_Throat_Cricket_Sjoelbak_Deathmatch_Scoreboard
{
    public class Hole
    {
        public int Value { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is Hole other)
            {
                return Value == other.Value;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Value);
        }
    }
}
