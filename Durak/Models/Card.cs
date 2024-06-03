using Durak.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Durak.Models
{
    public class Card
    {
        public int ZIndex { get; private set; }
        /// <summary>
        /// Сила карты.
        /// </summary>
        public int Rank { get; private set; }
        /// <summary>
        /// Масть карты.
        /// </summary>
        public Suit Suit { get; private set; }
        /// <summary>
        /// Файл изображения карты.
        /// </summary>
        public string ImageName { get; private set; }
        /// <summary>
        /// Карта, выложенная на стол
        /// </summary>
        public bool IsOnDesk { get; set; }
        /// <summary>
        /// Карта, выложенная на стол, побита.
        /// </summary>
        public bool IsCloseOnDesk { get; set; }
        ///public bool IsHaveInHand { get; set; }      //Может быть не нужно и надо убрать в будущем

        /// <summary>
        /// Козырная масть.
        /// </summary>
        public bool IsTrumpCard { get; set; }

        public Card(Suit suit, int rank, string imageName)
        {
            Suit = suit;
            Rank = rank;
            ImageName = imageName;
        }
    }
}
