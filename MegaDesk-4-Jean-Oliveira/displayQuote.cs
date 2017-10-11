using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_4_Jean_Oliveira
{
    public partial class displayQuote : Form
    {
        private int depth;
        private int width;
        private DateTime quoteDate;
        private int numDrawers;
        private string material;
        private int rushDays;
        private int deskQuote;

        //public displayQuote()
        //{
        //    InitializeComponent();
        //}

        public displayQuote(DateTime quoteDate, int width, int depth, int numDrawers, string material, int rushDays, int deskQuote)
        {

            InitializeComponent();
            displayQuoteTextBox.Text = quoteDate.ToString();
            displayDepthTextBox.Text = depth.ToString() + " inches";
            displayWidthTextBox.Text = width.ToString() + " inches";
            displayDrawersTextBox.Text = numDrawers.ToString();
            displayMaterialTextBox.Text = material;
            displayRushDaysTextBox.Text = rushDays.ToString() + " days";
            displayQuoteAmountTextBox.Text = "$ " + deskQuote.ToString();
        }

        ////private void displayQuote_Load(object sender, EventArgs e)
        ////{
            
        ////}

        //private void label8_Click(object sender, EventArgs e)
        //{

        //}

        //private void displayDepthTextBox_TextChanged(object sender, EventArgs e)
        //{
            
        //}

        //private void displayQuoteTextBox_TextChanged(object sender, EventArgs e)
        //{

        //}

        //private void displayWidthTextBox_TextChanged(object sender, EventArgs e)
        //{

        //}

        //private void displayDrawersTextBox_TextChanged(object sender, EventArgs e)
        //{

        //}

        //private void displayMaterialTextBox_TextChanged(object sender, EventArgs e)
        //{

        //}

        //private void displayRushDaysTextBox_TextChanged(object sender, EventArgs e)
        //{

        //}

        //private void displayQuoteAmountTextBox_TextChanged(object sender, EventArgs e)
        //{

        //}

        private void closeDisplayQuoteButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void displayQuoteTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void displayQuote_Load(object sender, EventArgs e)
        {

        }
    }
}
