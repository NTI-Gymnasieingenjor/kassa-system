namespace kassaSystem
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KassaSystem));
            this.buttonBulle = new System.Windows.Forms.Button();
            this.textboxSumma = new System.Windows.Forms.TextBox();
            this.labelSumma = new System.Windows.Forms.Label();
            this.buttonNollstall = new System.Windows.Forms.Button();
            this.buttonKaffe = new System.Windows.Forms.Button();
            this.buttonKorv = new System.Windows.Forms.Button();
            this.buttonLask = new System.Windows.Forms.Button();
            this.buttonTaBort = new System.Windows.Forms.Button();
            this.buttonTaBort1x = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonBetala = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBulle
            // 
            this.buttonBulle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBulle.Location = new System.Drawing.Point(455, 164);
            this.buttonBulle.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBulle.Name = "buttonBulle";
            this.buttonBulle.Size = new System.Drawing.Size(365, 167);
            this.buttonBulle.TabIndex = 3;
            this.buttonBulle.Text = "Bulle";
            this.buttonBulle.UseVisualStyleBackColor = true;
            this.buttonBulle.Click += new System.EventHandler(this.button_Click);
            // 
            // textboxSumma
            // 
            this.textboxSumma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxSumma.Location = new System.Drawing.Point(910, 679);
            this.textboxSumma.Name = "textboxSumma";
            this.textboxSumma.ReadOnly = true;
            this.textboxSumma.Size = new System.Drawing.Size(246, 29);
            this.textboxSumma.TabIndex = 9;
            this.textboxSumma.Text = "0";
            // 
            // labelSumma
            // 
            this.labelSumma.AutoSize = true;
            this.labelSumma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSumma.Location = new System.Drawing.Point(906, 652);
            this.labelSumma.Name = "labelSumma";
            this.labelSumma.Size = new System.Drawing.Size(80, 24);
            this.labelSumma.TabIndex = 0;
            this.labelSumma.Text = "Summa:";
            // 
            // buttonNollstall
            // 
            this.buttonNollstall.Location = new System.Drawing.Point(1036, 714);
            this.buttonNollstall.Name = "buttonNollstall";
            this.buttonNollstall.Size = new System.Drawing.Size(120, 29);
            this.buttonNollstall.TabIndex = 8;
            this.buttonNollstall.Text = "Nollställ";
            this.buttonNollstall.UseVisualStyleBackColor = true;
            this.buttonNollstall.Click += new System.EventHandler(this.buttonNollstall_Click);
            // 
            // buttonKaffe
            // 
            this.buttonKaffe.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKaffe.Location = new System.Drawing.Point(455, 335);
            this.buttonKaffe.Margin = new System.Windows.Forms.Padding(4);
            this.buttonKaffe.Name = "buttonKaffe";
            this.buttonKaffe.Size = new System.Drawing.Size(365, 167);
            this.buttonKaffe.TabIndex = 5;
            this.buttonKaffe.Text = "Kaffe";
            this.buttonKaffe.UseVisualStyleBackColor = true;
            this.buttonKaffe.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonKorv
            // 
            this.buttonKorv.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKorv.Location = new System.Drawing.Point(82, 164);
            this.buttonKorv.Margin = new System.Windows.Forms.Padding(4);
            this.buttonKorv.Name = "buttonKorv";
            this.buttonKorv.Size = new System.Drawing.Size(365, 167);
            this.buttonKorv.TabIndex = 2;
            this.buttonKorv.Text = "Korv";
            this.buttonKorv.UseVisualStyleBackColor = true;
            this.buttonKorv.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonLask
            // 
            this.buttonLask.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLask.Location = new System.Drawing.Point(82, 335);
            this.buttonLask.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLask.Name = "buttonLask";
            this.buttonLask.Size = new System.Drawing.Size(365, 167);
            this.buttonLask.TabIndex = 4;
            this.buttonLask.Text = "Läsk";
            this.buttonLask.UseVisualStyleBackColor = true;
            this.buttonLask.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonTaBort
            // 
            this.buttonTaBort.Enabled = false;
            this.buttonTaBort.Location = new System.Drawing.Point(1036, 594);
            this.buttonTaBort.Name = "buttonTaBort";
            this.buttonTaBort.Size = new System.Drawing.Size(120, 32);
            this.buttonTaBort.TabIndex = 7;
            this.buttonTaBort.Text = "Ta bort produkt";
            this.buttonTaBort.UseVisualStyleBackColor = true;
            this.buttonTaBort.Click += new System.EventHandler(this.buttonTaBort_Click);
            // 
            // buttonTaBort1x
            // 
            this.buttonTaBort1x.Enabled = false;
            this.buttonTaBort1x.Location = new System.Drawing.Point(910, 594);
            this.buttonTaBort1x.Name = "buttonTaBort1x";
            this.buttonTaBort1x.Size = new System.Drawing.Size(120, 32);
            this.buttonTaBort1x.TabIndex = 6;
            this.buttonTaBort1x.Text = "Ta bort 1x";
            this.buttonTaBort1x.UseVisualStyleBackColor = true;
            this.buttonTaBort1x.Click += new System.EventHandler(this.buttonTaBort1x_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnProduct,
            this.ColumnCount,
            this.ColumnPrice});
            this.dataGridView1.Location = new System.Drawing.Point(910, 44);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(246, 543);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // ColumnProduct
            // 
            this.ColumnProduct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnProduct.FillWeight = 50F;
            this.ColumnProduct.HeaderText = "Product";
            this.ColumnProduct.Name = "ColumnProduct";
            this.ColumnProduct.ReadOnly = true;
            this.ColumnProduct.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnProduct.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnCount
            // 
            this.ColumnCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnCount.FillWeight = 25F;
            this.ColumnCount.HeaderText = "ProductCount";
            this.ColumnCount.Name = "ColumnCount";
            this.ColumnCount.ReadOnly = true;
            // 
            // ColumnPrice
            // 
            this.ColumnPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnPrice.FillWeight = 25F;
            this.ColumnPrice.HeaderText = "Price";
            this.ColumnPrice.Name = "ColumnPrice";
            this.ColumnPrice.ReadOnly = true;
            // 
            // buttonBetala
            // 
            this.buttonBetala.Location = new System.Drawing.Point(910, 714);
            this.buttonBetala.Name = "buttonBetala";
            this.buttonBetala.Size = new System.Drawing.Size(120, 29);
            this.buttonBetala.TabIndex = 10;
            this.buttonBetala.Text = "Betala";
            this.buttonBetala.UseVisualStyleBackColor = true;
            this.buttonBetala.Click += new System.EventHandler(this.buttonNollstall_Click);
            // 
            // KassaSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 750);
            this.Controls.Add(this.buttonBetala);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonTaBort1x);
            this.Controls.Add(this.buttonTaBort);
            this.Controls.Add(this.buttonLask);
            this.Controls.Add(this.buttonKorv);
            this.Controls.Add(this.buttonKaffe);
            this.Controls.Add(this.buttonNollstall);
            this.Controls.Add(this.labelSumma);
            this.Controls.Add(this.textboxSumma);
            this.Controls.Add(this.buttonBulle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "KassaSystem";
            this.Text = "Kassasystem";
            this.Load += new System.EventHandler(this.KassaSystem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBulle;
        private System.Windows.Forms.TextBox textboxSumma;
        private System.Windows.Forms.Label labelSumma;
        private System.Windows.Forms.Button buttonNollstall;
        private System.Windows.Forms.Button buttonKaffe;
        private System.Windows.Forms.Button buttonKorv;
        private System.Windows.Forms.Button buttonLask;
        private System.Windows.Forms.Button buttonTaBort;
        private System.Windows.Forms.Button buttonTaBort1x;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrice;
        private System.Windows.Forms.Button buttonBetala;
    }
}

