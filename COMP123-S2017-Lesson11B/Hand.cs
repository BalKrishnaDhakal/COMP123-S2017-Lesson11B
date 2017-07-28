using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/* Name: Bal Krishna Dhakal
 * Date: July 27, 2017
 * Description: This is the Hand Class
 * Version: 0.2 -HighestCardsInHand Created
 */
namespace COMP123_S2017_Lesson11B
{
    public class Hand : CardList
    {
        // PRIVATE INSTANCE VARIABLES
        // PUBLIC PROPERTIES
         // CONSTRUCTORS
           // PRIVATE METHODS
           // PUBLIC METHOD

        protected override void _initialize()
        {
           //This Method is empty
        }
       
        public override string ToString()
        {
            string outputString = "";
            outputString += " Number of Cards in Hand :" + this.Count + "\n";
            outputString += "==========================================\n";
            foreach(Card card in this)
            {
                outputString += "The " + card.Face + "of " + card.Suit + "\n";
            }
            return outputString;
        }
        /// <summary>
        /// This method 
        /// </summary>
        /// <param name="hands"></param>
        public void HighestCardsInHand(Hand hands)
        {
            var sortedResult = from myCard in hands orderby myCard.Face descending select myCard;
            int maxFaceCard = 0;
            int i = 0;
            foreach (Card item in sortedResult)
            {
                if (i == 0)
                {
                    maxFaceCard = (int)item.Face;
                }
                else
                {
                    if ((int)item.Face < maxFaceCard) break;

                }
                Console.WriteLine("The Highest  Card in Hand is: " + item.Face + " of " + item.Suit);
                i++;
            }
        }

    }
  }
    
