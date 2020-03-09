namespace Cards
{
    using System;

    class Card : IComparable<Card>
    {
        public Face Face { get; private set; }
        public Suit Suit { get; private set; }

        public Card(Face face, Suit suit)
        {
            CardType = face;
            Suit = suit;
        }

        public int CompareTo(Card other)
        {
            if (other == null) return 1;
            if (Suit != other.Suit)
                return Suit.CompareTo(other.Suit);
            return CardType.CompareTo(other.Face);
        }

        public override string ToString()
        {
            return $"{Suit} : {CardType}";
        }
    }
}
