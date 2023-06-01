using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a deck of cards
            Deck deck =new Deck();

            int timesShuffled = 0;
            // Shuffle the cards. Call Shuffle() method.
            deck = Shuffle(deck,out timesShuffled, 5); 

            //  Shuffle  deck  with number of times
            //deck = Shuffle(deck, 5);
            
            //deck.Cards = new List<Card>();
            //Card cardOne = new Card();
            //cardOne.Face = "Queen";
            //cardOne.Suit = "Spades";
            //deck.Cards.Add(cardOne);            
            
            
            foreach (Card card in deck.Cards) 
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.WriteLine("Times shuffled :  {0}", timesShuffled);

            Console.ReadLine();
        }


        public static Deck Shuffle(Deck deck, out int timesShuffled, int times  = 1)  //  assigning  a default value to a  second  parameter makes  it optional
        {
            timesShuffled = 0;
            // add  a for  loop using the optional parameter
            for  (int i  = 0; i < times; i++)
            {
                timesShuffled++;
                List<Card> TempList = new List<Card>();
                Random rnd = new Random();

                while (deck.Cards.Count > 0)
                {
                    int randomIndex = rnd.Next(0, deck.Cards.Count);
                    TempList.Add(deck.Cards[randomIndex]);
                    deck.Cards.RemoveAt(randomIndex);
                }
                deck.Cards = TempList;
            }
            return deck;
        }

        //  Method Overloading  - Create multiple methods with the same name as long as they are slightly different. in this case, there are 2  arguments.
        //public  static Deck  Shuffle(Deck deck,int times)
        //{
        //    for (int i = 0;i < times; i++)
        //    {
        //        deck = Shuffle(deck);
        //    }
        //    return deck;
        //}


    }
}
