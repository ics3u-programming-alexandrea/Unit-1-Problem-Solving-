/*
 * Created by: Alexandrea Udechukwu
 * Created on: 07-10-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #10 - Name of Program
 * This program calculates the circumference of a circle when
 * its radius is enter in the text box.
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

namespace CircAlex
{
    public partial class frmCirc : Form
    {
        public frmCirc()
        {
            InitializeComponent();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void LblInstructions_Click(object sender, EventArgs e)
        {

        }

        private void FrmCirc_Load(object sender, EventArgs e)
        {
        }

        private void TxtRadius_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {

            //declear local variables
            double radius, circumference;

            //convert the string from each text box to a vairable
            radius = double.Parse(txtRadius.Text);

            //calcute the circumference
            circumference = 2 * Math.PI * radius;

            //Insert the radius into its texbox
            this.lblAnswer.Text = Convert.ToString(circumference) + "meters";

        }
    }
}
