using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/* Name: Bal Krishna Dhakal
 * Date: July 27, 2017
 * Description: This is the Deck Class
 * Version: 0.7 DealsFiveCard method is Added
 */
namespace COMP123_S2017_Lesson11B
{
    public class Deck: CardList
    {
        //PRIVATE INSTANCE VARIABLES
        private Random _random;
        // PRIVATE PROPERTIES
        private Random Random
        {
            get
            {
                return this._random;
            }
        }
        
        // PUBLIC PROPERTIES

        // CONSTRUCTORS
        /// <summary>
        /// This is the constructor
        /// </summary>
        //public Deck()
        //{
        //    this._initialize();
        //}
        //// PRIVATE METHODS
        ///// <summary>
        /// This is the initialize method it sets values for private variables
        /// and public properties as well as other class objects.
        /// </summary>
     protected override  void _initialize()
        {
            //initialize the pseudo-random number generator
            this._random = new Random();

            // This builds the deck - fills it with cards
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
            outputString = "Deck Contains Number of Cards: " + this.Count + "\n";
            outputString += "====================================================\n";
            foreach(Card card in this)
            {
                outputString += "The " + card.Face + " of " + card.Suit + "\n";
            }
            return outputString;
        }
        /// <summary>
        /// This method shuffle the deck by random indices to select two cards at a time
        /// It uses a Fisher-Yates algorithm
        /// </summary>
        public void Shuffle()
        {
            int firstCard;
            int secondCard;
            Card tempCard;

            for(int card =0; card < this.Count; card++)
            {
                firstCard = this.Random.Next(0, this.Count);
                secondCard = this.Random.Next(0, this.Count);
                tempCard = (Card)this[secondCard].Clone();
                Card.Overwrite(this[secondCard], this[firstCard]);
                Card.Overwrite(this[firstCard], tempCard);
                
            }
        }
        /// <summary>
        /// This method return the top card to the deck
        /// </summary>
        /// <returns></returns>
        public Card Deal1()
        {
            Card topCard = this[0];
            this.RemoveAt(0);// this removes the top card from the deck
            // for testing purpose only
            Console.WriteLine("Deal 1 Card - Size of Deck: " + this.Count);
            return topCard;
        }
        /// <summary>
        /// This method returns the hand cards
        /// </summary>
        /// <returns></returns>
        public Hand DealsFiveCards()
        {
            Hand handCard = new Hand();
            for (int i = 0; i < 5; i++)
            {
                handCard.Add((Card)this[0].Clone());
                this.RemoveAt(0);
            }
            Console.WriteLine(handCard.ToString());
            Console.WriteLine("====================================\n");
            Console.WriteLine(" The Deck Contains: " + this.Count + "Cards");
            return handCard;
        }
    }
}