
/*
 * Created by: Alexandrea Udechukwu
 * Created on: 25-September-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #11 - Name of Program
 * This program calculates the cost of a pizza by inputing the diameter of the pizza in a textbox and clicking on
 * the calculate button which the displays the cost before tax is added and after tax is added.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaCostAlex
{
    public partial class frmPizzaCost : Form
    {
        public frmPizzaCost()
        {
            InitializeComponent();
        }

        private void PizzaCostForm_Load(object sender, EventArgs e)
        {

        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            double diameter, costBeforeTax, costAftertax;
            //convert diameter to a double
            diameter = double.Parse(txtDiameter.Text);

            //calculate cost before and after tax
            costBeforeTax = (0.75 + 0.90 + 0.5) * diameter;
            costAftertax = costBeforeTax * 1.13;

            //display answer in label, rounded to 2 decimal places
            lblCostBeforeTax.Text = String.Format("${0:0.00}", costBeforeTax);
            lblAnswer.Text = String.Format("${0:0.00}", costAftertax);
        }

        private void LblCostTax_Click(object sender, EventArgs e)
        {

        }
    }
}
