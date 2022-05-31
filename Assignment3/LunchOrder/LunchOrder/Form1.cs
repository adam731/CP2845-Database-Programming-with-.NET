using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LunchOrder
{
    public partial class Form1 : Form
    {
        double addedPrice = 0.0d;
        double orderTotal = 0.0d;
        double Hamburger = 6.95d;
        double pizza = 5.95d;
        double Salad = 4.95d;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            if (radioHamburger.Checked) { 
                orderTotal += Hamburger;
                if (checkIncredidents.Checked)
                {
                    addedPrice += 0.75d;
                }
                if (checkSauces.Checked)
                {
                    addedPrice += 0.75d;
                }
                if (checkFrench.Checked)
                {
                    addedPrice += 0.75d;
                }
            }
            else if (radioPizza.Checked)
            {
                orderTotal += pizza;
                if (checkIncredidents.Checked)
                {
                    addedPrice += 0.50d;
                }
                if (checkSauces.Checked)
                {
                    addedPrice += 0.50d;
                }
                if (checkFrench.Checked)
                {
                    addedPrice += 0.50d;
                }
            }
            else if (radioSalad.Checked)
            {
                orderTotal += Salad;
                if (checkIncredidents.Checked)
                {
                    addedPrice += 0.25d;
                }
                if (checkSauces.Checked)
                {
                    addedPrice += 0.25d;
                }
                if (checkFrench.Checked)
                {
                    addedPrice += 0.25d;
                }
            }

            orderTotal += addedPrice;
            double tax = (orderTotal * 7.75d) / 100;

            txtSubtotal.Text = "$" + String.Format("{0:0.00}", orderTotal);
            txtSalesTax.Text = "$" + String.Format("{0:0.00}", tax);
            txtOrderTotal.Text = "$" + String.Format("{0:0.00}", (orderTotal + tax));


        }

        private void ClearTotals()
        {
            txtOrderTotal.Text = "";
            txtSalesTax.Text = "";
            txtSubtotal.Text = "";
            orderTotal = 0.0d;
            addedPrice = 0.0d;
        }

        private void ClearAddOns()
        {
            checkIncredidents.Checked = false;
            checkFrench.Checked = false;
            checkSauces.Checked = false;
        }

        private void CboMainCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearTotals();
            ClearAddOns();
            if (radioHamburger.Checked == true)
            {
                checkIncredidents.Text = "Lettuce, tomator, and onions";
                checkSauces.Text = "Ketchup, mustard, and mayo";
                checkFrench.Text = "French fries";
            }
            else if (radioPizza.Checked == true)
            {
                checkIncredidents.Text = "Pepperoni";
                checkSauces.Text = "Sausage";
                checkFrench.Text = "Olives";
            }
            else if (radioSalad.Checked == true)
            {
                checkIncredidents.Text = "Croutons";
                checkSauces.Text = "Bacon bits";
                checkFrench.Text = "Bread sticks";
            }
        }
        private void radioHamburger_CheckedChanged(object sender, EventArgs e)
        {
            ClearTotals();
            ClearAddOns();
            checkIncredidents.Text = "Lettuce, tomator, and onions";
            checkSauces.Text = "Ketchup, mustard, and mayo";
            checkFrench.Text = "French fries";
            gbxAddons.Text = "Add-on Items ($.75/each)";


        }

        private void radioPizza_CheckedChanged(object sender, EventArgs e)
        {
            ClearTotals();
            ClearAddOns();
            checkIncredidents.Text = "Pepperoni";
            checkSauces.Text = "Sausage";
            checkFrench.Text = "Olives";
            gbxAddons.Text = "Add-on Items ($.50/each)";
        

        }

        private void radioSalad_CheckedChanged(object sender, EventArgs e)
        {
            ClearTotals();
            ClearAddOns();
            checkIncredidents.Text = "Croutons";
            checkSauces.Text = "Bacon bits";
            checkFrench.Text = "Bread sticks";
            gbxAddons.Text = "Add-on Items ($.25/each)";

        }
    }
}
