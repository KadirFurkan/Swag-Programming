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
            this.label1 = new System.Windows.Forms.Label();
            this.txtInvoerGetal = new System.Windows.Forms.TextBox();
            this.btnVergelijk = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblVergelijking = new System.Windows.Forms.Label();
            this.lblSom1 = new System.Windows.Forms.Label();
            this.lblSom2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Geef een getal (n)";
            // 
            // txtInvoerGetal
            // 
            this.txtInvoerGetal.Location = new System.Drawing.Point(198, 45);
            this.txtInvoerGetal.Name = "txtInvoerGetal";
            this.txtInvoerGetal.Size = new System.Drawing.Size(100, 20);
            this.txtInvoerGetal.TabIndex = 1;
            // 
            // btnVergelijk
            // 
            this.btnVergelijk.Location = new System.Drawing.Point(55, 80);
            this.btnVergelijk.Name = "btnVergelijk";
            this.btnVergelijk.Size = new System.Drawing.Size(243, 34);
            this.btnVergelijk.TabIndex = 2;
            this.btnVergelijk.Text = "Vergelijk";
            this.btnVergelijk.UseVisualStyleBackColor = true;
            this.btnVergelijk.Click += new System.EventHandler(this.BtnVergelijk_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Som = n * (n+1) / 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Som = 0 + 1 + 2 + .. + n";
            // 
            // lblVergelijking
            // 
            this.lblVergelijking.AutoSize = true;
            this.lblVergelijking.Location = new System.Drawing.Point(52, 248);
            this.lblVergelijking.Name = "lblVergelijking";
            this.lblVergelijking.Size = new System.Drawing.Size(0, 13);
            this.lblVergelijking.TabIndex = 5;
            // 
            // lblSom1
            // 
            this.lblSom1.AutoSize = true;
            this.lblSom1.Location = new System.Drawing.Point(279, 155);
            this.lblSom1.Name = "lblSom1";
            this.lblSom1.Size = new System.Drawing.Size(0, 13);
            this.lblSom1.TabIndex = 6;
            // 
            // lblSom2
            // 
            this.lblSom2.AutoSize = true;
            this.lblSom2.Location = new System.Drawing.Point(279, 198);
            this.lblSom2.Name = "lblSom2";
            this.lblSom2.Size = new System.Drawing.Size(0, 13);
            this.lblSom2.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 345);
            this.Controls.Add(this.lblSom2);
            this.Controls.Add(this.lblSom1);
            this.Controls.Add(this.lblVergelijking);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnVergelijk);
            this.Controls.Add(this.txtInvoerGetal);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInvoerGetal;
        private System.Windows.Forms.Button btnVergelijk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblVergelijking;
        private System.Windows.Forms.Label lblSom1;
        private System.Windows.Forms.Label lblSom2;
    }
}

