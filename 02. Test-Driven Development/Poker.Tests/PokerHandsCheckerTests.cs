namespace Poker.Tests
{
    using System;
    using System.Collections.Generic;

    using NUnit.Framework;
    using Moq;
    using System.Collections;

    [TestFixture]
    public class PokerHandsCheckerTests
    {
        [Test]
        public void PokerHandsCheker_IsValidHand_ShouldReturnExactlyFi()
        {
            var hand = new Hand(new List<ICard>
                                         {
                                             new Card(CardFace.Ace, CardSuit.Clubs),
                                             new Card(CardFace.Ten, CardSuit.Spades),
                                             new Card(CardFace.Jack, CardSuit.Hearts),
                                             new Card(CardFace.Eight, CardSuit.Clubs),
                                             new Card(CardFace.Eight, CardSuit.Diamonds)
                                         });

            var cheker = new PokerHandsChecker();

            Assert.IsTrue(cheker.IsValidHand(hand));
        }
    }
}
