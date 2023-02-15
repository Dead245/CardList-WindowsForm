using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

        List<CardInfo> objectList= new List<CardInfo>();

        private void button1_Click(object sender, EventArgs e)
        {

            List<int> searchResultIndexs = new List<int>();

            string textSearch = searchTextBox.Text;

            //Search for results in the list
            for (int i = 0; i < objectList.Count; i++)
            {
                string item = objectList[i].Name;
                if (item.ToLower().Contains(textSearch.ToLower())) {
                    searchResultIndexs.Add(i);
                }
            }

            //Show results of search
            int searchLength = searchResultIndexs.Count;
            List<CardInfo> searchedItems = new List<CardInfo>();
            for (int i = 0; i < searchLength; i++)
            {
                searchedItems.Add(objectList[searchResultIndexs[i]]);
            }
            
            cardListBox.Items.Clear();

            for (int i = 0; i < searchLength; i++)
            {
                cardListBox.Items.Add(searchedItems[i].Name);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            objectList = CardInfoDAO.LoadCards();
            for (int i = 0; i < objectList.Count; i++)
            {
                cardListBox.Items.Add(objectList[i].Name);
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CardInfo selectedCard = new CardInfo();
            string currentItem = cardListBox.SelectedItem.ToString();
            for (int i = 0; i < objectList.Count; i++)
            {
                if (objectList[i].Name.Equals(currentItem)) {
                    selectedCard = objectList[i];
                    break;
                }
            }
            //Show info of selected card on cardInfoTextBox
            cardInfoTextBox.Clear();
            cardInfoTextBox.Text = selectedCard.createNewText();
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
