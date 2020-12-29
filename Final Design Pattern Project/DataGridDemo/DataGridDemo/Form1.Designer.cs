namespace DataGridDemo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.lblVND = new System.Windows.Forms.Label();
            this.lblDollar = new System.Windows.Forms.Label();
            this.lblEuro = new System.Windows.Forms.Label();
            this.lblRMB = new System.Windows.Forms.Label();
            this.rtbVND = new System.Windows.Forms.RichTextBox();
            this.rtbDollar = new System.Windows.Forms.RichTextBox();
            this.rtbEuro = new System.Windows.Forms.RichTextBox();
            this.rtbRMB = new System.Windows.Forms.RichTextBox();
            this.lblWon = new System.Windows.Forms.Label();
            this.rtbWon = new System.Windows.Forms.RichTextBox();
            this.lblProduct = new System.Windows.Forms.Label();
            this.rtbProduct = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(167, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(754, 394);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(167, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Clicked);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(248, 12);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Clicked);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(329, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Clicked);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(410, 12);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 1;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Clicked);
            // 
            // lblVND
            // 
            this.lblVND.AutoSize = true;
            this.lblVND.Location = new System.Drawing.Point(9, 88);
            this.lblVND.Name = "lblVND";
            this.lblVND.Size = new System.Drawing.Size(30, 13);
            this.lblVND.TabIndex = 2;
            this.lblVND.Text = "VND";
            // 
            // lblDollar
            // 
            this.lblDollar.AutoSize = true;
            this.lblDollar.Location = new System.Drawing.Point(9, 137);
            this.lblDollar.Name = "lblDollar";
            this.lblDollar.Size = new System.Drawing.Size(13, 13);
            this.lblDollar.TabIndex = 2;
            this.lblDollar.Text = "$";
            // 
            // lblEuro
            // 
            this.lblEuro.AutoSize = true;
            this.lblEuro.Location = new System.Drawing.Point(9, 192);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Size = new System.Drawing.Size(29, 13);
            this.lblEuro.TabIndex = 2;
            this.lblEuro.Text = "Euro";
            // 
            // lblRMB
            // 
            this.lblRMB.AutoSize = true;
            this.lblRMB.Location = new System.Drawing.Point(9, 249);
            this.lblRMB.Name = "lblRMB";
            this.lblRMB.Size = new System.Drawing.Size(31, 13);
            this.lblRMB.TabIndex = 2;
            this.lblRMB.Text = "RMB";
            // 
            // rtbVND
            // 
            this.rtbVND.Location = new System.Drawing.Point(12, 104);
            this.rtbVND.Name = "rtbVND";
            this.rtbVND.Size = new System.Drawing.Size(145, 30);
            this.rtbVND.TabIndex = 3;
            this.rtbVND.Text = "";
            this.rtbVND.TextChanged += new System.EventHandler(this.rtbVND_Changed);
            // 
            // rtbDollar
            // 
            this.rtbDollar.Location = new System.Drawing.Point(12, 153);
            this.rtbDollar.Name = "rtbDollar";
            this.rtbDollar.Size = new System.Drawing.Size(145, 30);
            this.rtbDollar.TabIndex = 3;
            this.rtbDollar.Text = "";
            this.rtbDollar.TextChanged += new System.EventHandler(this.rtbDollar_Changed);
            // 
            // rtbEuro
            // 
            this.rtbEuro.Location = new System.Drawing.Point(12, 208);
            this.rtbEuro.Name = "rtbEuro";
            this.rtbEuro.Size = new System.Drawing.Size(145, 30);
            this.rtbEuro.TabIndex = 3;
            this.rtbEuro.Text = "";
            this.rtbEuro.TextChanged += new System.EventHandler(this.rtbEuro_Changed);
            // 
            // rtbRMB
            // 
            this.rtbRMB.Location = new System.Drawing.Point(12, 265);
            this.rtbRMB.Name = "rtbRMB";
            this.rtbRMB.Size = new System.Drawing.Size(145, 30);
            this.rtbRMB.TabIndex = 3;
            this.rtbRMB.Text = "";
            this.rtbRMB.TextChanged += new System.EventHandler(this.rtbRMB_Changed);
            // 
            // lblWon
            // 
            this.lblWon.AutoSize = true;
            this.lblWon.Location = new System.Drawing.Point(9, 302);
            this.lblWon.Name = "lblWon";
            this.lblWon.Size = new System.Drawing.Size(30, 13);
            this.lblWon.TabIndex = 2;
            this.lblWon.Text = "Won";
            // 
            // rtbWon
            // 
            this.rtbWon.Location = new System.Drawing.Point(12, 318);
            this.rtbWon.Name = "rtbWon";
            this.rtbWon.Size = new System.Drawing.Size(145, 30);
            this.rtbWon.TabIndex = 3;
            this.rtbWon.Text = "";
            this.rtbWon.TextChanged += new System.EventHandler(this.rtbWon_Changed);
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(9, 39);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(44, 13);
            this.lblProduct.TabIndex = 2;
            this.lblProduct.Text = "Product";
            // 
            // rtbProduct
            // 
            this.rtbProduct.Location = new System.Drawing.Point(12, 55);
            this.rtbProduct.Name = "rtbProduct";
            this.rtbProduct.Size = new System.Drawing.Size(145, 30);
            this.rtbProduct.TabIndex = 3;
            this.rtbProduct.Text = "";
            this.rtbProduct.TextChanged += new System.EventHandler(this.rtbProduct_Changed);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 447);
            this.Controls.Add(this.rtbWon);
            this.Controls.Add(this.rtbRMB);
            this.Controls.Add(this.rtbEuro);
            this.Controls.Add(this.rtbDollar);
            this.Controls.Add(this.lblWon);
            this.Controls.Add(this.rtbProduct);
            this.Controls.Add(this.rtbVND);
            this.Controls.Add(this.lblRMB);
            this.Controls.Add(this.lblEuro);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.lblDollar);
            this.Controls.Add(this.lblVND);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Number Format Data-grid";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label lblVND;
        private System.Windows.Forms.Label lblDollar;
        private System.Windows.Forms.Label lblEuro;
        private System.Windows.Forms.Label lblRMB;
        private System.Windows.Forms.RichTextBox rtbVND;
        private System.Windows.Forms.RichTextBox rtbDollar;
        private System.Windows.Forms.RichTextBox rtbEuro;
        private System.Windows.Forms.RichTextBox rtbRMB;
        private System.Windows.Forms.Label lblWon;
        private System.Windows.Forms.RichTextBox rtbWon;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.RichTextBox rtbProduct;
    }
}

