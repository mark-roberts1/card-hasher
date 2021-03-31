using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardHasher
{
    public class Deck
    {
        private List<Card> cards;
        public IReadOnlyList<Card> Cards => cards;

        public Deck()
        {
            cards = CardHelper.GetCards().Shuffle().ToList();
        }

        public void Shuffle()
        {
            cards = cards.Shuffle().ToList();
        }

        public byte[] GenerateHash()
        {
            var bytes = new byte[39];

            var bits = cards.SelectMany(s => s.Bits).ToArray();

            for (int i = 0; i < 39; i++)
            {
                int start = i * 8;

                bytes[i] =
                    (byte)((byte)((bits[start + 0] ? 1 : 0) * 128) |
                    (byte)((bits[start + 1] ? 1 : 0) * 64) |
                    (byte)((bits[start + 2] ? 1 : 0) * 32) |
                    (byte)((bits[start + 3] ? 1 : 0) * 16) |
                    (byte)((bits[start + 4] ? 1 : 0) * 8) |
                    (byte)((bits[start + 5] ? 1 : 0) * 4) |
                    (byte)((bits[start + 6] ? 1 : 0) * 2) |
                    (byte)((bits[start + 7] ? 1 : 0) * 1));
            }

            return bytes;
        }
    }

    public class CardHelper
    {
        public static Card[] GetCards() => _cards;

        private static readonly Card[] _cards;

        static CardHelper()
        {
            var cards = new List<Card>();

            for (byte i = 0; i < 13; i++)
            {
                for (byte j = 0; j < 4; j++)
                {
                    cards.Add(new Card(i, j));
                }
            }

            _cards = cards.ToArray();
        }
    }
}
