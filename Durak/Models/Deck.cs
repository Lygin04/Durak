using Durak.Enums;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Durak.Models
{
    public class Deck
    {
        private ObservableCollection<Card> _deck = new ObservableCollection<Card>();
        private static Enum[] _suitsNameList = { Suit.Clubs, Suit.Diamonds,
                                                Suit.Hearts, Suit.Spades };
        private int _indexTrumpSuit;
        private Random _rnd = new Random();
        /// <summary>
        /// Количество карт в колоде.
        /// </summary>
        public int CountCard
        {
            get
            {
                return _deck.Count;
            }
        }

        public Deck() {
            _indexTrumpSuit = _rnd.Next(0, 4);

            foreach (Enum i in _suitsNameList)
                for (int j = 6; j <= 14; j++)
                    _deck.Add(new Card((Suit)i, j, $"/Resources/{i}{j}.jpg") { IsTrumpCard = i == _suitsNameList[_indexTrumpSuit] ? true : false });
        }

        /// <summary>
        /// Получить случайную карту из колоды.
        /// </summary>
        /// <returns>Случайная карта</returns>
        public Card DrawCard()
        {
            var card = _deck[_rnd.Next(_deck.Count)];
            _deck.Remove(card);
            return card;
        }

        /// <summary>
        /// Получить изображение козырной масти.
        /// </summary>
        /// <returns>Путь к изображению козырной масти</returns>
        public string GetImageTrumpSuit()
        {
            return $"/Resources/{_suitsNameList[_indexTrumpSuit]}Sym.jpg";
        }
    }
}
