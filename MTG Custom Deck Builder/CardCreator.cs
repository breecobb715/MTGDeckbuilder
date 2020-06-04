using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MTG_Custom_Deck_Builder
{
    public partial class CardCreator : Form
    {
        public CardCreator()
        {
            InitializeComponent();
        }

        private void clearAll_Click(object sender, EventArgs e)
        {
            nameBox.Text = "";
            legendCheck.Checked = false;
            flavorTextBox.Text = "";
            manaText.Text = "";
            cardTypeBox.SelectedIndex = 0;
            subtypeText.Text = "";
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            manaText.Text += "0/";
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            manaText.Text += "1/";
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            manaText.Text += "2/";
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            manaText.Text += "3/";
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            manaText.Text += "4/";
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            manaText.Text += "5/";
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            manaText.Text += "6/";
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            manaText.Text += "7/";
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            manaText.Text += "8/";
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            manaText.Text += "9/";
        }

        private void tenButton_Click(object sender, EventArgs e)
        {
            manaText.Text += "10/";
        }

        private void elevenButton_Click(object sender, EventArgs e)
        {
            manaText.Text += "11/";
        }

        private void twelveButton_Click(object sender, EventArgs e)
        {
            manaText.Text += "12/";
        }

        private void xButton_Click(object sender, EventArgs e)
        {
            manaText.Text += "X/";
        }

        private void clearManaButton_Click(object sender, EventArgs e)
        {
            manaText.Text = "";
        }

        private void whiteButton_Click(object sender, EventArgs e)
        {
            manaText.Text += "WH/";
        }

        private void blueButton_Click(object sender, EventArgs e)
        {
            manaText.Text += "BU/";
        }

        private void blackButton_Click(object sender, EventArgs e)
        {
            manaText.Text += "BL/";
        }

        private void redButton_Click(object sender, EventArgs e)
        {
            manaText.Text += "R/";
        }

        private void greenButton_Click(object sender, EventArgs e)
        {
            manaText.Text += "G/";
        }

        private void wasteButton_Click(object sender, EventArgs e)
        {
            manaText.Text += "WA/";
        }

        private void wbuButton_Click(object sender, EventArgs e)
        {
            manaText.Text += "WBU/";
        }

        private void wblButton_Click(object sender, EventArgs e)
        {
            manaText.Text += "WBL/";
        }

        private void bublButton_Click(object sender, EventArgs e)
        {
            manaText.Text += "BUBL/";
        }

        private void burButton_Click(object sender, EventArgs e)
        {
            manaText.Text += "BUR/";
        }

        private void blrButton_Click(object sender, EventArgs e)
        {
            manaText.Text += "BLR/";
        }

        private void blgButton_Click(object sender, EventArgs e)
        {
            manaText.Text += "BLG/";
        }

        private void rgButton_Click(object sender, EventArgs e)
        {
            manaText.Text += "RG/";
        }

        private void rwButton_Click(object sender, EventArgs e)
        {
            manaText.Text += "RW/";
        }

        private void gwButton_Click(object sender, EventArgs e)
        {
            manaText.Text += "GW/";
        }

        private void gbuButton_Click(object sender, EventArgs e)
        {
            manaText.Text += "GBU/";
        }

        private void clearBasic_Click(object sender, EventArgs e)
        {
            nameBox.Text = "";
            cardTypeBox.SelectedIndex = 0;
            subtypeText.Text = "";
            legendCheck.Checked = false;
            flavorTextBox.Text = "";
        }

        private void CardCreator_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        public string realisticCosts(string rawMana)
        {
            string[] allMana = rawMana.Split('/');
            string fixedMana = "";
            int numSum = 0;
            foreach(string mana in allMana)
            {
                if (Char.IsDigit(mana, 0))
                {
                    numSum += int.Parse(mana);
                }
            }
            return "";
        }
        public static int CompareStrings(string s1, string s2)
        {
            //TODO
        }
    }
}
