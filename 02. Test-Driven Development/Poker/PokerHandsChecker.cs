using System;

namespace Poker
{
    public class PokerHandsChecker : IPokerHandsChecker
    {
        private const int ValidHandCount = 5;

        public bool IsValidHand(IHand hand)
        {
            if (hand.Cards.Count != ValidHandCount)
            {
                return false;
            }

            for (int i = 0; i < ValidHandCount - 1; i++)
            {
                for (int j = i + 1; j < ValidHandCount; j++)
                {
                    if (hand.Cards[i].Face == hand.Cards[j].Face &&
                            hand.Cards[i].Suit == hand.Cards[j].Suit)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public bool IsStraightFlush(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFourOfAKind(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFullHouse(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFlush(IHand hand)
        {
            var firstCardSuit = hand.Cards[0].Suit;

            for (int i = 1; i < hand.Cards.Count; i++)
            {
                var currentCardSuit = hand.Cards[i].Suit;
                if (firstCardSuit != currentCardSuit)
                {
                    return false;
                }
            }

            return true;
        }

        public bool IsStraight(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsThreeOfAKind(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsTwoPair(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsOnePair(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsHighCard(IHand hand)
        {
            throw new NotImplementedException();
        }

        public int CompareHands(IHand firstHand, IHand secondHand)
        {
            throw new NotImplementedException();
        }
    }
}
