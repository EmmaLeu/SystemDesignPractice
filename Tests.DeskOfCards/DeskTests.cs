using DeckOfCards;
using NUnit.Framework;

namespace Tests.DeskOfCards
{
    public class Tests
    {
        [Test]
        public void DeckProperlyInitialized()
        {
            var deck = new Deck();

            for(var index = 0; index < 13; index++)
            {
                Assert.True(deck.Cards[index].Number == index + 1 && deck.Cards[index].Suit == Suit.Clubs);
            }
            for (var index = 13; index < 26; index++)
            {
                Assert.True(deck.Cards[index].Number == index - 12 && deck.Cards[index].Suit == Suit.Diamonds);
            }
            for (var index = 26; index < 39; index++)
            {
                Assert.True(deck.Cards[index].Number == index - 25 && deck.Cards[index].Suit == Suit.Hearts);
            }
            for (var index = 39; index < 52; index++)
            {
                Assert.True(deck.Cards[index].Number == index - 38 && deck.Cards[index].Suit == Suit.Spades);
            }
        }
    }
}