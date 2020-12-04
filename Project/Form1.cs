using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Project
{
    public partial class Form1 : Form
    {
        public static Form2 form2 = new Form2();


        public static double Cost = 0.00; // total cost before Tax
        public static double Subtotal = 0.00; // cost after
        public static double TaxRate = 0.06; // Tax 6%

        public Form1()
        {
            InitializeComponent();
        }



                
        // add to cart button that sends user and items to form 2
        public void addToCart_Click(object sender, EventArgs e)
        {
            // If small size pizza radio button is checked
            if (smallPizza.Checked == true)
            {
                ListViewItem item = new ListViewItem("Small Pizza Size");
                item.SubItems.Add("4.00");
                form2.SubTotalListView.Items.Add(item);
            }
            // If medium size pizza radio button is checked
            else if (mediumPizza.Checked == true)
            {
                ListViewItem item = new ListViewItem("Medium Pizza Size");
                item.SubItems.Add("6.00");
                form2.SubTotalListView.Items.Add(item);
            }

            // If large size pizza radio button is checked
            else if (largePizza.Checked == true)
            {
                ListViewItem item = new ListViewItem("Large Pizza Size");
                item.SubItems.Add("8.00");
                form2.SubTotalListView.Items.Add(item);
            }

            // If extra large size pizza radio button is checked
            else if (extraLargePizza.Checked == true)
            {
                ListViewItem item = new ListViewItem("Extra Large Pizza Size");
                item.SubItems.Add("10.00");
                form2.SubTotalListView.Items.Add(item);
            }

            // If normal crust radio button is checked
            if (normalCrust.Checked == true)
            {
                ListViewItem item = new ListViewItem("Normal Crust");
                item.SubItems.Add("0.00");
                form2.SubTotalListView.Items.Add(item);
            }

            // If thin crust radio button is checked
            else if (thinCrust.Checked == true)
            {
                ListViewItem item = new ListViewItem("Thin Crust");
                item.SubItems.Add("0.00");
                form2.SubTotalListView.Items.Add(item);
            }

            // If pan crust radio button is checked
            else if (panCrust.Checked == true)
            {
                ListViewItem item = new ListViewItem("Pan Crust");
                item.SubItems.Add("0.00");
                form2.SubTotalListView.Items.Add(item);
            }

            // If marinara sauce radio button is checked
            if (marinaraSauce.Checked == true)
            {
                ListViewItem item = new ListViewItem("Marinara Sauce");
                item.SubItems.Add("0.00");
                form2.SubTotalListView.Items.Add(item);
            }

            // If garlic ranch radio button is checked
            else if (ranchSauce.Checked == true)
            {
                ListViewItem item = new ListViewItem("Garlic Ranch Sauce");
                item.SubItems.Add("0.00");
                form2.SubTotalListView.Items.Add(item);
            }

            // If no sauce radio button is checked
            else if (noSauce.Checked == true)
            {
                ListViewItem item = new ListViewItem("No Sauce");
                item.SubItems.Add("0.00");
                form2.SubTotalListView.Items.Add(item);
            }

            // If cheese topping is checked 
            if (cheese.Checked == true)
            {
                ListViewItem item = new ListViewItem("+ Cheese");
                item.SubItems.Add("0.99");
                form2.SubTotalListView.Items.Add(item);
            }

            // If pepperoni topping is checked 
            if (pepperoni.Checked == true)
            {
                ListViewItem item = new ListViewItem("+ Pepperoni");
                item.SubItems.Add("0.99");
                form2.SubTotalListView.Items.Add(item);
            }

            // If sausage topping is checked 
            if (sausage.Checked == true)
            {
                ListViewItem item = new ListViewItem("+ Sausage");
                item.SubItems.Add("0.99");
                form2.SubTotalListView.Items.Add(item);
            }

            // If ham topping is checked 
            if (ham.Checked == true)
            {
                ListViewItem item = new ListViewItem("+ Ham");
                item.SubItems.Add("0.99");
                form2.SubTotalListView.Items.Add(item);
            }

            // If green peppers topping is checked 
            if (greenPeppers.Checked == true)
            {
                ListViewItem item = new ListViewItem("+ Green Peppers");
                item.SubItems.Add("0.99");
                form2.SubTotalListView.Items.Add(item);
            }

            // If tomato topping is checked 
            if (tomato.Checked == true)
            {
                ListViewItem item = new ListViewItem("+ Tomato");
                item.SubItems.Add("0.99");
                form2.SubTotalListView.Items.Add(item);
            }

            // If onion topping is checked 
            if (onions.Checked == true)
            {
                ListViewItem item = new ListViewItem("+ Onions");
                item.SubItems.Add("0.99");
                form2.SubTotalListView.Items.Add(item);
            }

            // If mushroom topping is checked 
            if (mushroom.Checked == true)
            {
                ListViewItem item = new ListViewItem("+ Mushroom");
                item.SubItems.Add("0.99");
                form2.SubTotalListView.Items.Add(item);
            }
            
            // Pepsi drink selection
            if (numericUpDown1.Value != 0)
            {
                ListViewItem item = new ListViewItem(numericUpDown1.Value + " - Pepsi");
                item.SubItems.Add(numericUpDown1.Value + ".00");
                form2.SubTotalListView.Items.Add(item);
            }

            // Diet Pepsi drink selection
            if (numericUpDown2.Value != 0)
            {
                ListViewItem item = new ListViewItem(numericUpDown2.Value + " - Diet Pepsi");
                item.SubItems.Add(numericUpDown2.Value + ".00");
                form2.SubTotalListView.Items.Add(item);
            }

            // Crush drink selection
            if (numericUpDown3.Value != 0)
            {
                ListViewItem item = new ListViewItem(numericUpDown3.Value + " - Crush");
                item.SubItems.Add(numericUpDown3.Value + ".00");
                form2.SubTotalListView.Items.Add(item);
            }

            // Diet Crush drink selection
            if (numericUpDown4.Value != 0)
            {
                ListViewItem item = new ListViewItem(numericUpDown4.Value + " - Diet Crush");
                item.SubItems.Add(numericUpDown4.Value + ".00");
                form2.SubTotalListView.Items.Add(item);
            }

            // Root Beer drink selection
            if (numericUpDown5.Value != 0)
            {
                ListViewItem item = new ListViewItem(numericUpDown5.Value + " - Root Beer");
                item.SubItems.Add(numericUpDown5.Value + ".00");
                form2.SubTotalListView.Items.Add(item);
            }

      
            // when the button is clicked all of the above has taken action, form 1 will hide and form 2 will open
            this.Hide();
            form2.ShowDialog();
            
            
        }


       


        // empties the form to start over
        private void clearButton_Click(object sender, EventArgs e)
        {
            Form1 NewForm = new Form1();
            NewForm.Show();  // Show the new form
            this.Dispose(false); // Get rid of the old form
        }

        // all of these below give the user access to the crust type and sauce type only after they have selected a pizza size
        private void smallPizza_CheckedChanged(object sender, EventArgs e)
        {
            if (smallPizza.Checked == true)
            {
                groupBox2.Enabled = true;
            }
            else if (smallPizza.Checked == false)
            {
                groupBox2.Enabled = false;
            }
        }

        private void mediumPizza_CheckedChanged(object sender, EventArgs e)
        {
            if (mediumPizza.Checked == true)
            {
                groupBox2.Enabled = true;
            }
            else if (mediumPizza.Checked == false)
            {
                groupBox2.Enabled = false;
            }
        }

        private void largePizza_CheckedChanged(object sender, EventArgs e)
        {
            if (largePizza.Checked == true)
            {
                groupBox2.Enabled = true;
            }
            else if (largePizza.Checked == false)
            {
                groupBox2.Enabled = false;
            }
        }

        private void extraLargePizza_CheckedChanged(object sender, EventArgs e)
        {
            if (extraLargePizza.Checked == true)
            {
                groupBox2.Enabled = true;
            }
            else if (extraLargePizza.Checked == false)
            {
                groupBox2.Enabled = false;
            }
        }

        private void normalCrust_CheckedChanged(object sender, EventArgs e)
        {
            if (normalCrust.Checked == true)
            {
                groupBox3.Enabled = true;
            }
            else if (normalCrust.Checked == false)
            {
                groupBox3.Enabled = false;
            }
        }

        private void thinCrust_CheckedChanged(object sender, EventArgs e)
        {
            if (thinCrust.Checked == true)
            {
                groupBox3.Enabled = true;
            }
            else if (thinCrust.Checked == false)
            {
                groupBox3.Enabled = false;
            }
        }

        private void panCrust_CheckedChanged(object sender, EventArgs e)
        {
            if (panCrust.Checked == true)
            {
                groupBox3.Enabled = true;
            }
            else if (panCrust.Checked == false)
            {
                groupBox3.Enabled = false;
            }
        }
    }
}
