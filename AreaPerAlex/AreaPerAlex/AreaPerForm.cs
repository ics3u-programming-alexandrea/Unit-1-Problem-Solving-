/*
 * Created by: Alexandrea Udechukwu
 * Created on: 18-September-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #9 - Name of Program
 * This program calculates the area and perimeter of a rectangle whose values are inputed in a textbox when the calculate button is clicked
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

namespace AreaPerAlex
{
    public partial class frmAreaPer : Form
    {
        public frmAreaPer()
        {
            InitializeComponent();
        }

        private void FrmAreaPer_Load(object sender, EventArgs e)
        {
            //hide the perimeter and answer labels and answer until the user clicks on the calculate button
            this.lblAPerimeter.Hide();
            this.lblArea.Hide();
            this.lblPerimeter.Hide();
            this.lblAArea.Hide();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            //decleare local variables
            double length, width, area, perimeter;
            //convert the string fro each text box to a double
            length = double.Parse(txtLength.Text);
            width = double.Parse(txtWidth.Text);
            //calculate the area and the perimeter
            area = length * width;
            perimeter = 2 * length + 2 * width;
            //insert the area and the perimeter into their respective lables
            this.lblAArea.Text = Convert.ToString(area) + "squared meters";
            this.lblAPerimeter.Text = Convert.ToString(perimeter) + "meters";
            //display the perimeter and area label with their respective answers
            this.lblPerimeter.Show();
            this.lblArea.Show();
            this.lblAPerimeter.Show();
            this.lblAArea.Show();


        }
    }
}
