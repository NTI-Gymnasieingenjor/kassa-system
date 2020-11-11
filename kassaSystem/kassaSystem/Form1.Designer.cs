namespace kassaSystem
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
            this.btnBulle = new System.Windows.Forms.Button();
            this.tbxSumma = new System.Windows.Forms.TextBox();
            this.lblSumma = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBulle
            // 
            this.btnBulle.Location = new System.Drawing.Point(356, 180);
            this.btnBulle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBulle.Name = "btnBulle";
            this.btnBulle.Size = new System.Drawing.Size(737, 320);
            this.btnBulle.TabIndex = 0;
            this.btnBulle.Text = "Bulle";
            this.btnBulle.UseVisualStyleBackColor = true;
            this.btnBulle.Click += new System.EventHandler(this.btnBulle_Click);
            // 
            // tbxSumma
            // 
            this.tbxSumma.Location = new System.Drawing.Point(356, 546);
            this.tbxSumma.Name = "tbxSumma";
            this.tbxSumma.Size = new System.Drawing.Size(737, 24);
            this.tbxSumma.TabIndex = 1;
            this.tbxSumma.Text = "0";
            // 
            // lblSumma
            // 
            this.lblSumma.AutoSize = true;
            this.lblSumma.Location = new System.Drawing.Point(353, 525);
            this.lblSumma.Name = "lblSumma";
            this.lblSumma.Size = new System.Drawing.Size(64, 18);
            this.lblSumma.TabIndex = 2;
            this.lblSumma.Text = "Summa:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 801);
            this.Controls.Add(this.lblSumma);
            this.Controls.Add(this.tbxSumma);
            this.Controls.Add(this.btnBulle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Kassasystem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBulle;
        private System.Windows.Forms.TextBox tbxSumma;
        private System.Windows.Forms.Label lblSumma;
    }
}

