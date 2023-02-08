using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardListWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<object> originalList = new List<object>();

        private void button1_Click(object sender, EventArgs e)
        {

            List<int> searchResultIndexs = new List<int>();

            string textSearch = searchTextBox.Text;

            //Search for results in the list
            for (int i = 0; i < originalList.Count; i++)
            {
                string item = originalList[i].ToString();
                if (item.ToLower().Contains(textSearch.ToLower())) {
                    searchResultIndexs.Add(i);
                }
            }

            //Show results of search
            int searchLength = searchResultIndexs.Count;
            List<object> searchedItems = new List<object>();
            for (int i = 0; i < searchLength; i++)
            {
                searchedItems.Add(originalList[searchResultIndexs[i]]);
            }
            
            cardListBox.Items.Clear();

            for (int i = 0; i < searchLength; i++)
            {
                cardListBox.Items.Add(searchedItems[i]);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ALL TEMPORARY
            cardListBox.Items.Add("The One");
            cardListBox.Items.Add("The Second");
            cardListBox.Items.Add("That Third One");
            cardListBox.Items.Add("The Fourth");
            cardListBox.Items.Add("Those Fifths");
            cardListBox.Items.Add("That Sixth");
            cardListBox.Items.Add("Those Sevenths");
            cardListBox.Items.Add("The Eighth");
            cardListBox.Items.Add("Nine");
            cardListBox.Items.Add("Ten");

            for (int i = 0; i < cardListBox.Items.Count; i++)
            {
                originalList.Add(cardListBox.Items[i]);
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Show info of selected card on cardInfoTextBox

            //variables for Card Information Box
            string cardName = "No Name", cardCost = "No Cost", cardType = "No Type",
                   cardAttributes = "No Attributes", cardDescription = "No Description", cardFlavorText = "No Flavor Text";

            cardInfoTextBox.Clear();
            cardInfoTextBox.Text = "Name:\n\t " + cardName + "\n" +
                                   "Cost:\n\t " + cardCost + "\n" +
                                   "Type:\n\t " + cardType + "\n" +
                                   "Attributes:\n\t " + cardAttributes + "\n" +
                                   "Description:\n\t " + cardDescription + "\n" +
                                   "Flavor Text:\n\t " + cardFlavorText;
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void cardInfoTextBox_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
