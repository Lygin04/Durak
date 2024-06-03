using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Durak.Models
{
    public class Player
    {
        public ObservableCollection<Card> Hand { get; set; }

        public Player()
        {
            Hand = new ObservableCollection<Card>();
        }
    }
}
