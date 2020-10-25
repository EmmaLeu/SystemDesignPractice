namespace DeckOfCards
{
    public class Card
    {
        public Card(int number, Suit suit)
        {
            Number = number;
            Suit = suit;
        }

        public int Number { get; }

        public Suit Suit { get; }
    }
}
