using System;
using System.Collections.Generic;
using System.Text;

namespace CardHasher
{
    public class Card
    {
        public Card(byte cardVal, byte suitVal) : this(Numeric.From(cardVal), Suit.From(suitVal)) { }

        public Card(Numeric numeric, Suit suit)
        {
            Numeric = numeric;
            Suit = suit;
        }

        public Numeric Numeric { get; }
        public Suit Suit { get; }

        public bool[] Bits
        {
            get
            {
                var bits = new bool[6];

                bits[0] = Numeric.Bits[0];
                bits[1] = Numeric.Bits[1];
                bits[2] = Numeric.Bits[2];
                bits[3] = Numeric.Bits[3];
                bits[4] = Suit.Bits[0];
                bits[5] = Suit.Bits[1];

                return bits;
            }
        }
    }
}
