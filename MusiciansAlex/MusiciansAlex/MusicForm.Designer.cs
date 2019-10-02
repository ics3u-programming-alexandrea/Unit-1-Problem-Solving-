namespace MusiciansAlex
{
    partial class MusicForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnuMusic = new System.Windows.Forms.MenuStrip();
            this.mniMusic = new System.Windows.Forms.ToolStripMenuItem();
            this.mniRap = new System.Windows.Forms.ToolStripMenuItem();
            this.mniRndB = new System.Windows.Forms.ToolStripMenuItem();
            this.mnireggae = new System.Windows.Forms.ToolStripMenuItem();
            this.funkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grbMusic = new System.Windows.Forms.GroupBox();
            this.lblMusician = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.mnuMusic.SuspendLayout();
            this.grbMusic.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMusic
            // 
            this.mnuMusic.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniMusic});
            this.mnuMusic.Location = new System.Drawing.Point(0, 0);
            this.mnuMusic.Name = "mnuMusic";
            this.mnuMusic.Size = new System.Drawing.Size(974, 24);
            this.mnuMusic.TabIndex = 0;
            this.mnuMusic.Text = "menuStrip1";
            this.mnuMusic.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MnuMusicians_ItemClicked);
            // 
            // mniMusic
            // 
            this.mniMusic.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniRap,
            this.mniRndB,
            this.mnireggae,
            this.funkToolStripMenuItem});
            this.mniMusic.Name = "mniMusic";
            this.mniMusic.Size = new System.Drawing.Size(51, 20);
            this.mniMusic.Text = "Music";
            // 
            // mniRap
            // 
            this.mniRap.Name = "mniRap";
            this.mniRap.Size = new System.Drawing.Size(180, 22);
            this.mniRap.Text = "Rap";
            this.mniRap.Click += new System.EventHandler(this.MniRap_Click);
            // 
            // mniRndB
            // 
            this.mniRndB.Name = "mniRndB";
            this.mniRndB.Size = new System.Drawing.Size(180, 22);
            this.mniRndB.Text = "R nd B";
            this.mniRndB.Click += new System.EventHandler(this.MniRndB_Click);
            // 
            // mnireggae
            // 
            this.mnireggae.Name = "mnireggae";
            this.mnireggae.Size = new System.Drawing.Size(180, 22);
            this.mnireggae.Text = "Hiphop";
            this.mnireggae.Click += new System.EventHandler(this.Mnireggae_Click);
            // 
            // funkToolStripMenuItem
            // 
            this.funkToolStripMenuItem.Name = "funkToolStripMenuItem";
            this.funkToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.funkToolStripMenuItem.Text = "Funk";
            this.funkToolStripMenuItem.Click += new System.EventHandler(this.FunkToolStripMenuItem_Click);
            // 
            // grbMusic
            // 
            this.grbMusic.Controls.Add(this.lblGenre);
            this.grbMusic.Controls.Add(this.lblMusician);
            this.grbMusic.ForeColor = System.Drawing.SystemColors.Control;
            this.grbMusic.Location = new System.Drawing.Point(294, 126);
            this.grbMusic.Name = "grbMusic";
            this.grbMusic.Size = new System.Drawing.Size(420, 251);
            this.grbMusic.TabIndex = 1;
            this.grbMusic.TabStop = false;
            this.grbMusic.Text = "Music";
            this.grbMusic.Enter += new System.EventHandler(this.GrbMusic_Enter);
            // 
            // lblMusician
            // 
            this.lblMusician.AutoSize = true;
            this.lblMusician.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMusician.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMusician.Location = new System.Drawing.Point(112, 151);
            this.lblMusician.Name = "lblMusician";
            this.lblMusician.Size = new System.Drawing.Size(213, 55);
            this.lblMusician.TabIndex = 1;
            this.lblMusician.Text = "Musician";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.ForeColor = System.Drawing.Color.White;
            this.lblGenre.Location = new System.Drawing.Point(140, 68);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(118, 39);
            this.lblGenre.TabIndex = 0;
            this.lblGenre.Text = "Genre";
            // 
            // MusicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(974, 552);
            this.Controls.Add(this.grbMusic);
            this.Controls.Add(this.mnuMusic);
            this.MainMenuStrip = this.mnuMusic;
            this.Name = "MusicForm";
            this.Text = "Form1";
            this.mnuMusic.ResumeLayout(false);
            this.mnuMusic.PerformLayout();
            this.grbMusic.ResumeLayout(false);
            this.grbMusic.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMusic;
        private System.Windows.Forms.ToolStripMenuItem mniMusic;
        private System.Windows.Forms.ToolStripMenuItem mniRap;
        private System.Windows.Forms.ToolStripMenuItem mniRndB;
        private System.Windows.Forms.ToolStripMenuItem mnireggae;
        private System.Windows.Forms.ToolStripMenuItem funkToolStripMenuItem;
        private System.Windows.Forms.GroupBox grbMusic;
        private System.Windows.Forms.Label lblMusician;
        private System.Windows.Forms.Label lblGenre;
    }
}

