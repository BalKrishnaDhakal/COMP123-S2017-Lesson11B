using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/* Name: Bal Krishna Dhakal
 * Date: July 27, 2017
 * Description: This is the Hand Class
 * Version: 0.1 -Created Hand Class
 */
namespace COMP123_S2017_Lesson11B
{
    public class Hand : CardList
    {
        // PRIVATE INSTANCE VARIABLES
        // PUBLIC PROPERTIES
         // CONSTRUCTORS
           // PRIVATE METHODS

        protected override void _initialize()
        {
           //This Method is empty
        }
        public override string ToString()
        {
            string outputString = "";
            outputString += "Hand Contains Number of Card:" + this.Count + "\n";
            outputString += "================================================";
            foreach(Card card in this)
            {
                outputString += "The" + card.Face + "of " + card.Suit + "\n";
            }
            return outputString;
        }
    }
}