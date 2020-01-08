namespace Opdracht8
{
    partial class Form1
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
            this.lblAantalTshirt = new System.Windows.Forms.Label();
            this.lblAantalBroeken = new System.Windows.Forms.Label();
            this.btnBereken = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblPrijs = new System.Windows.Forms.Label();
            this.lblBTW = new System.Windows.Forms.Label();
            this.lblTotPrijs = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAantalShirts = new System.Windows.Forms.TextBox();
            this.txtAantalBroeken = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAantalTshirt
            // 
            this.lblAantalTshirt.AutoSize = true;
            this.lblAantalTshirt.Location = new System.Drawing.Point(46, 30);
            this.lblAantalTshirt.Name = "lblAantalTshirt";
            this.lblAantalTshirt.Size = new System.Drawing.Size(127, 13);
            this.lblAantalTshirt.TabIndex = 0;
            this.lblAantalTshirt.Text = "Aantal T-Shirts (á €30,00)";
            // 
            // lblAantalBroeken
            // 
            this.lblAantalBroeken.AutoSize = true;
            this.lblAantalBroeken.Location = new System.Drawing.Point(46, 81);
            this.lblAantalBroeken.Name = "lblAantalBroeken";
            this.lblAantalBroeken.Size = new System.Drawing.Size(137, 13);
            this.lblAantalBroeken.TabIndex = 1;
            this.lblAantalBroeken.Text = "Aantal Broeken (á €100,00)";
            // 
            // btnBereken
            // 
            this.btnBereken.Image = global::Opdracht8.Properties.Resources.calculator4;
            this.btnBereken.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBereken.Location = new System.Drawing.Point(49, 124);
            this.btnBereken.Name = "btnBereken";
            this.btnBereken.Size = new System.Drawing.Size(380, 73);
            this.btnBereken.TabIndex = 2;
            this.btnBereken.Text = "Bereken";
            this.btnBereken.UseVisualStyleBackColor = true;
            this.btnBereken.Click += new System.EventHandler(this.BtnBereken_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Datum:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDatum);
            this.groupBox1.Controls.Add(this.lblPrijs);
            this.groupBox1.Controls.Add(this.lblBTW);
            this.groupBox1.Controls.Add(this.lblTotPrijs);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(49, 223);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 150);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rekening";
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(254, 32);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(0, 13);
            this.lblDatum.TabIndex = 10;
            // 
            // lblPrijs
            // 
            this.lblPrijs.AutoSize = true;
            this.lblPrijs.Location = new System.Drawing.Point(254, 63);
            this.lblPrijs.Name = "lblPrijs";
            this.lblPrijs.Size = new System.Drawing.Size(0, 13);
            this.lblPrijs.TabIndex = 9;
            // 
            // lblBTW
            // 
            this.lblBTW.AutoSize = true;
            this.lblBTW.Location = new System.Drawing.Point(254, 92);
            this.lblBTW.Name = "lblBTW";
            this.lblBTW.Size = new System.Drawing.Size(0, 13);
            this.lblBTW.TabIndex = 8;
            // 
            // lblTotPrijs
            // 
            this.lblTotPrijs.AutoSize = true;
            this.lblTotPrijs.Location = new System.Drawing.Point(254, 123);
            this.lblTotPrijs.Name = "lblTotPrijs";
            this.lblTotPrijs.Size = new System.Drawing.Size(0, 13);
            this.lblTotPrijs.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Totaal prijs:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "BTW: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Prijs:";
            // 
            // txtAantalShirts
            // 
            this.txtAantalShirts.Location = new System.Drawing.Point(306, 30);
            this.txtAantalShirts.Name = "txtAantalShirts";
            this.txtAantalShirts.Size = new System.Drawing.Size(123, 20);
            this.txtAantalShirts.TabIndex = 5;
            // 
            // txtAantalBroeken
            // 
            this.txtAantalBroeken.Location = new System.Drawing.Point(306, 81);
            this.txtAantalBroeken.Name = "txtAantalBroeken";
            this.txtAantalBroeken.Size = new System.Drawing.Size(123, 20);
            this.txtAantalBroeken.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 401);
            this.Controls.Add(this.txtAantalBroeken);
            this.Controls.Add(this.txtAantalShirts);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBereken);
            this.Controls.Add(this.lblAantalBroeken);
            this.Controls.Add(this.lblAantalTshirt);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Opdracht 8";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAantalTshirt;
        private System.Windows.Forms.Label lblAantalBroeken;
        private System.Windows.Forms.Button btnBereken;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblPrijs;
        private System.Windows.Forms.Label lblBTW;
        private System.Windows.Forms.Label lblTotPrijs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAantalShirts;
        private System.Windows.Forms.TextBox txtAantalBroeken;
    }
}

