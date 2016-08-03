namespace Poker.Tests
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class CardTests
    {
        [Test]
        [TestCase(CardFace.Two, CardSuit.Clubs, "2♣")]
        [TestCase(CardFace.Jack, CardSuit.Diamonds, "J♦")]
        [TestCase(CardFace.Queen, CardSuit.Hearts, "Q♥")]
        [TestCase(CardFace.Ace, CardSuit.Spades, "A♠")]
        public void Card_ToString_ShouldReturnCorrectCardSuitAndFace(CardFace face, CardSuit suit, string expected)
        {
            // Arrange
            var card = new Card(face, suit);

            // Act
            var result = card.ToString();

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
