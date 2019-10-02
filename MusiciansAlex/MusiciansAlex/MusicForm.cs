/*
 * Created by: Alexandre Udechukwu
 * Created on: 13-September-2019
 * Created for: ICS3U Programming
 * Assignment #2 - Name of Program
 * This program shows my favouririte genre of music ans musicians when the corrresponding menu item is clicked.
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

namespace MusiciansAlex
{
    public partial class MusicForm : Form
    {
        public MusicForm()
        {
            InitializeComponent();
        }

        private void MnuMusicians_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Mnireggae_Click(object sender, EventArgs e)
        {
            //change the genre to Hiphop
            this.lblGenre.Text = "Hip hop";
            this.lblMusician.Text = "Nicki Minaj";
        }

        private void GrbMusic_Enter(object sender, EventArgs e)
        {

        }

        private void MniRap_Click(object sender, EventArgs e)

        { //change the genre to Rap
            this.lblGenre.Text = "Rap";
            this.lblMusician.Text = "Eminem";
            
        }

        private void MniRndB_Click(object sender, EventArgs e)
        {
            //change the genre to R nd B
            this.lblGenre.Text = "R nd B";
            this.lblMusician.Text = "Rihanna";
        }

        private void FunkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //change the genre to Funk
            this.lblGenre.Text = "Funk";
            this.lblMusician.Text = "Bruno Mars";
        }
    }
}

