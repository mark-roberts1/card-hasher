using System;
using System.Linq;

namespace CardHasher
{
    class Program
    {
        static void Main(string[] args)
        {
            var deck = new Deck();

            deck.Shuffle();
            var bytes = deck.GenerateHash();

            var guid1 = new Guid(bytes.Take(16).ToArray());
            var guid2 = new Guid(bytes.Skip(16).Take(16).ToArray());

            var last = bytes.Skip(32).Take(7).ToList();

            last.Add(0);

            long int64 = BitConverter.ToInt64(last.ToArray());

            Console.WriteLine("Hello World!");
        }
    }
}
