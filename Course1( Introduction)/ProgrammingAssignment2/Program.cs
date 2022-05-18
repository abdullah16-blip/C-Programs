using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgrammingAssignment2
{
    /// <summary>
    /// Programming Assignment 2 solution
    /// </summary>
    class Program
    {
        /// <summary>
        /// Deals 2 cards to 3 players and displays cards for players
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            // print welcome message
            Console.WriteLine("Welcome to Nothing Like Blackjack!!");
            Console.WriteLine();

            // create and shuffle a deck
            Deck deck = new Deck();
            deck.Shuffle();

            // deal 2 cards each to 3 players (deal properly, dealing
            // the first card to each player before dealing the
            // second card to each player)
            Card card0 = deck.TakeTopCard();
            Card card1 = deck.TakeTopCard();
            Card card2 = deck.TakeTopCard();
            Card card3 = deck.TakeTopCard();
            Card card4 = deck.TakeTopCard();
            Card card5 = deck.TakeTopCard();

            // flip all the cards over
            card0.FlipOver();
            card1.FlipOver();
            card2.FlipOver();
            card3.FlipOver();
            card4.FlipOver();
            card5.FlipOver();

            // print the cards for player 1
            Console.WriteLine("Player 1 First card: " + card0.Rank + " of " + card0.Suit); 
            Console.WriteLine("Player 1 Second card: " + card3.Rank + " of " + card3.Suit); 

            // print the cards for player 2
            Console.WriteLine("Player 2 First card: " + card1.Rank + " of " + card1.Suit); 
            Console.WriteLine("Player 2 Second card: " + card4.Rank + " of " + card4.Suit); 

            // print the cards for player 3
            Console.WriteLine("Player 3 First card: " + card2.Rank + " of " + card2.Suit); 
            Console.WriteLine("Player 3 Second card: " + card5.Rank + " of " + card5.Suit); 

            Console.WriteLine();
        }
    }
}
