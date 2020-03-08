namespace Cards
{
    using System;

    class Card : IComparable<Card>
    {
        public Cards CardType { get; private set; }
        public Suit Suit { get; private set; }

        public Card(Cards type, Suit suit)
        {
            CardType = type;
            Suit = suit;
        }

        public int CompareTo(Card other)
        {
            if (other == null) return 1;
            if (Suit != other.Suit)
                return Suit.CompareTo(other.Suit);
            return CardType.CompareTo(other.CardType);
        }

        public override string ToString()
        {
            return $"{Suit} : {CardType}";
        }
    }
}
