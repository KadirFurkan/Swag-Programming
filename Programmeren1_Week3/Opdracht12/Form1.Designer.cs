namespace Opdracht12
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
            this.txtLeeftijd = new System.Windows.Forms.TextBox();
            this.btnBerekenBiosKaart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPrijsKaartje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Leeftijd";
            // 
            // txtLeeftijd
            // 
            this.txtLeeftijd.Location = new System.Drawing.Point(151, 36);
            this.txtLeeftijd.Name = "txtLeeftijd";
            this.txtLeeftijd.Size = new System.Drawing.Size(100, 20);
            this.txtLeeftijd.TabIndex = 1;
            // 
            // btnBerekenBiosKaart
            // 
            this.btnBerekenBiosKaart.Location = new System.Drawing.Point(31, 80);
            this.btnBerekenBiosKaart.Name = "btnBerekenBiosKaart";
            this.btnBerekenBiosKaart.Size = new System.Drawing.Size(220, 23);
            this.btnBerekenBiosKaart.TabIndex = 2;
            this.btnBerekenBiosKaart.Text = "Bereken bioscoopkaartje";
            this.btnBerekenBiosKaart.UseVisualStyleBackColor = true;
            this.btnBerekenBiosKaart.Click += new System.EventHandler(this.BtnBerekenBiosKaart_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prijs bioscoopkaartje";
            // 
            // lblPrijsKaartje
            // 
            this.lblPrijsKaartje.AutoSize = true;
            this.lblPrijsKaartje.Location = new System.Drawing.Point(184, 126);
            this.lblPrijsKaartje.Name = "lblPrijsKaartje";
            this.lblPrijsKaartje.Size = new System.Drawing.Size(0, 13);
            this.lblPrijsKaartje.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 165);
            this.Controls.Add(this.lblPrijsKaartje);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBerekenBiosKaart);
            this.Controls.Add(this.txtLeeftijd);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Opdracht 12";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLeeftijd;
        private System.Windows.Forms.Button btnBerekenBiosKaart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPrijsKaartje;
    }
}

