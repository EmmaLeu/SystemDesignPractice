namespace DeckOfCards
{
    public class Deck
    {
        private readonly Card[] _cards = new Card[52];

        public Deck()
        {
            InitializeCards(Suit.Clubs, 0);
            InitializeCards(Suit.Diamonds, 1);
            InitializeCards(Suit.Hearts, 2);
            InitializeCards(Suit.Spades, 3);
        }

        private void InitializeCards(Suit suit, int offset)
        {
            for (var index = 13 * offset; index < 13 * (offset + 1); index++)
            {
                _cards[index] = new Card(index - 13 * offset + 1, suit);
            }
        }

        public Card[] Cards => _cards;
    }
}
