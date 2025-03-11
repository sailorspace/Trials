using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trials
{
    public class Card
    {
        public static ImmutableList<string> Suits { get; } = 
            ImmutableList.Create("Clubs", "Spades", "Diamonds", "Hearts");
        public static ImmutableList<string> Ranks { get; } = 
            ImmutableList.Create("Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King");
        public string Suit { get; }
        public string Rank { get; }

        public Card(string suit, string rank)
        {
            Suit = suit;
            Rank = rank;
        }

    }

    public class Deck
        {
            private List<Card> cards;
            private Random random = new Random();

            public Deck()
            {
                cards = new List<Card>();
                //initializing 
                foreach (var suit in Card.Suits)
                {
                    foreach (var rank in Card.Ranks)
                    {
                        cards.Add(new Card(suit, rank));
                    }
                }

            }

            public IList<Card> Shuffle()
            {
                for (int i = cards.Count - 1; i > 0; i--)
                {
                    int j = random.Next(i + 1);
                    Card temp = cards[i];
                    cards[i] = cards[j];
                    cards[j] = temp;
                }
                return cards;
            }
        }
             
    }
}
