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
            this.lblDecNum = new System.Windows.Forms.Label();
            this.lblBinNum = new System.Windows.Forms.Label();
            this.lblOctNum = new System.Windows.Forms.Label();
            this.lblHexNum = new System.Windows.Forms.Label();
            this.rtbDecNum = new System.Windows.Forms.RichTextBox();
            this.rtbBinNum = new System.Windows.Forms.RichTextBox();
            this.rtbOctNum = new System.Windows.Forms.RichTextBox();
            this.rtbHexNum = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(167, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(438, 307);
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
            // lblDecNum
            // 
            this.lblDecNum.AutoSize = true;
            this.lblDecNum.Location = new System.Drawing.Point(3, 41);
            this.lblDecNum.Name = "lblDecNum";
            this.lblDecNum.Size = new System.Drawing.Size(85, 13);
            this.lblDecNum.TabIndex = 2;
            this.lblDecNum.Text = "Decimal Number";
            // 
            // lblBinNum
            // 
            this.lblBinNum.AutoSize = true;
            this.lblBinNum.Location = new System.Drawing.Point(3, 90);
            this.lblBinNum.Name = "lblBinNum";
            this.lblBinNum.Size = new System.Drawing.Size(76, 13);
            this.lblBinNum.TabIndex = 2;
            this.lblBinNum.Text = "Binary Number";
            // 
            // lblOctNum
            // 
            this.lblOctNum.AutoSize = true;
            this.lblOctNum.Location = new System.Drawing.Point(3, 145);
            this.lblOctNum.Name = "lblOctNum";
            this.lblOctNum.Size = new System.Drawing.Size(72, 13);
            this.lblOctNum.TabIndex = 2;
            this.lblOctNum.Text = "Octal Number";
            // 
            // lblHexNum
            // 
            this.lblHexNum.AutoSize = true;
            this.lblHexNum.Location = new System.Drawing.Point(3, 202);
            this.lblHexNum.Name = "lblHexNum";
            this.lblHexNum.Size = new System.Drawing.Size(72, 13);
            this.lblHexNum.TabIndex = 2;
            this.lblHexNum.Text = "Hexa Number";
            // 
            // rtbDecNum
            // 
            this.rtbDecNum.Location = new System.Drawing.Point(6, 57);
            this.rtbDecNum.Name = "rtbDecNum";
            this.rtbDecNum.Size = new System.Drawing.Size(145, 30);
            this.rtbDecNum.TabIndex = 3;
            this.rtbDecNum.Text = "";
            this.rtbDecNum.TextChanged += new System.EventHandler(this.rtbDecNum_Changed);
            // 
            // rtbBinNum
            // 
            this.rtbBinNum.Location = new System.Drawing.Point(6, 106);
            this.rtbBinNum.Name = "rtbBinNum";
            this.rtbBinNum.Size = new System.Drawing.Size(145, 30);
            this.rtbBinNum.TabIndex = 3;
            this.rtbBinNum.Text = "";
            this.rtbBinNum.TextChanged += new System.EventHandler(this.rtbBinNum_Changed);
            // 
            // rtbOctNum
            // 
            this.rtbOctNum.Location = new System.Drawing.Point(6, 161);
            this.rtbOctNum.Name = "rtbOctNum";
            this.rtbOctNum.Size = new System.Drawing.Size(145, 30);
            this.rtbOctNum.TabIndex = 3;
            this.rtbOctNum.Text = "";
            this.rtbOctNum.TextChanged += new System.EventHandler(this.rtbOct_Changed);
            // 
            // rtbHexNum
            // 
            this.rtbHexNum.Location = new System.Drawing.Point(6, 218);
            this.rtbHexNum.Name = "rtbHexNum";
            this.rtbHexNum.Size = new System.Drawing.Size(145, 30);
            this.rtbHexNum.TabIndex = 3;
            this.rtbHexNum.Text = "";
            this.rtbHexNum.TextChanged += new System.EventHandler(this.rtbHexNum_Changed);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 360);
            this.Controls.Add(this.rtbHexNum);
            this.Controls.Add(this.rtbOctNum);
            this.Controls.Add(this.rtbBinNum);
            this.Controls.Add(this.rtbDecNum);
            this.Controls.Add(this.lblHexNum);
            this.Controls.Add(this.lblOctNum);
            this.Controls.Add(this.lblBinNum);
            this.Controls.Add(this.lblDecNum);
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
        private System.Windows.Forms.Label lblDecNum;
        private System.Windows.Forms.Label lblBinNum;
        private System.Windows.Forms.Label lblOctNum;
        private System.Windows.Forms.Label lblHexNum;
        private System.Windows.Forms.RichTextBox rtbDecNum;
        private System.Windows.Forms.RichTextBox rtbBinNum;
        private System.Windows.Forms.RichTextBox rtbOctNum;
        private System.Windows.Forms.RichTextBox rtbHexNum;
    }
}

