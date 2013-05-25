using System;
using System.Text;

namespace Poker
{
    public class Card : ICard
    {
        public CardFace Face { get; private set; }
        public CardSuit Suit { get; private set; }

        public Card(CardFace face, CardSuit suit)
        {
            this.Face = face;
            this.Suit = suit;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            switch (this.Face)
            {
                case CardFace.Two:
                    builder.Append('2');
                    break;
                case CardFace.Three:
                    builder.Append('3');
                    break;
                case CardFace.Four:
                    builder.Append('4');
                    break;
                case CardFace.Five:
                    builder.Append('5');
                    break;
                case CardFace.Six:
                    builder.Append('6');
                    break;
                case CardFace.Seven:
                    builder.Append('7');
                    break;
                case CardFace.Eight:
                    builder.Append('8');
                    break;
                case CardFace.Nine:
                    builder.Append('9');
                    break;
                case CardFace.Ten:
                    builder.Append("10");
                    break;
                case CardFace.Jack:
                    builder.Append('J');
                    break;
                case CardFace.Queen:
                    builder.Append('Q');
                    break;
                case CardFace.King:
                    builder.Append('K');
                    break;
                case CardFace.Ace:
                    builder.Append('A');
                    break;
                default:
                    break;
            }

            switch (this.Suit)
            {
                case CardSuit.Clubs:
                    builder.Append('♣');
                    break;
                case CardSuit.Diamonds:
                    builder.Append('♦');
                    break;
                case CardSuit.Hearts:
                    builder.Append('♥');
                    break;
                case CardSuit.Spades:
                    builder.Append('♠');
                    break;
                default:
                    break;
            }

            return builder.ToString();
        }
    }
}
