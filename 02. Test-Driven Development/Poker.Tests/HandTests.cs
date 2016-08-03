﻿namespace Poker.Tests
{
    using System;
    using System.Collections.Generic;

    using NUnit.Framework;

    [TestFixture]
    public class HandTests
    {
        private Hand testHand = new Hand(new List<ICard>
                                         {
                                             new Card(CardFace.Ace, CardSuit.Clubs),
                                             new Card(CardFace.Ten, CardSuit.Spades),
                                             new Card(CardFace.Jack, CardSuit.Hearts),
                                             new Card(CardFace.Eight, CardSuit.Clubs),
                                             new Card(CardFace.Eight, CardSuit.Diamonds)
                                         });

        [Test]
        public void Hand_ToString_ShouldReturnCorrectCardCounter()
        {
            Assert.AreEqual(5, this.testHand.Cards.Count);
        }

        [Test]
        public void Hand_ToString_ShouldReturnCardsSeparatedByCommaAndSpace()
        {
            Assert.AreEqual("A♣, 10♠, J♥, 8♣, 8♦", this.testHand.ToString());
        }
    }
}
