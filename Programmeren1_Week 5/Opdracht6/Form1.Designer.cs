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
            this.label2 = new System.Windows.Forms.Label();
            this.lblVooraf = new System.Windows.Forms.Label();
            this.lblAchteraf = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInvoer = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inhoud tabel (vooraf)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(253, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Inhoud tabel (achteraf)";
            // 
            // lblVooraf
            // 
            this.lblVooraf.AutoSize = true;
            this.lblVooraf.Location = new System.Drawing.Point(22, 77);
            this.lblVooraf.Name = "lblVooraf";
            this.lblVooraf.Size = new System.Drawing.Size(0, 13);
            this.lblVooraf.TabIndex = 2;
            // 
            // lblAchteraf
            // 
            this.lblAchteraf.AutoSize = true;
            this.lblAchteraf.Location = new System.Drawing.Point(253, 77);
            this.lblAchteraf.Name = "lblAchteraf";
            this.lblAchteraf.Size = new System.Drawing.Size(0, 13);
            this.lblAchteraf.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Vergelijksgetal";
            // 
            // txtInvoer
            // 
            this.txtInvoer.Location = new System.Drawing.Point(117, 353);
            this.txtInvoer.Name = "txtInvoer";
            this.txtInvoer.Size = new System.Drawing.Size(63, 20);
            this.txtInvoer.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(256, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "Vergelijk";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(431, 390);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtInvoer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblAchteraf);
            this.Controls.Add(this.lblVooraf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Opdracht 6";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblVooraf;
        private System.Windows.Forms.Label lblAchteraf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInvoer;
        private System.Windows.Forms.Button button1;
    }
}

