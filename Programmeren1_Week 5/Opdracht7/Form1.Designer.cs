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
            this.btnGooien = new System.Windows.Forms.Button();
            this.lblWaarde = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGooien
            // 
            this.btnGooien.Location = new System.Drawing.Point(24, 188);
            this.btnGooien.Name = "btnGooien";
            this.btnGooien.Size = new System.Drawing.Size(202, 35);
            this.btnGooien.TabIndex = 6;
            this.btnGooien.Text = "Gooien";
            this.btnGooien.UseVisualStyleBackColor = true;
            this.btnGooien.Click += new System.EventHandler(this.BtnGooien_Click);
            // 
            // lblWaarde
            // 
            this.lblWaarde.AutoSize = true;
            this.lblWaarde.Location = new System.Drawing.Point(30, 36);
            this.lblWaarde.Name = "lblWaarde";
            this.lblWaarde.Size = new System.Drawing.Size(0, 13);
            this.lblWaarde.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 273);
            this.Controls.Add(this.lblWaarde);
            this.Controls.Add(this.btnGooien);
            this.Name = "Form1";
            this.Text = "Opdracht 7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGooien;
        private System.Windows.Forms.Label lblWaarde;
    }
}

