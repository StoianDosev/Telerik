using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poker;
using System.Collections.Generic;

namespace TestPoker
{
    [TestClass]
    public class PokerHandCheckerTest
    {
        [TestMethod]
        public void IsValidHand_IsFiveDiferentCards()
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            Hand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Ten, CardSuit.Clubs), 
                new Card(CardFace.Jack, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.Queen, CardSuit.Hearts),
                new Card(CardFace.Ace, CardSuit.Hearts)
            });

            bool expected = true;
            bool actual = checker.IsValidHand(hand);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsValidHand_FiveDiferentCardsWithSameSuits()
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            Hand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Ten, CardSuit.Hearts), 
                new Card(CardFace.Jack, CardSuit.Hearts),
                new Card(CardFace.King, CardSuit.Hearts),
                new Card(CardFace.Queen, CardSuit.Hearts),
                new Card(CardFace.Ace, CardSuit.Hearts)
            });

            bool expected = true;
            bool actual = checker.IsValidHand(hand);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsValidHand_FiveSameCardsWithSameSuits()
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            Hand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Ten, CardSuit.Hearts), 
                new Card(CardFace.Ten, CardSuit.Hearts),
                new Card(CardFace.Ten, CardSuit.Hearts),
                new Card(CardFace.Ten, CardSuit.Hearts),
                new Card(CardFace.Ten, CardSuit.Hearts)
            });

            bool expected = false;
            bool actual = checker.IsValidHand(hand);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsValidHand_ZeroCards()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            Hand hand = new Hand(new List<ICard>());
            bool expected = false;
            bool actual = checker.IsValidHand(hand);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsValidHand_OneCard()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            Hand hand = new Hand(new List<ICard>() { new Card(CardFace.Ten, CardSuit.Hearts) });
            bool expected = false;
            bool actual = checker.IsValidHand(hand);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsStraightFlush_Valid()
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            Hand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.King, CardSuit.Hearts),
                new Card(CardFace.Queen, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Hearts),
                new Card(CardFace.Ten, CardSuit.Hearts)
            });

            bool expectedIsFlush = true;
            bool actual = checker.IsStraightFlush(hand);
            Assert.AreEqual(expectedIsFlush, actual);
        }

        [TestMethod]
        public void IsStraightFlush_NotValid()
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            Hand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.King, CardSuit.Hearts),
                new Card(CardFace.Queen, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Hearts),
                new Card(CardFace.Ten, CardSuit.Spades)
            });

            bool expectedIsFlush = false;
            bool actual = checker.IsStraightFlush(hand);
            Assert.AreEqual(expectedIsFlush, actual);
        }

        [TestMethod]
        public void IsFourOfAKind_Valid()
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            Hand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Hearts)
            });

            bool expectedIsFlush = true;
            bool actual = checker.IsFourOfAKind(hand);
            Assert.AreEqual(expectedIsFlush, actual);
        }

        [TestMethod]
        public void IsFourOfAKind_NotValid()
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            Hand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Eight, CardSuit.Hearts),
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Hearts)
            });

            bool expectedIsFlush = false;
            bool actual = checker.IsFourOfAKind(hand);
            Assert.AreEqual(expectedIsFlush, actual);
        }

        [TestMethod]
        public void IsFullHouse_Valid()
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            Hand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Three, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Spades),
                new Card(CardFace.Queen, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.Three, CardSuit.Spades)
            });

            bool expectedIsFlush = true;
            bool actual = checker.IsFullHouse(hand);
            Assert.AreEqual(expectedIsFlush, actual);
        }

        [TestMethod]
        public void IsFullHouse_NotValid()
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            Hand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Three, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Spades),
                new Card(CardFace.Queen, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.Ten, CardSuit.Spades)
            });

            bool expectedIsFlush = false;
            bool actual = checker.IsFullHouse(hand);
            Assert.AreEqual(expectedIsFlush, actual);
        }

        [TestMethod]
        public void IsFlush_Valid()
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            Hand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Two, CardSuit.Spades),
                new Card(CardFace.Three, CardSuit.Spades),
                new Card(CardFace.Queen, CardSuit.Spades),
                new Card(CardFace.Ten, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Spades)
            });

            bool expectedIsFlush = true;
            bool actual = checker.IsFlush(hand);
            Assert.AreEqual(expectedIsFlush, actual);
        }

        [TestMethod]
        public void IsFlush_NotValid()
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            Hand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Two, CardSuit.Spades),
                new Card(CardFace.Three, CardSuit.Spades),
                new Card(CardFace.Queen, CardSuit.Hearts),
                new Card(CardFace.Ten, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Spades)
            });

            bool expectedIsFlush = false;
            bool actual = checker.IsFlush(hand);
            Assert.AreEqual(expectedIsFlush, actual);
        }

        [TestMethod]
        public void IsStraight_Valid()
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            Hand hand = new Hand(new List<ICard>()
            {
                 new Card(CardFace.King, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Jack, CardSuit.Spades),
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.Two, CardSuit.Spades)
            });

            bool expectedIsFlush = true;
            bool actual = checker.IsStraight(hand);
            Assert.AreEqual(expectedIsFlush, actual);
        }

        [TestMethod]
        public void IsStraight_NotValid()
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            Hand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.King, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Six, CardSuit.Spades),
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.Two, CardSuit.Spades)
            });

            bool expectedIsFlush = false;
            bool actual = checker.IsStraight(hand);
            Assert.AreEqual(expectedIsFlush, actual);
        }

        [TestMethod]
        public void IsThreeOfAKind_Valid()
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            Hand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Two, CardSuit.Spades),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.King, CardSuit.Clubs),
                new Card(CardFace.King, CardSuit.Diamonds),
                new Card(CardFace.Three, CardSuit.Spades)
            });

            bool expectedIsFlush = true;
            bool actual = checker.IsThreeOfAKind(hand);
            Assert.AreEqual(expectedIsFlush, actual);
        }

        [TestMethod]
        public void IsThreeOfAKind_NotValid()
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            Hand hand = new Hand(new List<ICard>()
            {
               
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.King, CardSuit.Clubs),
                new Card(CardFace.King, CardSuit.Diamonds),
                new Card(CardFace.Three, CardSuit.Spades)
            });

            bool expectedIsFlush = false;
            bool actual = checker.IsThreeOfAKind(hand);
            Assert.AreEqual(expectedIsFlush, actual);
        }

        [TestMethod]
        public void IsTwoPair_NotValid()
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            Hand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Three, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Spades)
            });

            bool expectedIsFlush = false;
            bool actual = checker.IsTwoPair(hand);
            Assert.AreEqual(expectedIsFlush, actual);
        }

        [TestMethod]
        public void IsTwoPairs_Valid()
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            Hand hand = new Hand(new List<ICard>()
            {
               
                new Card(CardFace.Two, CardSuit.Spades),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.King, CardSuit.Clubs),
                new Card(CardFace.Three, CardSuit.Clubs),
                new Card(CardFace.Three, CardSuit.Spades)
            });

            bool expectedIsFlush = true;
            bool actual = checker.IsTwoPair(hand);
            Assert.AreEqual(expectedIsFlush, actual);
        }

        [TestMethod]
        public void IsOnePairs_Valid()
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            Hand hand = new Hand(new List<ICard>()
            {
               
                new Card(CardFace.Four, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.Three, CardSuit.Spades)
            });

            bool expectedIsFlush = true;
            bool actual = checker.IsOnePair(hand);
            Assert.AreEqual(expectedIsFlush, actual);
        }

        [TestMethod]
        public void IsOnePairs_NotValid()
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            Hand hand = new Hand(new List<ICard>()
            {
               
                new Card(CardFace.Four, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.Four, CardSuit.Spades)
            });

            bool expectedIsFlush = false;
            bool actual = checker.IsOnePair(hand);
            Assert.AreEqual(expectedIsFlush, actual);
        }

        [TestMethod]
        public void IsHighCardTestNotValidHand()
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            Hand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Three, CardSuit.Clubs),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.Two, CardSuit.Spades)
            });

            bool expectedIsHighCard = false;
            bool actual;
            actual = checker.IsHighCard(hand);
            Assert.AreEqual(expectedIsHighCard, actual);
        }

        [TestMethod]
        public void IsHighCardTestValidHand()
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            Hand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Three, CardSuit.Clubs),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.Five, CardSuit.Spades),
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.Two, CardSuit.Spades)
            });

            bool expectedIsHighCard = true;
            bool actual;
            actual = checker.IsHighCard(hand);
            Assert.AreEqual(expectedIsHighCard, actual);
        }
    }
}
