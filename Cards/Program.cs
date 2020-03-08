namespace Cards
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            var cards = new Deck();
            cards.Shuffle();
            //cards.Sort();
            foreach (Card card in cards)
            {
                Console.WriteLine(card);
            }
            Console.ReadKey();
        }
    }
}