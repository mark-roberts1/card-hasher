using System;
using System.Collections.Generic;
using System.Text;

namespace CardHasher
{
    public class Numeric
    {
        private Numeric(bool[] bits)
        {
            this.Bits[0] = bits[0];
            this.Bits[1] = bits[1];
            this.Bits[2] = bits[2];
            this.Bits[3] = bits[3];
        }

        public bool[] Bits { get; } = new bool[4];

        public byte Value
        {
            get
            {
                byte leftleft = (byte)((Bits[0] ? 1 : 0) * 8);
                byte leftmid = (byte)((Bits[1] ? 1 : 0) * 4);
                byte rightmid = (byte)((Bits[2] ? 1 : 0) * 2);
                byte rightright = (byte)((Bits[3] ? 1 : 0) * 1);

                return
                    (byte)(leftleft | leftmid | rightmid | rightright);
            }
        }

        public static Numeric From(byte b)
        {
            if (Ace.Value == b) return Ace;
            else if (Two.Value == b) return Two;
            else if (Three.Value == b) return Three;
            else if (Four.Value == b) return Four;
            else if (Five.Value == b) return Five;
            else if (Six.Value == b) return Six;
            else if (Seven.Value == b) return Seven;
            else if (Eight.Value == b) return Eight;
            else if (Nine.Value == b) return Nine;
            else if (Ten.Value == b) return Ten;
            else if (Jack.Value == b) return Jack;
            else if (Queen.Value == b) return Queen;
            else if (King.Value == b) return King;

            throw new ArgumentOutOfRangeException();
        }

        private static readonly Numeric _ace = new Numeric(new bool[] { false, false, false, false });

        public static Numeric Ace => _ace;

        private static readonly Numeric _two = new Numeric(new bool[] { false, false, false, true });

        public static Numeric Two => _two;

        private static readonly Numeric _three = new Numeric(new bool[] { false, false, true, false });

        public static Numeric Three => _three;

        private static readonly Numeric _four = new Numeric(new bool[] { false, false, true, true });

        public static Numeric Four => _four;

        private static readonly Numeric _five = new Numeric(new bool[] { false, true, false, false });

        public static Numeric Five => _five;

        private static readonly Numeric _six = new Numeric(new bool[] { false, true, false, true });

        public static Numeric Six => _six;

        private static readonly Numeric _seven = new Numeric(new bool[] { false, true, true, false });

        public static Numeric Seven => _seven;

        private static readonly Numeric _eight = new Numeric(new bool[] { false, true, true, true });

        public static Numeric Eight => _eight;

        private static readonly Numeric _nine = new Numeric(new bool[] { true, false, false, false });

        public static Numeric Nine => _nine;

        private static readonly Numeric _ten = new Numeric(new bool[] { true, false, false, true });

        public static Numeric Ten => _ten;

        private static readonly Numeric _jack = new Numeric(new bool[] { true, false, true, false });

        public static Numeric Jack => _jack;

        private static readonly Numeric _queen = new Numeric(new bool[] { true, false, true, true });

        public static Numeric Queen => _queen;

        private static readonly Numeric _king = new Numeric(new bool[] { true, true, false, false });

        public static Numeric King => _king;
    }
}
