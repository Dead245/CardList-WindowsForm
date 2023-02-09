using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardListWinForm
{
    
    internal class CardInfoDAO
    {
        //All Temporary
        CardInfo newCard = new CardInfo {
            cardName = "The First Card",
            cardCost = "3 White",
            cardType = "Card",
            cardAttributes = "Paper",
            cardDescription= "Works as a first card",
            cardFlavorText = "The Coolest Card"
        };
        CardInfo newCard2 = new CardInfo
        {
            cardName = "Dos",
            cardCost = "2 White",
            cardType = "Card",
            cardDescription = "Spanish for two?",
            cardFlavorText = "Filler space"
        };
        CardInfo newCard3 = new CardInfo
        {
            cardName = "The Other First Card",
            cardCost = "3 White",
            cardType = "Card",
            cardAttributes = "Paper",
            cardDescription = "Works as a card",
        };


        List<CardInfo> originalList = new List<CardInfo>();
        public List<CardInfo> setTempData() {
            //temp
            originalList.Add(newCard);
            originalList.Add(newCard2);
            originalList.Add(newCard3);

            return originalList;
        }
        
}
}
