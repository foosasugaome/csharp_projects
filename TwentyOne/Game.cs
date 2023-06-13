using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace TwentyOne
{
    public abstract class Game
    {
        private List<Player> _players = new List<Player>(); //  instantiate players List
        public List<Player> Players { get { return _players;} set { _players = value; } } // List Players is instantiated with an emply list

        public string Name { get; set; }

        private Dictionary<Player, int> _bets = new Dictionary<Player, int>(); // instantiate  Bets dict
        public Dictionary<Player, int> Bets { get { return _bets; } set { _bets = value; } } // Dictionary to  keep track of  player  bets. Instatiate it also with an empty dict (_bets)

        public abstract void Play();

        public virtual void ListPlayers()
        {
            foreach (Player player in Players)
            {
                Console.WriteLine(player);
            }            
        }
    }
}
