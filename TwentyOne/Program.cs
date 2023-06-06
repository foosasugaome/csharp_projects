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

            //TwentyOneGame game  = new TwentyOneGame();
            //game.Players = new List<string>() { "Norman", "Noah", "Julian" };
            //game.ListPlayers();
            Game game = new TwentyOneGame();
            game.Players = new List<Player>();
            Player player = new Player();
            player.Name = "Normnan";
            game = game + player; // adds player, can be written as game += player
            game = game - player; // removes player 

            // Create a deck of cards
            Deck deck =new Deck();

            // call game method
            //Game game = new Game();
            //game.Dealer = "Norman";
            //game.Name = "Twenty One";

            //  TwentyOneGame class  which inherited from Game class, TwentyOneGame class have access to Game class
            //TwentyOneGame game = new TwentyOneGame(); // Example of polymorphism.           
            game.Dealer = "Norman";
            game.Name = "Twenty One";
            //game.Players = new List<string>() { "Norman", "Noah", "Julian" };
            game.ListPlayers();
            game.Play();  // call class specific method (twentyonegame)


            //int timesShuffled = 0;
            // Shuffle the cards. Call Shuffle() method.
            //deck = Shuffle(deck,out timesShuffled, 5); 

            // call shuffle method. can accept times
            deck.Shuffle();

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
            //Console.WriteLine(deck.Cards.Count);
            //Console.WriteLine("Times shuffled :  {0}", timesShuffled);

            Console.ReadLine();
        }

        // Move this method to Deck class
        //public static Deck Shuffle(Deck deck, out int timesShuffled, int times  = 1)  //  assigning  a default value to a  second  parameter makes  it optional
        //{
        //    timesShuffled = 0;
        //    // add  a for  loop using the optional parameter
        //    for  (int i  = 0; i < times; i++)
        //    {
        //        timesShuffled++;
        //        List<Card> TempList = new List<Card>();
        //        Random rnd = new Random();

        //        while (deck.Cards.Count > 0)
        //        {
        //            int randomIndex = rnd.Next(0, deck.Cards.Count);
        //            TempList.Add(deck.Cards[randomIndex]);
        //            deck.Cards.RemoveAt(randomIndex);
        //        }
        //        deck.Cards = TempList;
        //    }
        //    return deck;
        //}

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
