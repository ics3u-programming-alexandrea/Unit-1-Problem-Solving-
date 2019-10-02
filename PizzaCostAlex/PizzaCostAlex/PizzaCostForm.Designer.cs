namespace PizzaCostAlex
{
    partial class frmPizzaCost
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
            this.lblDiameter = new System.Windows.Forms.Label();
            this.txtDiameter = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblCostTax = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.lblCostBeforeTax = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDiameter
            // 
            this.lblDiameter.AutoSize = true;
            this.lblDiameter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiameter.Location = new System.Drawing.Point(21, 74);
            this.lblDiameter.Name = "lblDiameter";
            this.lblDiameter.Size = new System.Drawing.Size(405, 25);
            this.lblDiameter.TabIndex = 0;
            this.lblDiameter.Text = "Enter the diameter of the pizza(in inches)";
            // 
            // txtDiameter
            // 
            this.txtDiameter.Location = new System.Drawing.Point(589, 79);
            this.txtDiameter.Name = "txtDiameter";
            this.txtDiameter.Size = new System.Drawing.Size(100, 20);
            this.txtDiameter.TabIndex = 1;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(140, 178);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(181, 32);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate Cost";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // lblCostTax
            // 
            this.lblCostTax.AutoSize = true;
            this.lblCostTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostTax.Location = new System.Drawing.Point(21, 377);
            this.lblCostTax.Name = "lblCostTax";
            this.lblCostTax.Size = new System.Drawing.Size(280, 25);
            this.lblCostTax.TabIndex = 3;
            this.lblCostTax.Text = "The Cost including tax is:";
            this.lblCostTax.Click += new System.EventHandler(this.LblCostTax_Click);
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.Location = new System.Drawing.Point(567, 378);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(43, 24);
            this.lblAnswer.TabIndex = 4;
            this.lblAnswer.Text = "???";
            // 
            // lblCostBeforeTax
            // 
            this.lblCostBeforeTax.AutoSize = true;
            this.lblCostBeforeTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostBeforeTax.Location = new System.Drawing.Point(571, 327);
            this.lblCostBeforeTax.Name = "lblCostBeforeTax";
            this.lblCostBeforeTax.Size = new System.Drawing.Size(39, 20);
            this.lblCostBeforeTax.TabIndex = 5;
            this.lblCostBeforeTax.Text = "???";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(71, 327);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(171, 25);
            this.lblSubtotal.TabIndex = 6;
            this.lblSubtotal.Text = "The Subtotal is";
            // 
            // frmPizzaCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.lblCostBeforeTax);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lblCostTax);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtDiameter);
            this.Controls.Add(this.lblDiameter);
            this.Name = "frmPizzaCost";
            this.Text = "Pizza Cost";
            this.Load += new System.EventHandler(this.PizzaCostForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDiameter;
        private System.Windows.Forms.TextBox txtDiameter;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblCostTax;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Label lblCostBeforeTax;
        private System.Windows.Forms.Label lblSubtotal;
    }
}

