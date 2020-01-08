namespace Opdracht7
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBeginKM = new System.Windows.Forms.TextBox();
            this.txtEindKM = new System.Windows.Forms.TextBox();
            this.txtPrijsKM = new System.Windows.Forms.TextBox();
            this.btnWissen = new System.Windows.Forms.Button();
            this.btnBedragen = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPrijsExBTW = new System.Windows.Forms.Label();
            this.lblBTW = new System.Windows.Forms.Label();
            this.lblPrijsIncBTW = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Begin KM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Eind KM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prijs per KM";
            // 
            // txtBeginKM
            // 
            this.txtBeginKM.Location = new System.Drawing.Point(191, 68);
            this.txtBeginKM.Name = "txtBeginKM";
            this.txtBeginKM.Size = new System.Drawing.Size(100, 20);
            this.txtBeginKM.TabIndex = 3;
            // 
            // txtEindKM
            // 
            this.txtEindKM.Location = new System.Drawing.Point(191, 117);
            this.txtEindKM.Name = "txtEindKM";
            this.txtEindKM.Size = new System.Drawing.Size(100, 20);
            this.txtEindKM.TabIndex = 4;
            // 
            // txtPrijsKM
            // 
            this.txtPrijsKM.Location = new System.Drawing.Point(191, 164);
            this.txtPrijsKM.Name = "txtPrijsKM";
            this.txtPrijsKM.Size = new System.Drawing.Size(100, 20);
            this.txtPrijsKM.TabIndex = 5;
            // 
            // btnWissen
            // 
            this.btnWissen.Location = new System.Drawing.Point(366, 57);
            this.btnWissen.Name = "btnWissen";
            this.btnWissen.Size = new System.Drawing.Size(109, 31);
            this.btnWissen.TabIndex = 6;
            this.btnWissen.Text = "Wissen";
            this.btnWissen.UseVisualStyleBackColor = true;
            this.btnWissen.Click += new System.EventHandler(this.BtnWissen_Click);
            // 
            // btnBedragen
            // 
            this.btnBedragen.Location = new System.Drawing.Point(366, 153);
            this.btnBedragen.Name = "btnBedragen";
            this.btnBedragen.Size = new System.Drawing.Size(109, 27);
            this.btnBedragen.TabIndex = 7;
            this.btnBedragen.Text = "Bedragen";
            this.btnBedragen.UseVisualStyleBackColor = true;
            this.btnBedragen.Click += new System.EventHandler(this.BtnBedragen_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Prijs excl. BTW";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(188, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "BTW";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(363, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Prijs incl. BTW";
            // 
            // lblPrijsExBTW
            // 
            this.lblPrijsExBTW.AutoSize = true;
            this.lblPrijsExBTW.Location = new System.Drawing.Point(68, 320);
            this.lblPrijsExBTW.Name = "lblPrijsExBTW";
            this.lblPrijsExBTW.Size = new System.Drawing.Size(0, 13);
            this.lblPrijsExBTW.TabIndex = 11;
            // 
            // lblBTW
            // 
            this.lblBTW.AutoSize = true;
            this.lblBTW.Location = new System.Drawing.Point(188, 320);
            this.lblBTW.Name = "lblBTW";
            this.lblBTW.Size = new System.Drawing.Size(0, 13);
            this.lblBTW.TabIndex = 12;
            // 
            // lblPrijsIncBTW
            // 
            this.lblPrijsIncBTW.AutoSize = true;
            this.lblPrijsIncBTW.Location = new System.Drawing.Point(363, 320);
            this.lblPrijsIncBTW.Name = "lblPrijsIncBTW";
            this.lblPrijsIncBTW.Size = new System.Drawing.Size(0, 13);
            this.lblPrijsIncBTW.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 356);
            this.Controls.Add(this.lblPrijsIncBTW);
            this.Controls.Add(this.lblBTW);
            this.Controls.Add(this.lblPrijsExBTW);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBedragen);
            this.Controls.Add(this.btnWissen);
            this.Controls.Add(this.txtPrijsKM);
            this.Controls.Add(this.txtEindKM);
            this.Controls.Add(this.txtBeginKM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Opdracht7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBeginKM;
        private System.Windows.Forms.TextBox txtEindKM;
        private System.Windows.Forms.TextBox txtPrijsKM;
        private System.Windows.Forms.Button btnWissen;
        private System.Windows.Forms.Button btnBedragen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPrijsExBTW;
        private System.Windows.Forms.Label lblBTW;
        private System.Windows.Forms.Label lblPrijsIncBTW;
    }
}

