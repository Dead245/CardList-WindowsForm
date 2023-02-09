using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardListWinForm
{
    internal class CardInfo
    {
        public string cardName { get; set; }
        public string cardCost { get; set; }
        public string cardType { get; set; }
        public string cardAttributes { get; set; }
        public string cardDescription { get; set; }
        public string cardFlavorText { get; set; }

        public string createNewText()
        {
            return "Name:\n\t " + cardName + "\n" +
                   "Cost:\n\t " + cardCost + "\n" +
                   "Type:\n\t " + cardType + "\n" +
                   "Attributes:\n\t " + cardAttributes + "\n" +
                   "Description:\n\t " + cardDescription + "\n" +
                   "Flavor Text:\n\t " + cardFlavorText;
        }
    }
}
