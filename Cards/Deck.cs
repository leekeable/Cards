namespace Cards
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    class Deck : IEnumerable
    {
        public List<Card> Cards { get; }

        public Deck()
        {
            Cards = new List<Card>();

            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                foreach (Cards kind in Enum.GetValues(typeof(Cards)))
                {
                    Cards.Add(new Card(kind, suit));
                }
            }
        }

        public int Count => Cards.Count;

        public void Shuffle()
        {
            Random random = new Random();
            int n = Count;
            while (n > 1)
            {
                n--;
                var c = random.Next(n + 1);
                var randomCard = Cards[c];
                Cards[c] = Cards[n];
                Cards[n] = randomCard;
            }
        }

        public void Sort() => Cards.Sort();

        public void Sort(IComparer<Card> comparer) => Cards.Sort(comparer);

        public IEnumerator GetEnumerator()
        {
            return Cards.GetEnumerator();
        }
    }
}
