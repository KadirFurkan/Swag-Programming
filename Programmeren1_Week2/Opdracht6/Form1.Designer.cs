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
            this.lblSeconden = new System.Windows.Forms.Label();
            this.btnBerekenTijd = new System.Windows.Forms.Button();
            this.lblUMS = new System.Windows.Forms.Label();
            this.lblAntwoord = new System.Windows.Forms.Label();
            this.txtSeconden = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblSeconden
            // 
            this.lblSeconden.AutoSize = true;
            this.lblSeconden.Location = new System.Drawing.Point(67, 67);
            this.lblSeconden.Name = "lblSeconden";
            this.lblSeconden.Size = new System.Drawing.Size(59, 13);
            this.lblSeconden.TabIndex = 1;
            this.lblSeconden.Text = "Seconden:";
            // 
            // btnBerekenTijd
            // 
            this.btnBerekenTijd.Location = new System.Drawing.Point(70, 127);
            this.btnBerekenTijd.Name = "btnBerekenTijd";
            this.btnBerekenTijd.Size = new System.Drawing.Size(289, 23);
            this.btnBerekenTijd.TabIndex = 2;
            this.btnBerekenTijd.Text = "Bereken tijd";
            this.btnBerekenTijd.UseVisualStyleBackColor = true;
            this.btnBerekenTijd.Click += new System.EventHandler(this.BtnBerekenTijd_Click);
            // 
            // lblUMS
            // 
            this.lblUMS.AutoSize = true;
            this.lblUMS.Location = new System.Drawing.Point(67, 199);
            this.lblUMS.Name = "lblUMS";
            this.lblUMS.Size = new System.Drawing.Size(123, 13);
            this.lblUMS.TabIndex = 3;
            this.lblUMS.Text = "Uren:Minuten:Seconden";
            // 
            // lblAntwoord
            // 
            this.lblAntwoord.AutoSize = true;
            this.lblAntwoord.Location = new System.Drawing.Point(67, 244);
            this.lblAntwoord.Name = "lblAntwoord";
            this.lblAntwoord.Size = new System.Drawing.Size(0, 13);
            this.lblAntwoord.TabIndex = 4;
            // 
            // txtSeconden
            // 
            this.txtSeconden.Location = new System.Drawing.Point(259, 64);
            this.txtSeconden.Name = "txtSeconden";
            this.txtSeconden.Size = new System.Drawing.Size(100, 20);
            this.txtSeconden.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 284);
            this.Controls.Add(this.txtSeconden);
            this.Controls.Add(this.lblAntwoord);
            this.Controls.Add(this.lblUMS);
            this.Controls.Add(this.btnBerekenTijd);
            this.Controls.Add(this.lblSeconden);
            this.Name = "Form1";
            this.Text = "Opdracht6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSeconden;
        private System.Windows.Forms.Button btnBerekenTijd;
        private System.Windows.Forms.Label lblUMS;
        private System.Windows.Forms.Label lblAntwoord;
        private System.Windows.Forms.TextBox txtSeconden;
    }
}

