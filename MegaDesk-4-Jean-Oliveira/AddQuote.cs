using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_4_Jean_Oliveira
{
    public partial class AddQuote : Form
    {
        #region Declarations
        // Declare constants...member variables
        static int width = 0;
        static int depth = 0;
        static int drawers = 0; //member of desk drawers
        static int surfaceArea = 0;
        static int rushDays = 0;
        const int MINWIDTH = 60;
        const int MAXWIDTH = 120;
        const int MINDEPTH = 40;
        const int MAXDEPTH = 60;
        # endregion

        
        private string desktopMaterial;

        public AddQuote()
        {
            InitializeComponent();

            List<Desk.DesktopMaterial> materials = new List<Desk.DesktopMaterial>()
            {
                Desk.DesktopMaterial.Laminate,
                Desk.DesktopMaterial.Oak,
                Desk.DesktopMaterial.Pine,
                Desk.DesktopMaterial.Rosewood,
                Desk.DesktopMaterial.Veneer
            };

            desktopMaterialComboBox.DataSource = materials;
            
        }

        //private void AddQuoteLabel_Click(object sender, EventArgs e)
        //{

        //}

        //private void WidthInputLabel_Click(object sender, EventArgs e)
        //{

        //}

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void widthTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void widthTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (int.TryParse(widthTextBox.Text, out int width))
            {
                if (width < MINWIDTH || width > MAXWIDTH)
                {
                    MessageBox.Show("Please enter a width from " + MINWIDTH + " to " + MAXWIDTH + "inches.");
                    widthTextBox.Text = "";
                    widthTextBox.BackColor = Color.OrangeRed;
                    widthTextBox.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid width measurement as a whole number.");
                widthTextBox.Text = "";
                widthTextBox.BackColor = Color.OrangeRed;
                widthTextBox.Focus();

            }

        }

        //private void DepthInputLabel_Click(object sender, EventArgs e)
        //{

        //}

        private void DepthTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void depthTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void depthTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (int.TryParse(depthTextBox.Text, out int depth))
            {
                if (depth < MINDEPTH || depth > MAXDEPTH)
                {
                    MessageBox.Show("Please enter a depth from " + MINDEPTH + " to " + MAXDEPTH + " inches.");
                    depthTextBox.Text = "";
                    depthTextBox.BackColor = Color.OrangeRed;
                    depthTextBox.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid depth measurement as a whole number.");
                depthTextBox.Text = "";
                depthTextBox.BackColor = Color.OrangeRed;
                depthTextBox.Focus();

            }

        }
        //private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}

        

        private void MaterialsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NoneRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ThreeRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FiveRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SevenRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SubmitOrderButton_Click(object sender, EventArgs e)
        {
            DisplayQuote newDisplayQuote = new DisplayQuote();
            newDisplayQuote.Show();
            this.Hide();

            //Input
            try
            {
                width = int.Parse(widthTextBox.Text);
                depth = int.Parse(depthTextBox.Text);

                if (width < MINWIDTH || width > MAXWIDTH)
                {
                    MessageBox.Show("Please a width from 24 to 96 inches.");
                    return;
                }

                if (depth < MINDEPTH || depth > MAXDEPTH)
                {
                    MessageBox.Show("Please enter a depth from 12 to 56 inches");
                    depthTextBox.Text = "";
                    depthTextBox.BackColor = Color.LightSalmon;
                    depthTextBox.Focus();
                    return;
                }

                //get the number of drawers from the drawer combobox
                drawers = int.Parse(DrawersCombobox.SelectedItem.ToString());
                
                //get the material type from the material combobox
                desktopMaterial = (desktopMaterialComboBox.SelectedItem.ToString());
               
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Check Input");
            }

            // Create new desk object
            Desk newDesk = new Desk()
            {
                width = width,
                depth = depth,
                numDrawers = drawers,
                desktopMaterial = desktopMaterial


            };

            // get rush order selection
            if (threeRadioButton.Checked)
            {
                rushDays = 3;
            }
            if (fiveRadioButton.Checked)
            {
                rushDays = 5;
            }
            if (sevenRadioButton.Checked)
            {
                rushDays = 7;
            }

            //Create new deskOrder object

            DeskOrder newOrder = new DeskOrder(newDesk.width, newDesk.depth, newDesk.numDrawers, newDesk.desktopMaterial,
                rushDays);

            ////calculate quote total, add it to the DeskOrder with the order Date

            newOrder.deskQuote = newOrder.BASEPRICE + newOrder.surfaceCost() + newOrder.drawerCost() +
                newOrder.SurfaceMaterialCost() + newOrder.RushOrderCost();
                    newOrder.quoteDate = DateTime.Now;

            try
            {

                //build output string csv
                var dorecord = newOrder.quoteDate + ", " + newDesk.width + ", " + newDesk.depth + ", " + newDesk.numDrawers
                    + ", " + newDesk.desktopMaterial + ", " + rushDays + ", " + newOrder.deskQuote;

                //build output JSON
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(dorecord);

                //Store newOrder into a List object -make deskOrders available to search
                List<DeskOrder> deskOrders = new List<DeskOrder>();
                    deskOrders.Add(newOrder);

                //Store deskOrder into file

                string cFile = @"quotes.txt";
                if (!File.Exists(cFile))
                {
                    using (StreamWriter sw = File.CreateText("deskorders.txt"))
                    {
                        sw.WriteLine("MegaDesk - Desk Orders");
                        sw.WriteLine("*************************");
                    }
                }
                using (StreamWriter sw = File.AppendText("deskorders.txt"))
                {
                    sw.WriteLine(dorecord);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Check desk Order Output Methods");
            }

            //Show order details
            DeskOrderView newOrderView = new DeskOrderView(newOrder.quoteDate, newDesk.width, newDesk.depth,
                newDesk.numDrawers, newDesk.desktopMaterial.ToString(), rushDays, newOrder.deskQuote);
            newOrderView.Show();
            this.Close();


        }



        ////private void DrawersSelectLabel_Click(object sender, EventArgs e)
        ////{

            ////}

            ////private void MaterialsSelectLabel_Click(object sender, EventArgs e)
            ////{

            ////}

            ////private void RushOrderLabel_Click(object sender, EventArgs e)
            ////{

            ////}

        }
}
