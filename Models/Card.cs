using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tthk_dragndrop.Models
{
    class Card
    {
        private CardSuite cardSuite;
        private CardValue cardValue;
        private Color color;
        
        public Card(CardSuite cardSuite, CardValue cardValue)
        {
            if (cardSuite == CardSuite.Hearts || cardSuite == CardSuite.Diamonds)
            {
                color = Color.FromName("Red");
            }
            else
            {
                color = Color.FromName("Black");
            }
        }

        public string CardValueString
        {
            get
            {
                switch (cardValue)
                {
                    case CardValue.Ace:
                        return "A";
                    case CardValue.Jack:
                        return "J";
                    case CardValue.Queen: 
                        return "Q";
                    case CardValue.King:
                        return "K";
                    default:
                        return cardValue.ToString();
                }
            }
        }

        public string CardSuiteString
        {
            get
            {
                switch (cardSuite)
                {
                    case CardSuite.Clubs:
                        return "♣";
                    case CardSuite.Diamonds:
                        return "♦";
                    case CardSuite.Hearts:
                        return "♥️";
                    case CardSuite.Spades:
                        return "♠";
                    default:
                        return null;
                }
            }
        }

        public CardSuite CardSuite {
            get
            {
                return cardSuite;
            }
            set
            {
                cardSuite = value;
            }
        }

        public CardValue CardValue
        {
            get
            {
                return cardValue;
            }
            set
            {
                cardValue = value;
            }
        }
    }
}
