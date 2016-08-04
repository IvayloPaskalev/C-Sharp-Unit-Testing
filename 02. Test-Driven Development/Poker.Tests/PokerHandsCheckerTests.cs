namespace Poker.Tests
{
    using System;
    using System.Collections.Generic;

    using NUnit.Framework;
    using System.Collections;
    using Telerik.JustMock;

    [TestFixture]
    public class PokerHandsCheckerTests
    {
        [Test]
        public void PokerHandsCheker_IsValidHand_ShouldReturnFalseWhenHandIsEmpty()
        {
            var collection = new List<ICard>();

            var mockedHand = Mock.Create<IHand>();
            Mock.Arrange(() => mockedHand.Cards).Returns(collection);

            var cheker = new PokerHandsChecker();

            Assert.IsFalse(cheker.IsValidHand(mockedHand));
        }

        [Test]
        [TestCase(2)]
        [TestCase(4)]
        [TestCase(6)]
        [TestCase(15)]
        public void PokerHandsCheker_IsValidHand_ShouldReturnFalseWhenHandContainsLessOrMoreThanFIveCards(int numberOfCards)
        {
            var collection = new List<ICard>();

            for (int i = 0; i < numberOfCards; i++)
            {
                var mockedCard = Mock.Create<ICard>();
                collection.Add(mockedCard);
            }

            var hand = Mock.Create<IHand>();
            Mock.Arrange(() => hand.Cards).Returns(collection);

            var cheker = new PokerHandsChecker();

            Assert.IsFalse(cheker.IsValidHand(hand));
        }

        [Test]
        public void PokerHandsCheker_IsValidHand_ShouldReturnFalseIfCardsAreEqual()
        {
            var collection = new List<ICard>();

            var mockedCard = Mock.Create<ICard>();
            Mock.Arrange(() => mockedCard.Suit).Returns(CardSuit.Spades);
            Mock.Arrange(() => mockedCard.Face).Returns(CardFace.Ace);

            for (int i = 0; i < 5; i++)
            {
                collection.Add(mockedCard);
            }

            var mockedHand = Mock.Create<IHand>();
            Mock.Arrange(() => mockedHand.Cards).Returns(collection);

            var cheker = new PokerHandsChecker();

            Assert.IsFalse(cheker.IsValidHand(mockedHand));
        }

        [Test]
        public void PokerHandsCheker_IsFlush_ShouldReturnTrueWhenAllCardsInHandIsFromSameSuit()
        {
            var collection = new List<ICard>();

            for (int i = 0; i < 5; i++)
            {
                CardFace face = (CardFace)i;
                var mockedCard = Mock.Create<ICard>();
                Mock.Arrange(() => mockedCard.Suit).Returns(CardSuit.Spades);
                Mock.Arrange(() => mockedCard.Face).Returns(face);
                collection.Add(mockedCard);
            }

            var mockedHand = Mock.Create<IHand>();
            Mock.Arrange(() => mockedHand.Cards).Returns(collection);

            var cheker = new PokerHandsChecker();

            Assert.IsTrue(cheker.IsFlush(mockedHand));

        }
    }
}
