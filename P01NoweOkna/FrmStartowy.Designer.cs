namespace P01NoweOkna
{
    partial class FrmStartowy
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
            this.btnNoweOkno = new System.Windows.Forms.Button();
            this.txtWiadomosc = new System.Windows.Forms.TextBox();
            this.btnWyslij = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNoweOkno
            // 
            this.btnNoweOkno.Location = new System.Drawing.Point(12, 12);
            this.btnNoweOkno.Name = "btnNoweOkno";
            this.btnNoweOkno.Size = new System.Drawing.Size(113, 85);
            this.btnNoweOkno.TabIndex = 1;
            this.btnNoweOkno.Text = "NoweOkno";
            this.btnNoweOkno.UseVisualStyleBackColor = true;
            this.btnNoweOkno.Click += new System.EventHandler(this.btnNoweOkno_Click);
            // 
            // txtWiadomosc
            // 
            this.txtWiadomosc.Location = new System.Drawing.Point(12, 117);
            this.txtWiadomosc.Name = "txtWiadomosc";
            this.txtWiadomosc.Size = new System.Drawing.Size(113, 20);
            this.txtWiadomosc.TabIndex = 2;
            // 
            // btnWyslij
            // 
            this.btnWyslij.Location = new System.Drawing.Point(13, 143);
            this.btnWyslij.Name = "btnWyslij";
            this.btnWyslij.Size = new System.Drawing.Size(112, 23);
            this.btnWyslij.TabIndex = 3;
            this.btnWyslij.Text = "Wyślij";
            this.btnWyslij.UseVisualStyleBackColor = true;
            this.btnWyslij.Click += new System.EventHandler(this.btnWyslij_Click);
            // 
            // FrmStartowy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(137, 181);
            this.Controls.Add(this.btnWyslij);
            this.Controls.Add(this.txtWiadomosc);
            this.Controls.Add(this.btnNoweOkno);
            this.Name = "FrmStartowy";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNoweOkno;
        private System.Windows.Forms.TextBox txtWiadomosc;
        private System.Windows.Forms.Button btnWyslij;
    }
}

