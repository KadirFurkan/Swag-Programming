namespace Opdracht5
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
            this.lblGetal1 = new System.Windows.Forms.Label();
            this.lblGetal2 = new System.Windows.Forms.Label();
            this.lblGetal3 = new System.Windows.Forms.Label();
            this.txtGetal1 = new System.Windows.Forms.TextBox();
            this.txtGetal2 = new System.Windows.Forms.TextBox();
            this.txtGetal3 = new System.Windows.Forms.TextBox();
            this.btnBerekenGem = new System.Windows.Forms.Button();
            this.lblGemiddelde = new System.Windows.Forms.Label();
            this.lblGemResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGetal1
            // 
            this.lblGetal1.AutoSize = true;
            this.lblGetal1.Location = new System.Drawing.Point(64, 81);
            this.lblGetal1.Name = "lblGetal1";
            this.lblGetal1.Size = new System.Drawing.Size(68, 13);
            this.lblGetal1.TabIndex = 0;
            this.lblGetal1.Text = "Geef getal 1:";
            // 
            // lblGetal2
            // 
            this.lblGetal2.AutoSize = true;
            this.lblGetal2.Location = new System.Drawing.Point(64, 114);
            this.lblGetal2.Name = "lblGetal2";
            this.lblGetal2.Size = new System.Drawing.Size(68, 13);
            this.lblGetal2.TabIndex = 1;
            this.lblGetal2.Text = "Geef getal 2:";
            // 
            // lblGetal3
            // 
            this.lblGetal3.AutoSize = true;
            this.lblGetal3.Location = new System.Drawing.Point(64, 147);
            this.lblGetal3.Name = "lblGetal3";
            this.lblGetal3.Size = new System.Drawing.Size(68, 13);
            this.lblGetal3.TabIndex = 2;
            this.lblGetal3.Text = "Geef getal 3:";
            // 
            // txtGetal1
            // 
            this.txtGetal1.Location = new System.Drawing.Point(272, 74);
            this.txtGetal1.Name = "txtGetal1";
            this.txtGetal1.Size = new System.Drawing.Size(100, 20);
            this.txtGetal1.TabIndex = 3;
            // 
            // txtGetal2
            // 
            this.txtGetal2.Location = new System.Drawing.Point(272, 107);
            this.txtGetal2.Name = "txtGetal2";
            this.txtGetal2.Size = new System.Drawing.Size(100, 20);
            this.txtGetal2.TabIndex = 4;
            // 
            // txtGetal3
            // 
            this.txtGetal3.Location = new System.Drawing.Point(272, 140);
            this.txtGetal3.Name = "txtGetal3";
            this.txtGetal3.Size = new System.Drawing.Size(100, 20);
            this.txtGetal3.TabIndex = 5;
            // 
            // btnBerekenGem
            // 
            this.btnBerekenGem.Location = new System.Drawing.Point(67, 187);
            this.btnBerekenGem.Name = "btnBerekenGem";
            this.btnBerekenGem.Size = new System.Drawing.Size(305, 23);
            this.btnBerekenGem.TabIndex = 6;
            this.btnBerekenGem.Text = "Bereken gemiddelde";
            this.btnBerekenGem.UseVisualStyleBackColor = true;
            this.btnBerekenGem.Click += new System.EventHandler(this.BtnBerekenGem_Click);
            // 
            // lblGemiddelde
            // 
            this.lblGemiddelde.AutoSize = true;
            this.lblGemiddelde.Location = new System.Drawing.Point(64, 252);
            this.lblGemiddelde.Name = "lblGemiddelde";
            this.lblGemiddelde.Size = new System.Drawing.Size(69, 13);
            this.lblGemiddelde.TabIndex = 7;
            this.lblGemiddelde.Text = "Gemiddelde: ";
            // 
            // lblGemResult
            // 
            this.lblGemResult.AutoSize = true;
            this.lblGemResult.Location = new System.Drawing.Point(269, 252);
            this.lblGemResult.Name = "lblGemResult";
            this.lblGemResult.Size = new System.Drawing.Size(0, 13);
            this.lblGemResult.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 363);
            this.Controls.Add(this.lblGemResult);
            this.Controls.Add(this.lblGemiddelde);
            this.Controls.Add(this.btnBerekenGem);
            this.Controls.Add(this.txtGetal3);
            this.Controls.Add(this.txtGetal2);
            this.Controls.Add(this.txtGetal1);
            this.Controls.Add(this.lblGetal3);
            this.Controls.Add(this.lblGetal2);
            this.Controls.Add(this.lblGetal1);
            this.Name = "Form1";
            this.Text = "Opdracht5";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGetal1;
        private System.Windows.Forms.Label lblGetal2;
        private System.Windows.Forms.Label lblGetal3;
        private System.Windows.Forms.TextBox txtGetal1;
        private System.Windows.Forms.TextBox txtGetal2;
        private System.Windows.Forms.TextBox txtGetal3;
        private System.Windows.Forms.Button btnBerekenGem;
        private System.Windows.Forms.Label lblGemiddelde;
        private System.Windows.Forms.Label lblGemResult;
    }
}

