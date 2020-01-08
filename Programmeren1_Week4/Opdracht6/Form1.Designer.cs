namespace Opdracht6
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
            this.txtStartBedrag = new System.Windows.Forms.TextBox();
            this.btnBerekenEindKapitaal = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEindKapitaal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Startbedrag";
            // 
            // txtStartBedrag
            // 
            this.txtStartBedrag.Location = new System.Drawing.Point(142, 54);
            this.txtStartBedrag.Name = "txtStartBedrag";
            this.txtStartBedrag.Size = new System.Drawing.Size(100, 20);
            this.txtStartBedrag.TabIndex = 1;
            // 
            // btnBerekenEindKapitaal
            // 
            this.btnBerekenEindKapitaal.Location = new System.Drawing.Point(37, 97);
            this.btnBerekenEindKapitaal.Name = "btnBerekenEindKapitaal";
            this.btnBerekenEindKapitaal.Size = new System.Drawing.Size(205, 23);
            this.btnBerekenEindKapitaal.TabIndex = 2;
            this.btnBerekenEindKapitaal.Text = "Bereken eindkapitaal";
            this.btnBerekenEindKapitaal.UseVisualStyleBackColor = true;
            this.btnBerekenEindKapitaal.Click += new System.EventHandler(this.BtnBerekenEindKapitaal_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Eindkapitaal";
            // 
            // lblEindKapitaal
            // 
            this.lblEindKapitaal.AutoSize = true;
            this.lblEindKapitaal.Location = new System.Drawing.Point(139, 144);
            this.lblEindKapitaal.Name = "lblEindKapitaal";
            this.lblEindKapitaal.Size = new System.Drawing.Size(0, 13);
            this.lblEindKapitaal.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 228);
            this.Controls.Add(this.lblEindKapitaal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBerekenEindKapitaal);
            this.Controls.Add(this.txtStartBedrag);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Opdracht 6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStartBedrag;
        private System.Windows.Forms.Button btnBerekenEindKapitaal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEindKapitaal;
    }
}

