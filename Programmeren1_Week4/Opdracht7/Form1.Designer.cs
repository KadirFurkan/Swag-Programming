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
            this.txtZijde = new System.Windows.Forms.TextBox();
            this.btnMaakVierkant = new System.Windows.Forms.Button();
            this.lblVierkant = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zijde";
            // 
            // txtZijde
            // 
            this.txtZijde.Location = new System.Drawing.Point(125, 51);
            this.txtZijde.Name = "txtZijde";
            this.txtZijde.Size = new System.Drawing.Size(100, 20);
            this.txtZijde.TabIndex = 1;
            // 
            // btnMaakVierkant
            // 
            this.btnMaakVierkant.Location = new System.Drawing.Point(37, 104);
            this.btnMaakVierkant.Name = "btnMaakVierkant";
            this.btnMaakVierkant.Size = new System.Drawing.Size(188, 23);
            this.btnMaakVierkant.TabIndex = 2;
            this.btnMaakVierkant.Text = "Maak vierkant";
            this.btnMaakVierkant.UseVisualStyleBackColor = true;
            this.btnMaakVierkant.Click += new System.EventHandler(this.BtnMaakVierkant_Click);
            // 
            // lblVierkant
            // 
            this.lblVierkant.AutoSize = true;
            this.lblVierkant.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVierkant.Location = new System.Drawing.Point(33, 165);
            this.lblVierkant.Name = "lblVierkant";
            this.lblVierkant.Size = new System.Drawing.Size(0, 22);
            this.lblVierkant.TabIndex = 3;
            this.lblVierkant.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 469);
            this.Controls.Add(this.lblVierkant);
            this.Controls.Add(this.btnMaakVierkant);
            this.Controls.Add(this.txtZijde);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Opdracht 7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtZijde;
        private System.Windows.Forms.Button btnMaakVierkant;
        private System.Windows.Forms.Label lblVierkant;
    }
}

