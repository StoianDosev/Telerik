using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poker;

namespace TestPoker
{
    [TestClass]
    public class CarsTest
    {
        [TestMethod]
        public void ToString_TestCardQueenOfHearts()
        {
            Card card = new Card(CardFace.Queen, CardSuit.Hearts);
            string result = card.ToString();
            Assert.AreEqual("Q♥", result);
        }

        [TestMethod]
        public void ToString_TestCardTwoOfDiamonds()
        {
            Card card = new Card(CardFace.Two, CardSuit.Diamonds);
            string result = card.ToString();
            Assert.AreEqual("2♦", result);
        }

        [TestMethod]
        public void ToString_TestCardAceOfSpades()
        {
            Card card = new Card(CardFace.Ace, CardSuit.Spades);
            string result = card.ToString();
            Assert.AreEqual("A♠", result);
        }

        [TestMethod]
        public void ToString_TestCardTenOfClubs()
        {
            Card card = new Card(CardFace.Ten, CardSuit.Clubs);
            string result = card.ToString();
            Assert.AreEqual("10♣", result);
        }
    }
}
