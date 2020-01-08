namespace Opdracht4
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
            this.txtGeefPrijs = new System.Windows.Forms.TextBox();
            this.btnBerekenBTW = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPrijs = new System.Windows.Forms.Label();
            this.lblBTW = new System.Windows.Forms.Label();
            this.lblTotaalPrijs = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Geef prijs:";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // txtGeefPrijs
            // 
            this.txtGeefPrijs.Location = new System.Drawing.Point(331, 63);
            this.txtGeefPrijs.Name = "txtGeefPrijs";
            this.txtGeefPrijs.Size = new System.Drawing.Size(232, 20);
            this.txtGeefPrijs.TabIndex = 1;
            // 
            // btnBerekenBTW
            // 
            this.btnBerekenBTW.Location = new System.Drawing.Point(115, 131);
            this.btnBerekenBTW.Name = "btnBerekenBTW";
            this.btnBerekenBTW.Size = new System.Drawing.Size(448, 23);
            this.btnBerekenBTW.TabIndex = 2;
            this.btnBerekenBTW.Text = "Bereken BTW";
            this.btnBerekenBTW.UseVisualStyleBackColor = true;
            this.btnBerekenBTW.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prijs:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "BTW:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 361);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Totaal prijs:";
            // 
            // lblPrijs
            // 
            this.lblPrijs.AutoSize = true;
            this.lblPrijs.Location = new System.Drawing.Point(502, 212);
            this.lblPrijs.Name = "lblPrijs";
            this.lblPrijs.Size = new System.Drawing.Size(0, 13);
            this.lblPrijs.TabIndex = 6;
            // 
            // lblBTW
            // 
            this.lblBTW.AutoSize = true;
            this.lblBTW.Location = new System.Drawing.Point(502, 289);
            this.lblBTW.Name = "lblBTW";
            this.lblBTW.Size = new System.Drawing.Size(0, 13);
            this.lblBTW.TabIndex = 7;
            // 
            // lblTotaalPrijs
            // 
            this.lblTotaalPrijs.AutoSize = true;
            this.lblTotaalPrijs.Location = new System.Drawing.Point(502, 361);
            this.lblTotaalPrijs.Name = "lblTotaalPrijs";
            this.lblTotaalPrijs.Size = new System.Drawing.Size(0, 13);
            this.lblTotaalPrijs.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTotaalPrijs);
            this.Controls.Add(this.lblBTW);
            this.Controls.Add(this.lblPrijs);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBerekenBTW);
            this.Controls.Add(this.txtGeefPrijs);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Opdracht4";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGeefPrijs;
        private System.Windows.Forms.Button btnBerekenBTW;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPrijs;
        private System.Windows.Forms.Label lblBTW;
        private System.Windows.Forms.Label lblTotaalPrijs;
    }
}

