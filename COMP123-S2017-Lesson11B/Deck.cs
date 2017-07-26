using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/* Name: Bal Krishna Dhakal
 * Date: July 25, 2017
 * Description: This is the Deck Class
 * Version: 0.1 - Created the Deck Class
 */
namespace COMP123_S2017_Lesson11B
{
    public class Deck: List<Card>
    {
        //PRIVATE INSTANCE VARIABLES
        // PUBLIC PROPERTIES
        // CONSTRUCTORS
        /// <summary>
        /// This is the constructor
        /// </summary>
        public Deck()
        {
            this._initialize();
        }
        // PRIVATE METHODS
        /// <summary>
        /// This is the initialize method it sets values for private variables
        /// and public properties as well as other class objects.
        /// </summary>
        private void _initialize()
        {
            for (int suit = (int)Suit.Clubs; suit <= (int)Suit.Spades; suit++)
            {
                for (int face = (int)Face.Ace; face <=(int)Face.King; face++)
                {
                    this.Add(new Card((Face)face,(Suit) suit));

                }
            }
        }
        // PUBLIC METHODS
        /// <summary>
        /// This method overrides the built in ToString method.
        /// This method returns the current cards in the deck
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string outputString = "";
            foreach(Card card in this)
            {
                outputString += "The " + card.Face + " of " + card.Suit + "\n";
            }
            return outputString;

        }
    }
}