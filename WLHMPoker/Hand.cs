using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WLHMPoker
{
    public class Hand : IComparable<Hand>
    {
        public readonly List<Deck.Card> hand;
        public readonly Score score;

        public Hand(IEnumerable<Deck.Card> hand) { this.hand = hand.ToList(); score = new Score(this.hand); }

        public int CompareTo(Hand other) { return this.score.CompareTo(other.score); }

        public class Score : IComparable<Score>
        {
            public readonly Trick trick;
            public readonly int highCard;

            public Score(IEnumerable<Deck.Card> hand)
            {
                trick = getTrick(hand);
                highCard = getHighCard(hand, trick);
            }

            public int CompareTo(Score other)
            {
                int res = this.trick.CompareTo(other.trick);
                if (res != 0) return -res; // because the numbers are upside down...
                return this.highCard.CompareTo(other.highCard);
            }

            Trick getTrick(IEnumerable<Deck.Card> hand)
            {
                if (StraightFlush(hand)) return Trick.StraightFlush;
                if (FourOfAKind(hand)) return Trick.FourOfAKind;
                if (FullHouse(hand)) return Trick.FullHouse;
                if (Flush(hand)) return Trick.Flush;
                if (ThreeOfAKind(hand)) return Trick.ThreeOfAKind;
                if (TwoPair(hand)) return Trick.TwoPair;
                if (OnePair(hand)) return Trick.OnePair;
                if (Straight(hand)) return Trick.Straight; // This is checked after we've eliminated any grouping
                return Trick.HighCard;
            }

            int getHighCard(IEnumerable<Deck.Card> hand, Trick trick)
            {
                switch (trick)
                {
                        // Straights need to worry about Ace high or low
                    case Trick.StraightFlush:
                    case Trick.Straight:
                        {
                            var cards = hand.Select(x => x.pipcount).OrderByDescending(x => x).ToList();
                            return cards[0] == 14 && cards[1] == 5 ? 5 : cards[0];
                        }
                        // Remaining Five card tricks and High Card, just take the highest card in the hand
                    case Trick.FullHouse:
                    case Trick.Flush:
                    case Trick.HighCard:
                        return hand.Select(x => x.pipcount).OrderByDescending(x => x).First();
                        // N of a Kind, so take the highest card in the scoring trick
                    case Trick.FourOfAKind:
                    case Trick.ThreeOfAKind:
                    case Trick.TwoPair:
                    case Trick.OnePair:
                        return hand.PipFrequency().First().Item1;
                }
                return -1;
            }

            bool StraightFlush(IEnumerable<Deck.Card> hand) { return Flush(hand) && Straight(hand); }
            bool FourOfAKind(IEnumerable<Deck.Card> hand) { return hand.PipFrequency().First().Item2 == 4; }
            bool FullHouse(IEnumerable<Deck.Card> hand) { var freq = hand.PipFrequency(); return freq.First().Item2 == 3 && freq.Skip(1).First().Item2 == 2; }
            bool Flush(IEnumerable<Deck.Card> hand) { return hand.Select(x => x.suit).OrderBy(x => x).Distinct().Count() == 1; }
            bool Straight(IEnumerable<Deck.Card> hand)
            {
                var cards = hand.Select(x => x.pipcount).OrderByDescending(x => x).ToList();
                if (cards[0] == 14 && cards[1] == 5) // ace is high and low for straights, so try it as low
                {
                    cards[0] = 1;
                    cards = cards.OrderByDescending(x => x).ToList();
                }

                var want = cards[0] - 1;
                for (int i = 1; i < cards.Count; i++, want--)
                    if (cards[i] != want)
                        return false;
                return true;
            }
            bool ThreeOfAKind(IEnumerable<Deck.Card> hand) { return hand.PipFrequency().First().Item2 == 3; }
            bool TwoPair(IEnumerable<Deck.Card> hand) { var freq = hand.PipFrequency(); return freq.First().Item2 == 2 && freq.Skip(1).First().Item2 == 2; }
            bool OnePair(IEnumerable<Deck.Card> hand) { return hand.PipFrequency().First().Item2 == 2; }  // Don't worry about the rest, we checked already
            bool HighCard(IEnumerable<Deck.Card> hand) { return true; } // If we get here...

        }

        public enum Trick
        {
            StraightFlush,
            FourOfAKind,
            FullHouse,
            Flush,
            Straight,
            ThreeOfAKind,
            TwoPair,
            OnePair,
            HighCard,
        }
    }

    public static partial class Extensions
    {
        public static IEnumerable<Tuple<int, int>> PipFrequency(this IEnumerable<Deck.Card> value)
        {
            return value
                .Select(x => x.pipcount)
                .OrderByDescending(x => x)
                .Distinct()
                .Select(x =>
                {
                    var count = value
                        .Where(y => y.pipcount == x)
                        .Count();
                    return new { pips = x, count = count };
                })
                .OrderByDescending(x => x.count) // Hopefully this remains in pip order within count
                .Select(x => new Tuple<int, int>(x.pips, x.count));
        }
    }
}
