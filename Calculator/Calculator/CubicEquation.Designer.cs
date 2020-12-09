namespace Calculator
{
    partial class CubicEquation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CubicEquation));
            this.rtxtBoxA = new System.Windows.Forms.RichTextBox();
            this.rtxtBoxB = new System.Windows.Forms.RichTextBox();
            this.rtxtBoxC = new System.Windows.Forms.RichTextBox();
            this.rtxtBoxD = new System.Windows.Forms.RichTextBox();
            this.btnSolve = new System.Windows.Forms.Button();
            this.lblNoSol = new System.Windows.Forms.Label();
            this.lblX2 = new System.Windows.Forms.Label();
            this.lblX1 = new System.Windows.Forms.Label();
            this.rtxtBoxX2 = new System.Windows.Forms.RichTextBox();
            this.rtxtBoxX1 = new System.Windows.Forms.RichTextBox();
            this.rtxtBoxX3 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtxtBoxA
            // 
            this.rtxtBoxA.Location = new System.Drawing.Point(12, 12);
            this.rtxtBoxA.Name = "rtxtBoxA";
            this.rtxtBoxA.Size = new System.Drawing.Size(78, 27);
            this.rtxtBoxA.TabIndex = 1;
            this.rtxtBoxA.Text = "";
            this.rtxtBoxA.TextChanged += new System.EventHandler(this.rtxtBoxA_Changed);
            // 
            // rtxtBoxB
            // 
            this.rtxtBoxB.Location = new System.Drawing.Point(105, 12);
            this.rtxtBoxB.Name = "rtxtBoxB";
            this.rtxtBoxB.Size = new System.Drawing.Size(78, 27);
            this.rtxtBoxB.TabIndex = 1;
            this.rtxtBoxB.Text = "";
            this.rtxtBoxB.TextChanged += new System.EventHandler(this.rtxtBoxB_Changed);
            // 
            // rtxtBoxC
            // 
            this.rtxtBoxC.Location = new System.Drawing.Point(199, 12);
            this.rtxtBoxC.Name = "rtxtBoxC";
            this.rtxtBoxC.Size = new System.Drawing.Size(78, 27);
            this.rtxtBoxC.TabIndex = 1;
            this.rtxtBoxC.Text = "";
            this.rtxtBoxC.TextChanged += new System.EventHandler(this.rtxtBoxC_Changed);
            // 
            // rtxtBoxD
            // 
            this.rtxtBoxD.Location = new System.Drawing.Point(294, 12);
            this.rtxtBoxD.Name = "rtxtBoxD";
            this.rtxtBoxD.Size = new System.Drawing.Size(78, 27);
            this.rtxtBoxD.TabIndex = 1;
            this.rtxtBoxD.Text = "";
            this.rtxtBoxD.TextChanged += new System.EventHandler(this.rtxtBoxD_Changed);
            // 
            // btnSolve
            // 
            this.btnSolve.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSolve.Location = new System.Drawing.Point(52, 56);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(86, 32);
            this.btnSolve.TabIndex = 2;
            this.btnSolve.Text = "Solve";
            this.btnSolve.UseVisualStyleBackColor = true;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // lblNoSol
            // 
            this.lblNoSol.AutoSize = true;
            this.lblNoSol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoSol.Location = new System.Drawing.Point(222, 63);
            this.lblNoSol.Name = "lblNoSol";
            this.lblNoSol.Size = new System.Drawing.Size(75, 20);
            this.lblNoSol.TabIndex = 3;
            this.lblNoSol.Text = "Solutions";
            // 
            // lblX2
            // 
            this.lblX2.AutoSize = true;
            this.lblX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX2.Location = new System.Drawing.Point(23, 155);
            this.lblX2.Name = "lblX2";
            this.lblX2.Size = new System.Drawing.Size(46, 20);
            this.lblX2.TabIndex = 6;
            this.lblX2.Text = "X2 = ";
            // 
            // lblX1
            // 
            this.lblX1.AutoSize = true;
            this.lblX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX1.Location = new System.Drawing.Point(24, 112);
            this.lblX1.Name = "lblX1";
            this.lblX1.Size = new System.Drawing.Size(46, 20);
            this.lblX1.TabIndex = 7;
            this.lblX1.Text = "X1 = ";
            // 
            // rtxtBoxX2
            // 
            this.rtxtBoxX2.Location = new System.Drawing.Point(75, 148);
            this.rtxtBoxX2.Name = "rtxtBoxX2";
            this.rtxtBoxX2.Size = new System.Drawing.Size(78, 27);
            this.rtxtBoxX2.TabIndex = 4;
            this.rtxtBoxX2.Text = "";
            // 
            // rtxtBoxX1
            // 
            this.rtxtBoxX1.Location = new System.Drawing.Point(76, 105);
            this.rtxtBoxX1.Name = "rtxtBoxX1";
            this.rtxtBoxX1.Size = new System.Drawing.Size(78, 27);
            this.rtxtBoxX1.TabIndex = 5;
            this.rtxtBoxX1.Text = "";
            // 
            // rtxtBoxX3
            // 
            this.rtxtBoxX3.Location = new System.Drawing.Point(75, 190);
            this.rtxtBoxX3.Name = "rtxtBoxX3";
            this.rtxtBoxX3.Size = new System.Drawing.Size(78, 27);
            this.rtxtBoxX3.TabIndex = 4;
            this.rtxtBoxX3.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "X3 = ";
            // 
            // CubicEquation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 260);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblX2);
            this.Controls.Add(this.lblX1);
            this.Controls.Add(this.rtxtBoxX3);
            this.Controls.Add(this.rtxtBoxX2);
            this.Controls.Add(this.rtxtBoxX1);
            this.Controls.Add(this.lblNoSol);
            this.Controls.Add(this.btnSolve);
            this.Controls.Add(this.rtxtBoxD);
            this.Controls.Add(this.rtxtBoxC);
            this.Controls.Add(this.rtxtBoxB);
            this.Controls.Add(this.rtxtBoxA);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CubicEquation";
            this.Text = "CubicEquation";
            this.Load += new System.EventHandler(this.CubicEquation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtBoxA;
        private System.Windows.Forms.RichTextBox rtxtBoxB;
        private System.Windows.Forms.RichTextBox rtxtBoxC;
        private System.Windows.Forms.RichTextBox rtxtBoxD;
        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.Label lblNoSol;
        private System.Windows.Forms.Label lblX2;
        private System.Windows.Forms.Label lblX1;
        private System.Windows.Forms.RichTextBox rtxtBoxX2;
        private System.Windows.Forms.RichTextBox rtxtBoxX1;
        private System.Windows.Forms.RichTextBox rtxtBoxX3;
        private System.Windows.Forms.Label label1;
    }
}