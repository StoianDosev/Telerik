using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poker;
using System.Collections.Generic;

namespace TestPoker
{
    [TestClass]
    public class HandTest
    {
        [TestMethod]
        public void ToString_TestNoCards()
        {
            Hand hand = new Hand(new List<ICard>());
            string result = hand.ToString();
            Assert.AreEqual(string.Empty, result);
        }

        [TestMethod]
        public void ToString_TestOneCard()
        {
            Hand hand = new Hand(new List<ICard>(){new Card(CardFace.Ten,CardSuit.Clubs)});
            string result = hand.ToString();
            Assert.AreEqual("10♣", result);
        }

        [TestMethod]
        public void ToString_TestFiveCards()
        {
            Hand hand = new Hand(new List<ICard>() {
                new Card(CardFace.Ten, CardSuit.Clubs), 
                new Card(CardFace.Jack, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.Queen, CardSuit.Hearts),
                new Card(CardFace.Ace, CardSuit.Hearts)
            });
            string result = hand.ToString();
            Assert.AreEqual("10♣ J♦ K♠ Q♥ A♥", result);
        }

        [TestMethod]
        public void ToString_TestTwoSameCards()
        {
            Hand hand = new Hand(new List<ICard>() {
                new Card(CardFace.Ten, CardSuit.Clubs),
                new Card(CardFace.Ten, CardSuit.Clubs)
            });
            string result = hand.ToString();
            Assert.AreEqual("10♣ 10♣", result);
        }
    }
}
