namespace Opdracht11
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
            this.txtGetal1 = new System.Windows.Forms.TextBox();
            this.txtGetal2 = new System.Windows.Forms.TextBox();
            this.btnBerekenGemiddelde = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblGrootsteGetal = new System.Windows.Forms.Label();
            this.lblGemiddelde = new System.Windows.Forms.Label();
            this.lblVerschil = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Getal1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Getal2:";
            // 
            // txtGetal1
            // 
            this.txtGetal1.Location = new System.Drawing.Point(177, 73);
            this.txtGetal1.Name = "txtGetal1";
            this.txtGetal1.Size = new System.Drawing.Size(100, 20);
            this.txtGetal1.TabIndex = 2;
            // 
            // txtGetal2
            // 
            this.txtGetal2.Location = new System.Drawing.Point(177, 124);
            this.txtGetal2.Name = "txtGetal2";
            this.txtGetal2.Size = new System.Drawing.Size(100, 20);
            this.txtGetal2.TabIndex = 3;
            // 
            // btnBerekenGemiddelde
            // 
            this.btnBerekenGemiddelde.Location = new System.Drawing.Point(45, 181);
            this.btnBerekenGemiddelde.Name = "btnBerekenGemiddelde";
            this.btnBerekenGemiddelde.Size = new System.Drawing.Size(232, 23);
            this.btnBerekenGemiddelde.TabIndex = 4;
            this.btnBerekenGemiddelde.Text = "Bereken Gemiddelde";
            this.btnBerekenGemiddelde.UseVisualStyleBackColor = true;
            this.btnBerekenGemiddelde.Click += new System.EventHandler(this.BtnBerekenGemiddelde_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Grootste getal:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Gemiddelde:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Verschil:";
            // 
            // lblGrootsteGetal
            // 
            this.lblGrootsteGetal.AutoSize = true;
            this.lblGrootsteGetal.Location = new System.Drawing.Point(174, 228);
            this.lblGrootsteGetal.Name = "lblGrootsteGetal";
            this.lblGrootsteGetal.Size = new System.Drawing.Size(0, 13);
            this.lblGrootsteGetal.TabIndex = 8;
            // 
            // lblGemiddelde
            // 
            this.lblGemiddelde.AutoSize = true;
            this.lblGemiddelde.Location = new System.Drawing.Point(174, 267);
            this.lblGemiddelde.Name = "lblGemiddelde";
            this.lblGemiddelde.Size = new System.Drawing.Size(0, 13);
            this.lblGemiddelde.TabIndex = 9;
            // 
            // lblVerschil
            // 
            this.lblVerschil.AutoSize = true;
            this.lblVerschil.Location = new System.Drawing.Point(174, 310);
            this.lblVerschil.Name = "lblVerschil";
            this.lblVerschil.Size = new System.Drawing.Size(0, 13);
            this.lblVerschil.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 355);
            this.Controls.Add(this.lblVerschil);
            this.Controls.Add(this.lblGemiddelde);
            this.Controls.Add(this.lblGrootsteGetal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBerekenGemiddelde);
            this.Controls.Add(this.txtGetal2);
            this.Controls.Add(this.txtGetal1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Opdracht 11";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGetal1;
        private System.Windows.Forms.TextBox txtGetal2;
        private System.Windows.Forms.Button btnBerekenGemiddelde;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblGrootsteGetal;
        private System.Windows.Forms.Label lblGemiddelde;
        private System.Windows.Forms.Label lblVerschil;
    }
}

