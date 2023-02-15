using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardListWinForm
{
    public class CardInfo
    {
        public string Name { get; set; }
        public string Cost { get; set; }
        public string Type { get; set; }
        public string Attributes { get; set; }
        public string Description { get; set; }
        public string FlavorText { get; set; }
        public string Power { get; set; }
        public string createNewText()
        {
            return "Name:\n\t " + Name + "\n" +
                   "Cost:\n\t " + Cost + "\n" +
                   "Power:\n\t " + Power + "\n" +
                   "Type:\n\t " + Type + "\n" +
                   "Attributes:\n\t " + Attributes + "\n" +
                   "Description:\n\t " + Description + "\n" +
                   "Flavor Text:\n\t " + FlavorText;
        }
    }
}
