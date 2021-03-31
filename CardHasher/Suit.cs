using System;
using System.Collections.Generic;
using System.Text;

namespace CardHasher
{
    public class Suit
    {
        public Suit(bool[] bits)
        {
            Bits[0] = bits[0];
            Bits[1] = bits[1];
        }

        public bool[] Bits { get; } = new bool[2];

        public static Suit From(byte b)
        {
            if (b == 0) return Spade;
            else if (b == 1) return Club;
            else if (b == 2) return Diamond;
            else if (b == 3) return Heart;

            throw new ArgumentOutOfRangeException();
        }

        private static readonly Suit _spade = new Suit(new bool[] { false, false });
        
        public static Suit Spade => _spade;

        private static readonly Suit _club = new Suit(new bool[] { false, true });
        
        public static Suit Club => _club;
        
        private static readonly Suit _diamond = new Suit(new bool[] { true, false });
        
        public static Suit Diamond => _diamond;
        
        private static readonly Suit _heart = new Suit(new bool[] { true, true });
        
        public static Suit Heart => _heart;
    }
}
