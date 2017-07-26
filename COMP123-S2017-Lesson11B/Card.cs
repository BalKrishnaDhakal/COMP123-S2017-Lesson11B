using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*/* Name: Bal Krishna Dhakal
 * Date: July 25, 2017
 * Description: This is the Card Class
 * Version: 0.1 - Created the Card Class
 */
namespace COMP123_S2017_Lesson11B
{
    public class Card
    {
        //PRIVATE INSTANCE VARIABLES
        private Face _face;
        private Suit _suit;
        //PUBLIC PROPERTIES
        public Face Face
        {
            get
            {
                return this._face;
            }

            set
            {
                this._face = value;
            }
        }
        public Suit Suit
        {
            get
            {
                return this._suit;
            }
            set
            {
                this._suit = value;
            }
        }
        // CONSTRUCTORS
        /// <summary>
        /// This is the main constructor of 
        /// </summary>
        /// <param name="face"></param>
        /// <param name="suit"></param>the Card class
        /// It takes two arguments face(Face) and suit(Suit)
        public Card(Face face, Suit suit)
        {
            this.Face = face;
            this.Suit =suit;
        }
        //PRIVATE METHODS
        // PUBLIC METHODS
    }
}