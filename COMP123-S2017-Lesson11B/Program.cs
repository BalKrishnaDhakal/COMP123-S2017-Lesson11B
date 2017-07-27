﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Name: Bal Krishna Dhakal
 * Date: July 25, 2017
 * Description: This is demo for Lesson 11
 * Version: 0.3 - test the shuffle method of the Deck Class
 */
namespace COMP123_S2017_Lesson11B
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            Hand hand = new Hand();
            Console.WriteLine("Original Deck  Number of cards: " + deck.Count);
            Console.WriteLine("===================================================");
            Console.WriteLine(deck.ToString());
            Console.WriteLine();
            deck.Shuffle();
            Console.WriteLine("Shuffled Deck Number of Cards: " + deck.Count);
            Console.WriteLine("====================================================");
            Console.WriteLine(deck.ToString());
            hand.Add(deck.Deal1());
            Console.WriteLine(hand.ToString());
            Console.WriteLine();

        }
    }
}
