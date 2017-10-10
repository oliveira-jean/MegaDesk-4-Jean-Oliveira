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
using static MegaDesk_4_Jean_Oliveira.Desk;

namespace MegaDesk_4_Jean_Oliveira
{
    public partial class AddQuote : Form
    {
        #region Declarations
        // Declare constants...member variables
        int width = 0;
        int depth = 0;
        int drawers = 0; 
        //static int surfaceArea = 0;
        int rushDays = 0;
        int MINWIDTH = 60;
        int MAXWIDTH = 120;
        int MINDEPTH = 40;
        int MAXDEPTH = 60;
        string material = ""; //desktop material selection
        # endregion

        
        private string desktopMaterial;

        public AddQuote()
        {
            InitializeComponent();

            List<DesktopMaterial> materials = Enum.GetValues(typeof(DesktopMaterial)).Cast<DesktopMaterial>().ToList();

            //List<Desk.DesktopMaterial> materials = new List<Desk.DesktopMaterial>()
            //{
            //    Desk.DesktopMaterial.Laminate,
            //    Desk.DesktopMaterial.Oak,
            //    Desk.DesktopMaterial.Pine,
            //    Desk.DesktopMaterial.Rosewood,
            //    Desk.DesktopMaterial.Veneer
            //};

            desktopMaterialComboBox.DataSource = materials;
            
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        // validating for WIDTH
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
                    widthTextBox.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid width measurement as a whole number.");
                widthTextBox.Text = "";
                widthTextBox.Focus();
            }
        }
        
        // validating for DEPTH
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
                    depthTextBox.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid depth measurement as a whole number.");
                depthTextBox.Text = "";
                depthTextBox.Focus();

            }

        }
        //private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}
        
        private void MaterialsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //private void NoneRadioButton_CheckedChanged(object sender, EventArgs e)
        //{

        //}

        //private void ThreeRadioButton_CheckedChanged(object sender, EventArgs e)
        //{

        //}

        //private void FiveRadioButton_CheckedChanged(object sender, EventArgs e)
        //{

        //}

        //private void SevenRadioButton_CheckedChanged(object sender, EventArgs e)
        //{

        //}

        private void SubmitOrderButton_Click(object sender, EventArgs e)
        {

            //DeskOrderView newDeskOrderView = new DeskOrderView();
            //newDeskOrderView.Show();
            //this.Hide();

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
                    depthTextBox.Focus();
                    return;
                }

                //get the number of drawers from the drawer combobox
                drawers = int.Parse(DrawersCombobox.SelectedItem.ToString());
                
                //get the material type from the material combobox
                material = (desktopMaterialComboBox.SelectedItem.ToString());
               
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
                material = (DesktopMaterial)Enum.Parse(typeof(DesktopMaterial), material)
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

            DeskOrder newOrder = new DeskOrder(newDesk.width, newDesk.depth, newDesk.numDrawers, newDesk.material.ToString(),
                rushDays);

            ////calculate quote total, add it to the DeskOrder with the order Date

            newOrder.deskQuote = newOrder.BASEPRICE
                               + newOrder.surfaceCost()
                               + newOrder.drawerCost() 
                               + newOrder.SurfaceMaterialCost()
                               + newOrder.RushOrderCost();
            newOrder.quoteDate = DateTime.Now;

            try
            {

                //build output string csv
                var saveNewDeskOrder = newOrder.quoteDate + ", "
                                     + newDesk.width + ", "
                                     + newDesk.depth + ", "
                                     + newDesk.numDrawers + ", "
                                     + newDesk.material + ", "
                                     + rushDays + ", "
                                     + newOrder.deskQuote;

                //build output JSON
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(saveNewDeskOrder);

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
                    sw.WriteLine(saveNewDeskOrder);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Check desk Order Output Methods");
            }

            //Show order details
            DeskOrderView newDeskOrderView = new DeskOrderView(newOrder.quoteDate,
                                                           newDesk.width,
                                                           newDesk.depth,
                                                           newDesk.numDrawers,
                                                           newDesk.material.ToString(),
                                                           rushDays,
                                                           newOrder.deskQuote);
            newDeskOrderView.Show();
            this.Hide();
        }
    }
}
