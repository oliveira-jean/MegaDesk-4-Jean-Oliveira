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
    public partial class DeskOrderView : Form
    {
        private DateTime quoteDate;
        private int depth;
        private int width;
        private int numDrawers;
        private int rushDays;
        private int deskQuote;
        private string desktopMaterial;
        
        public DeskOrderView()
        {
            InitializeComponent();
        }

        public DeskOrderView(DateTime quoteDate, int width, int depth, int numDrawers, string desktopMaterial, int rushDays, int deskQuote)
        {
            this.quoteDate = quoteDate;
            this.width = width;
            this.depth = depth;
            this.numDrawers = numDrawers;
            this.rushDays = rushDays;
            this.deskQuote = deskQuote;
        }

        private void QuoteDateLabel_Click(object sender, EventArgs e)
        {

        }

        private void DeskWidthLabel_Click(object sender, EventArgs e)
        {

        }

        private void DeskDepthLabel_Click(object sender, EventArgs e)
        {

        }

        private void QuoteAmountLabel_Click(object sender, EventArgs e)
        {

        }

        private void NumberOfDrawersLabel_Click(object sender, EventArgs e)
        {

        }

        private void DesktopMaterialLabel_Click(object sender, EventArgs e)
        {

        }

        private void RushOrderLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void DeskOrderView_Load(object sender, EventArgs e)
        {

        }

        private void QuoteDateOrderViewBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DepthOrderViewBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
