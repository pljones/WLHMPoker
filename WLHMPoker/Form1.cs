using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WLHMPoker
{
    public partial class Form1 : Form
    {
        IEnumerable<Deck.Card> deck = Deck.Cards.Shuffle();
        Label[] lbCards;

        public Form1()
        {
            InitializeComponent();
            lbCards = new Label[] { lbCard1, lbCard2, lbCard3, lbCard4, lbCard5, };
            deck = new Deck.Card[] {
                new Deck.Card(Deck.Suit.Clubs, 2),
                new Deck.Card(Deck.Suit.Clubs, 3),
                new Deck.Card(Deck.Suit.Clubs, 5),
                new Deck.Card(Deck.Suit.Clubs, 6),
                new Deck.Card(Deck.Suit.Clubs, 9),

                new Deck.Card(Deck.Suit.Hearts, 2),
                new Deck.Card(Deck.Suit.Clubs, 3),
                new Deck.Card(Deck.Suit.Clubs, 4),
                new Deck.Card(Deck.Suit.Clubs, 5),
                new Deck.Card(Deck.Suit.Clubs, 6),

                new Deck.Card(Deck.Suit.Spades, 2),
                new Deck.Card(Deck.Suit.Spades, 3),
                new Deck.Card(Deck.Suit.Spades, 4),
                new Deck.Card(Deck.Suit.Spades, 5),
                new Deck.Card(Deck.Suit.Spades, 6),

                new Deck.Card(Deck.Suit.Spades, 2),
                new Deck.Card(Deck.Suit.Spades, 3),
                new Deck.Card(Deck.Suit.Spades, 14),
                new Deck.Card(Deck.Suit.Spades, 4),
                new Deck.Card(Deck.Suit.Spades, 5),

                new Deck.Card(Deck.Suit.Hearts, 2),
                new Deck.Card(Deck.Suit.Clubs, 2),
                new Deck.Card(Deck.Suit.Diamonds, 2),
                new Deck.Card(Deck.Suit.Spades, 2),
                new Deck.Card(Deck.Suit.Spades, 6),

                new Deck.Card(Deck.Suit.Hearts, 2),
                new Deck.Card(Deck.Suit.Clubs, 2),
                new Deck.Card(Deck.Suit.Diamonds, 2),
                new Deck.Card(Deck.Suit.Diamonds, 5),
                new Deck.Card(Deck.Suit.Spades, 6),

                new Deck.Card(Deck.Suit.Hearts, 2),
                new Deck.Card(Deck.Suit.Clubs, 2),
                new Deck.Card(Deck.Suit.Diamonds, 2),
                new Deck.Card(Deck.Suit.Diamonds, 6),
                new Deck.Card(Deck.Suit.Spades, 6),

                new Deck.Card(Deck.Suit.Hearts, 2),
                new Deck.Card(Deck.Suit.Clubs, 2),
                new Deck.Card(Deck.Suit.Diamonds, 7),
                new Deck.Card(Deck.Suit.Diamonds, 6),
                new Deck.Card(Deck.Suit.Spades, 6),

                new Deck.Card(Deck.Suit.Hearts, 2),
                new Deck.Card(Deck.Suit.Clubs, 2),
                new Deck.Card(Deck.Suit.Diamonds, 7),
                new Deck.Card(Deck.Suit.Diamonds, 6),
                new Deck.Card(Deck.Suit.Spades, 8),

                new Deck.Card(Deck.Suit.Hearts, 14),
                new Deck.Card(Deck.Suit.Clubs, 2),
                new Deck.Card(Deck.Suit.Diamonds, 7),
                new Deck.Card(Deck.Suit.Diamonds, 6),
                new Deck.Card(Deck.Suit.Spades, 8),
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var lb in lbCards) lb.Text = "";
            lbTrick.Text = "";
            lbHighCard.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cards = deck.Take(5);
            if (cards.Count() != 5)
            {
                button1.Enabled = false;
                Form1_Load(null, null);
                return;
            }
            deck = deck.Skip(5);

            var hand = new Hand(cards);
            int i = 0;
            foreach (var card in hand.hand)
            {
                lbCards[i++].Text = String.Format("{0} of {1}",
                    CardName(card.pipcount), card.suit.ToString());
            }

            lbTrick.Text = hand.score.trick.ToString();
            lbHighCard.Text = CardName(hand.score.highCard);
        }

        string CardName(int card)
        {
            return card < 11 ? card.ToString() : (new string[] { "Jack", "Queen", "King", "Ace", })[card - 11];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            deck = Deck.Cards.Shuffle();
            button1.Enabled = true;
        }
    }
}
