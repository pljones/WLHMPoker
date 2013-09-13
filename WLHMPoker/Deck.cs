using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WLHMPoker
{
    public class Deck
    {
        public enum Suit
        {
            Hearts,
            Clubs,
            Diamonds,
            Spades,
        }

        public struct Card
        {
            public readonly Suit suit;
            public readonly int pipcount;
            public Card(Suit suit, int pipcount) { this.suit = suit; this.pipcount = pipcount; }
        }

        public static IEnumerable<Card> Cards
        {
            get
            {
                foreach (Suit suit in Enum.GetValues(typeof(Suit)))
                {
                    for (var pipcount = 2; pipcount < 15; pipcount++)
                        yield return new Card(suit, pipcount);
                }
            }
        }
    }

    public static partial class Extensions
    {
        static Random randObj = new Random((int)(DateTime.UtcNow.ToBinary() >> 32));

        public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> value)
        {
            // We cannot use lazy evaluation of the input when shuffling!
            List<T> input = value.ToList();

            while (input.Count > 0)
            {
                int index = randObj.Next(input.Count);
                yield return input[index];
                input.RemoveAt(index);
            }
        }
    }
}
