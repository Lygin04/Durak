using Durak.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Durak
{
    public class GameState
    {
        private static GameState _instance;
        private static readonly object _padlock = new object();

        public Deck Deck { get; private set; }
        public List<Player> Players { get; private set; }
        public ObservableCollection<Card> Desk { get; set; }

        private GameState()
        {
            Deck = new Deck();
            Players = new List<Player>();
            Desk = new ObservableCollection<Card>();
        }

        public static GameState Instance
        {
            get
            {
                lock (_padlock)
                {
                    if (_instance == null)
                    {
                        _instance = new GameState();
                    }
                    return _instance;
                }
            }
        }
    }
}
