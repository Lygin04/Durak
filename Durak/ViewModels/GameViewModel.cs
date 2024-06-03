using Durak.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Durak.ViewModels
{
    public class GameViewModel : INotifyPropertyChanged
    {
        private Deck deck;
        private ObservableCollection<Player> players;
        public ObservableCollection<Player> Players
        {
            get { return players; }
            set { players = value; OnPropertyChanged(); }
        }

        public ICommand DrawCardCommand { get; }

        public GameViewModel()
        {
            deck = new Deck();
            players = new ObservableCollection<Player>
            {
                new Player(),
                new Player()
            };

            DrawCardCommand = new RelayCommand(DrawCard);

            // Автоматическая раздача карт
            DealInitialCards();
        }

        private void DrawCard()
        {
            foreach (var player in players)
            {
                player.Hand.Add(deck.DrawCard());
            }
        }

        private void DealInitialCards()
        {
            const int initialCardCount = 6;
            for (int i = 0; i < initialCardCount; i++)
            {
                foreach (var player in players)
                {
                    player.Hand.Add(deck.DrawCard());
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public int CountCard
        {
            get { return deck.CountCard; }
        }

        public string ImageTrumpSuit
        {
            get
            {
                return deck.GetImageTrumpSuit();
            }
        }
    }
}
