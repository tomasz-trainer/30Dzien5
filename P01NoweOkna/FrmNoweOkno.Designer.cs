namespace P01NoweOkna
{
    partial class FrmNoweOkno
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
            this.txtNoweOknoWiadomosc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNoweOknoWiadomosc
            // 
            this.txtNoweOknoWiadomosc.Location = new System.Drawing.Point(4, 22);
            this.txtNoweOknoWiadomosc.Name = "txtNoweOknoWiadomosc";
            this.txtNoweOknoWiadomosc.Size = new System.Drawing.Size(143, 20);
            this.txtNoweOknoWiadomosc.TabIndex = 1;
            // 
            // FrmNoweOkno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(159, 79);
            this.Controls.Add(this.txtNoweOknoWiadomosc);
            this.Name = "FrmNoweOkno";
            this.Text = "FrmNoweOkno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNoweOknoWiadomosc;
    }
}