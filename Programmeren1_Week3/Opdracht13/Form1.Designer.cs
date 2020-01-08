namespace Opdracht13
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
            this.txtDagenGehuurd = new System.Windows.Forms.TextBox();
            this.txtKmGereden = new System.Windows.Forms.TextBox();
            this.checkTankOpHuurder = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLitersGetankt = new System.Windows.Forms.TextBox();
            this.btnBerekenBedrag = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblHuurBedrag = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hoeveel dagen gehuurd ?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hoeveel km gereden  ?";
            // 
            // txtDagenGehuurd
            // 
            this.txtDagenGehuurd.Location = new System.Drawing.Point(198, 44);
            this.txtDagenGehuurd.Name = "txtDagenGehuurd";
            this.txtDagenGehuurd.Size = new System.Drawing.Size(84, 20);
            this.txtDagenGehuurd.TabIndex = 2;
            // 
            // txtKmGereden
            // 
            this.txtKmGereden.Location = new System.Drawing.Point(198, 87);
            this.txtKmGereden.Name = "txtKmGereden";
            this.txtKmGereden.Size = new System.Drawing.Size(84, 20);
            this.txtKmGereden.TabIndex = 3;
            // 
            // checkTankOpHuurder
            // 
            this.checkTankOpHuurder.AutoSize = true;
            this.checkTankOpHuurder.Location = new System.Drawing.Point(48, 134);
            this.checkTankOpHuurder.Name = "checkTankOpHuurder";
            this.checkTankOpHuurder.Size = new System.Drawing.Size(191, 17);
            this.checkTankOpHuurder.TabIndex = 4;
            this.checkTankOpHuurder.Text = "Tank op de kosten van de huurder";
            this.checkTankOpHuurder.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hoeveel liters getankt ?";
            // 
            // txtLitersGetankt
            // 
            this.txtLitersGetankt.Location = new System.Drawing.Point(198, 182);
            this.txtLitersGetankt.Name = "txtLitersGetankt";
            this.txtLitersGetankt.Size = new System.Drawing.Size(84, 20);
            this.txtLitersGetankt.TabIndex = 6;
            // 
            // btnBerekenBedrag
            // 
            this.btnBerekenBedrag.Location = new System.Drawing.Point(27, 242);
            this.btnBerekenBedrag.Name = "btnBerekenBedrag";
            this.btnBerekenBedrag.Size = new System.Drawing.Size(255, 23);
            this.btnBerekenBedrag.TabIndex = 7;
            this.btnBerekenBedrag.Text = "Bereken huurbedrag";
            this.btnBerekenBedrag.UseVisualStyleBackColor = true;
            this.btnBerekenBedrag.Click += new System.EventHandler(this.BtnBerekenBedrag_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Huurbedrag";
            // 
            // lblHuurBedrag
            // 
            this.lblHuurBedrag.AutoSize = true;
            this.lblHuurBedrag.Location = new System.Drawing.Point(195, 301);
            this.lblHuurBedrag.Name = "lblHuurBedrag";
            this.lblHuurBedrag.Size = new System.Drawing.Size(0, 13);
            this.lblHuurBedrag.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 360);
            this.Controls.Add(this.lblHuurBedrag);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBerekenBedrag);
            this.Controls.Add(this.txtLitersGetankt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkTankOpHuurder);
            this.Controls.Add(this.txtKmGereden);
            this.Controls.Add(this.txtDagenGehuurd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Opdracht 13";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDagenGehuurd;
        private System.Windows.Forms.TextBox txtKmGereden;
        private System.Windows.Forms.CheckBox checkTankOpHuurder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLitersGetankt;
        private System.Windows.Forms.Button btnBerekenBedrag;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblHuurBedrag;
    }
}

