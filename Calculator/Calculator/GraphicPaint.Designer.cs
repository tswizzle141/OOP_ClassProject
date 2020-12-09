namespace Calculator
{
    partial class GraphicPaint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GraphicPaint));
            this.btnPrl = new System.Windows.Forms.Button();
            this.btnPrlp = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.mouseStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblNotif = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnVolumn = new System.Windows.Forms.Button();
            this.txtBoxVol = new System.Windows.Forms.TextBox();
            this.btnSur = new System.Windows.Forms.Button();
            this.txtBoxSur = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrl
            // 
            this.btnPrl.Location = new System.Drawing.Point(10, 66);
            this.btnPrl.Name = "btnPrl";
            this.btnPrl.Size = new System.Drawing.Size(94, 27);
            this.btnPrl.TabIndex = 0;
            this.btnPrl.Text = "Parallelogram";
            this.btnPrl.UseVisualStyleBackColor = true;
            this.btnPrl.Click += new System.EventHandler(this.btnPrl_Clicked);
            // 
            // btnPrlp
            // 
            this.btnPrlp.Location = new System.Drawing.Point(122, 66);
            this.btnPrlp.Name = "btnPrlp";
            this.btnPrlp.Size = new System.Drawing.Size(94, 27);
            this.btnPrlp.TabIndex = 0;
            this.btnPrlp.Text = "Parallelopiped";
            this.btnPrlp.UseVisualStyleBackColor = true;
            this.btnPrlp.Click += new System.EventHandler(this.btnPrlp_Clicked);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(866, 111);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(140, 199);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mouseStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 480);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1018, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // mouseStatus
            // 
            this.mouseStatus.Name = "mouseStatus";
            this.mouseStatus.Size = new System.Drawing.Size(52, 17);
            this.mouseStatus.Text = "X: ~ Y: ~";
            // 
            // lblNotif
            // 
            this.lblNotif.AutoSize = true;
            this.lblNotif.Location = new System.Drawing.Point(683, 95);
            this.lblNotif.Name = "lblNotif";
            this.lblNotif.Size = new System.Drawing.Size(0, 13);
            this.lblNotif.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1018, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(224, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(619, 353);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mMove_MouseMove);
            // 
            // btnVolumn
            // 
            this.btnVolumn.Location = new System.Drawing.Point(10, 153);
            this.btnVolumn.Name = "btnVolumn";
            this.btnVolumn.Size = new System.Drawing.Size(75, 23);
            this.btnVolumn.TabIndex = 7;
            this.btnVolumn.Text = "Volumn";
            this.btnVolumn.UseVisualStyleBackColor = true;
            this.btnVolumn.Click += new System.EventHandler(this.btnVol_Click);
            // 
            // txtBoxVol
            // 
            this.txtBoxVol.Location = new System.Drawing.Point(101, 153);
            this.txtBoxVol.Multiline = true;
            this.txtBoxVol.Name = "txtBoxVol";
            this.txtBoxVol.Size = new System.Drawing.Size(115, 23);
            this.txtBoxVol.TabIndex = 8;
            // 
            // btnSur
            // 
            this.btnSur.Location = new System.Drawing.Point(10, 202);
            this.btnSur.Name = "btnSur";
            this.btnSur.Size = new System.Drawing.Size(75, 23);
            this.btnSur.TabIndex = 7;
            this.btnSur.Text = "Surface ";
            this.btnSur.UseVisualStyleBackColor = true;
            this.btnSur.Click += new System.EventHandler(this.btnSur_Click);
            // 
            // txtBoxSur
            // 
            this.txtBoxSur.Location = new System.Drawing.Point(101, 202);
            this.txtBoxSur.Multiline = true;
            this.txtBoxSur.Name = "txtBoxSur";
            this.txtBoxSur.Size = new System.Drawing.Size(115, 23);
            this.txtBoxSur.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "p1",
            "p2",
            "p3",
            "p_1"});
            this.comboBox1.Location = new System.Drawing.Point(866, 349);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(140, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(863, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Point Changed";
            // 
            // GraphicPaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 502);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtBoxSur);
            this.Controls.Add(this.txtBoxVol);
            this.Controls.Add(this.btnSur);
            this.Controls.Add(this.btnVolumn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblNotif);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnPrlp);
            this.Controls.Add(this.btnPrl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GraphicPaint";
            this.Text = "GraphicPaint";
            this.Click += new System.EventHandler(this.GraphicPaint_Click);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mMove_MouseMove);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrl;
        private System.Windows.Forms.Button btnPrlp;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel mouseStatus;
        private System.Windows.Forms.Label lblNotif;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnVolumn;
        private System.Windows.Forms.TextBox txtBoxVol;
        private System.Windows.Forms.Button btnSur;
        private System.Windows.Forms.TextBox txtBoxSur;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
    }
}