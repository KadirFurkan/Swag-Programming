namespace Opdracht9
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
            this.rdbtnVoetbal = new System.Windows.Forms.RadioButton();
            this.rdbtnHandbal = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLeeftijd = new System.Windows.Forms.TextBox();
            this.txtDuurLidmaatschap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBereken = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblContributie = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sportsoort";
            // 
            // rdbtnVoetbal
            // 
            this.rdbtnVoetbal.AutoSize = true;
            this.rdbtnVoetbal.Location = new System.Drawing.Point(203, 62);
            this.rdbtnVoetbal.Name = "rdbtnVoetbal";
            this.rdbtnVoetbal.Size = new System.Drawing.Size(61, 17);
            this.rdbtnVoetbal.TabIndex = 1;
            this.rdbtnVoetbal.TabStop = true;
            this.rdbtnVoetbal.Text = "Voetbal";
            this.rdbtnVoetbal.UseVisualStyleBackColor = true;
            // 
            // rdbtnHandbal
            // 
            this.rdbtnHandbal.AutoSize = true;
            this.rdbtnHandbal.Location = new System.Drawing.Point(203, 87);
            this.rdbtnHandbal.Name = "rdbtnHandbal";
            this.rdbtnHandbal.Size = new System.Drawing.Size(65, 17);
            this.rdbtnHandbal.TabIndex = 2;
            this.rdbtnHandbal.TabStop = true;
            this.rdbtnHandbal.Text = "Handbal";
            this.rdbtnHandbal.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Leeftijd";
            // 
            // txtLeeftijd
            // 
            this.txtLeeftijd.Location = new System.Drawing.Point(203, 153);
            this.txtLeeftijd.Name = "txtLeeftijd";
            this.txtLeeftijd.Size = new System.Drawing.Size(100, 20);
            this.txtLeeftijd.TabIndex = 4;
            // 
            // txtDuurLidmaatschap
            // 
            this.txtDuurLidmaatschap.Location = new System.Drawing.Point(203, 190);
            this.txtDuurLidmaatschap.Name = "txtDuurLidmaatschap";
            this.txtDuurLidmaatschap.Size = new System.Drawing.Size(100, 20);
            this.txtDuurLidmaatschap.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Duur lidmaatschap";
            // 
            // btnBereken
            // 
            this.btnBereken.Location = new System.Drawing.Point(54, 255);
            this.btnBereken.Name = "btnBereken";
            this.btnBereken.Size = new System.Drawing.Size(249, 23);
            this.btnBereken.TabIndex = 7;
            this.btnBereken.Text = "Bereken contribute";
            this.btnBereken.UseVisualStyleBackColor = true;
            this.btnBereken.Click += new System.EventHandler(this.BtnBereken_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Te betalen contributie";
            // 
            // lblContributie
            // 
            this.lblContributie.AutoSize = true;
            this.lblContributie.Location = new System.Drawing.Point(200, 314);
            this.lblContributie.Name = "lblContributie";
            this.lblContributie.Size = new System.Drawing.Size(0, 13);
            this.lblContributie.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 366);
            this.Controls.Add(this.lblContributie);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBereken);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDuurLidmaatschap);
            this.Controls.Add(this.txtLeeftijd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rdbtnHandbal);
            this.Controls.Add(this.rdbtnVoetbal);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Opdracht 9";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbtnVoetbal;
        private System.Windows.Forms.RadioButton rdbtnHandbal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLeeftijd;
        private System.Windows.Forms.TextBox txtDuurLidmaatschap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBereken;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblContributie;
    }
}

