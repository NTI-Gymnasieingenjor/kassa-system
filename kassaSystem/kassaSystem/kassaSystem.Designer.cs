﻿namespace kassaSystem
{
    partial class KassaSystem
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
            this.buttonBulle = new System.Windows.Forms.Button();
            this.textboxSumma = new System.Windows.Forms.TextBox();
            this.lblSumma = new System.Windows.Forms.Label();
            this.buttonNollstall = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBulle
            // 
            this.buttonBulle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBulle.Location = new System.Drawing.Point(356, 180);
            this.buttonBulle.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBulle.Name = "buttonBulle";
            this.buttonBulle.Size = new System.Drawing.Size(737, 320);
            this.buttonBulle.TabIndex = 0;
            this.buttonBulle.Text = "Bulle";
            this.buttonBulle.UseVisualStyleBackColor = true;
            this.buttonBulle.Click += new System.EventHandler(this.buttonBulle_Click);
            // 
            // textboxSumma
            // 
            this.textboxSumma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxSumma.Location = new System.Drawing.Point(356, 546);
            this.textboxSumma.Name = "textboxSumma";
            this.textboxSumma.Size = new System.Drawing.Size(596, 29);
            this.textboxSumma.TabIndex = 1;
            this.textboxSumma.Text = "0";
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
            // buttonNollstall
            // 
            this.buttonNollstall.Location = new System.Drawing.Point(958, 546);
            this.buttonNollstall.Name = "buttonNollstall";
            this.buttonNollstall.Size = new System.Drawing.Size(135, 29);
            this.buttonNollstall.TabIndex = 3;
            this.buttonNollstall.Text = "Nollställ";
            this.buttonNollstall.UseVisualStyleBackColor = true;
            this.buttonNollstall.Click += new System.EventHandler(this.buttonNollstall_Click);
            // 
            // KassaSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 801);
            this.Controls.Add(this.buttonNollstall);
            this.Controls.Add(this.lblSumma);
            this.Controls.Add(this.textboxSumma);
            this.Controls.Add(this.buttonBulle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "KassaSystem";
            this.Text = "Kassasystem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBulle;
        private System.Windows.Forms.TextBox textboxSumma;
        private System.Windows.Forms.Label lblSumma;
        private System.Windows.Forms.Button buttonNollstall;
    }
}
