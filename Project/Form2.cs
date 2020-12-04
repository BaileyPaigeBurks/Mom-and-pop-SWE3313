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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        

        public void cartContents_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        

        public void confirm_Click(object sender, EventArgs e)
        {
            double tax = 0.06; // 6% tax
            double taxAmount = 0.00; 
            double SubTotal = 0.00; 
            double total = 0.00; 

            foreach (ListViewItem item in SubTotalListView.Items)
            {
                total += Convert.ToDouble(item.SubItems[1].Text);  // price column
            }
            taxAmount = tax * total; // tax amount
            SubTotal = total + taxAmount; // total amount

            PizzaPrice.Text = "$" + total.ToString("0.00"); 
            taxPriceLabel.Text = "$" + taxAmount.ToString("0.00"); 
            TotalPrice.Text = "$" + SubTotal.ToString("0.00"); 
        }
    }
}
