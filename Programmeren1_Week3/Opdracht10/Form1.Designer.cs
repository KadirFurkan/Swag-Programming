namespace Opdracht10
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
            this.txtMaandsalaris = new System.Windows.Forms.TextBox();
            this.btnBereken = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblVerhoging = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNieuweMaandsalaris = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Huidige maandsalaris";
            // 
            // txtMaandsalaris
            // 
            this.txtMaandsalaris.Location = new System.Drawing.Point(223, 64);
            this.txtMaandsalaris.Name = "txtMaandsalaris";
            this.txtMaandsalaris.Size = new System.Drawing.Size(100, 20);
            this.txtMaandsalaris.TabIndex = 1;
            // 
            // btnBereken
            // 
            this.btnBereken.Location = new System.Drawing.Point(34, 107);
            this.btnBereken.Name = "btnBereken";
            this.btnBereken.Size = new System.Drawing.Size(289, 27);
            this.btnBereken.TabIndex = 2;
            this.btnBereken.Text = "Bereken verhoging";
            this.btnBereken.UseVisualStyleBackColor = true;
            this.btnBereken.Click += new System.EventHandler(this.BtnBereken_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Verhoging";
            // 
            // lblVerhoging
            // 
            this.lblVerhoging.AutoSize = true;
            this.lblVerhoging.Location = new System.Drawing.Point(220, 167);
            this.lblVerhoging.Name = "lblVerhoging";
            this.lblVerhoging.Size = new System.Drawing.Size(0, 13);
            this.lblVerhoging.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nieuwe maandsalaris";
            // 
            // lblNieuweMaandsalaris
            // 
            this.lblNieuweMaandsalaris.AutoSize = true;
            this.lblNieuweMaandsalaris.Location = new System.Drawing.Point(220, 217);
            this.lblNieuweMaandsalaris.Name = "lblNieuweMaandsalaris";
            this.lblNieuweMaandsalaris.Size = new System.Drawing.Size(0, 13);
            this.lblNieuweMaandsalaris.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 269);
            this.Controls.Add(this.lblNieuweMaandsalaris);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblVerhoging);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBereken);
            this.Controls.Add(this.txtMaandsalaris);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Opdracht 10";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaandsalaris;
        private System.Windows.Forms.Button btnBereken;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblVerhoging;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNieuweMaandsalaris;
    }
}

