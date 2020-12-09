namespace Calculator
{
    partial class Linear2Equations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Linear2Equations));
            this.txtA1 = new System.Windows.Forms.TextBox();
            this.txtB1 = new System.Windows.Forms.TextBox();
            this.txtC1 = new System.Windows.Forms.TextBox();
            this.txtA2 = new System.Windows.Forms.TextBox();
            this.txtB2 = new System.Windows.Forms.TextBox();
            this.txtC2 = new System.Windows.Forms.TextBox();
            this.btnSolve = new System.Windows.Forms.Button();
            this.labelx = new System.Windows.Forms.Label();
            this.labely = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.lblNoSol = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtA1
            // 
            this.txtA1.Location = new System.Drawing.Point(12, 12);
            this.txtA1.Name = "txtA1";
            this.txtA1.Size = new System.Drawing.Size(61, 20);
            this.txtA1.TabIndex = 0;
            this.txtA1.TextChanged += new System.EventHandler(this.txtA1_Changed);
            // 
            // txtB1
            // 
            this.txtB1.Location = new System.Drawing.Point(89, 12);
            this.txtB1.Name = "txtB1";
            this.txtB1.Size = new System.Drawing.Size(61, 20);
            this.txtB1.TabIndex = 0;
            this.txtB1.TextChanged += new System.EventHandler(this.txtB1_Changed);
            // 
            // txtC1
            // 
            this.txtC1.Location = new System.Drawing.Point(167, 12);
            this.txtC1.Name = "txtC1";
            this.txtC1.Size = new System.Drawing.Size(61, 20);
            this.txtC1.TabIndex = 0;
            this.txtC1.TextChanged += new System.EventHandler(this.txtC1_Changed);
            // 
            // txtA2
            // 
            this.txtA2.Location = new System.Drawing.Point(12, 38);
            this.txtA2.Name = "txtA2";
            this.txtA2.Size = new System.Drawing.Size(61, 20);
            this.txtA2.TabIndex = 0;
            this.txtA2.TextChanged += new System.EventHandler(this.txtA2_Changed);
            // 
            // txtB2
            // 
            this.txtB2.Location = new System.Drawing.Point(89, 38);
            this.txtB2.Name = "txtB2";
            this.txtB2.Size = new System.Drawing.Size(61, 20);
            this.txtB2.TabIndex = 0;
            this.txtB2.TextChanged += new System.EventHandler(this.txtB2_Changed);
            // 
            // txtC2
            // 
            this.txtC2.Location = new System.Drawing.Point(167, 38);
            this.txtC2.Name = "txtC2";
            this.txtC2.Size = new System.Drawing.Size(61, 20);
            this.txtC2.TabIndex = 0;
            this.txtC2.TextChanged += new System.EventHandler(this.txtC2_Changed);
            // 
            // btnSolve
            // 
            this.btnSolve.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSolve.Location = new System.Drawing.Point(38, 73);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(88, 32);
            this.btnSolve.TabIndex = 1;
            this.btnSolve.Text = "Solve";
            this.btnSolve.UseVisualStyleBackColor = true;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // labelx
            // 
            this.labelx.AutoSize = true;
            this.labelx.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelx.Location = new System.Drawing.Point(21, 131);
            this.labelx.Name = "labelx";
            this.labelx.Size = new System.Drawing.Size(36, 18);
            this.labelx.TabIndex = 2;
            this.labelx.Text = "x = ";
            this.labelx.Click += new System.EventHandler(this.label1_Click);
            // 
            // labely
            // 
            this.labely.AutoSize = true;
            this.labely.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labely.Location = new System.Drawing.Point(164, 131);
            this.labely.Name = "labely";
            this.labely.Size = new System.Drawing.Size(36, 18);
            this.labely.TabIndex = 2;
            this.labely.Text = "y = ";
            this.labely.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(63, 129);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(61, 20);
            this.txtX.TabIndex = 0;
            this.txtX.TextChanged += new System.EventHandler(this.txtX_Changed);
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(206, 129);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(61, 20);
            this.txtY.TabIndex = 0;
            this.txtY.TextChanged += new System.EventHandler(this.txtY_Changed);
            // 
            // lblNoSol
            // 
            this.lblNoSol.AutoSize = true;
            this.lblNoSol.Location = new System.Drawing.Point(164, 85);
            this.lblNoSol.Name = "lblNoSol";
            this.lblNoSol.Size = new System.Drawing.Size(50, 13);
            this.lblNoSol.TabIndex = 3;
            this.lblNoSol.Text = "Solutions";
            this.lblNoSol.Click += new System.EventHandler(this.lblNoSol_Click);
            // 
            // Linear2Equations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 198);
            this.Controls.Add(this.lblNoSol);
            this.Controls.Add(this.labely);
            this.Controls.Add(this.labelx);
            this.Controls.Add(this.btnSolve);
            this.Controls.Add(this.txtC2);
            this.Controls.Add(this.txtC1);
            this.Controls.Add(this.txtB2);
            this.Controls.Add(this.txtA2);
            this.Controls.Add(this.txtB1);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.txtA1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Linear2Equations";
            this.Text = "2LinearEquations";
            this.Load += new System.EventHandler(this._2LinearEquations_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtA1;
        private System.Windows.Forms.TextBox txtB1;
        private System.Windows.Forms.TextBox txtC1;
        private System.Windows.Forms.TextBox txtA2;
        private System.Windows.Forms.TextBox txtB2;
        private System.Windows.Forms.TextBox txtC2;
        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.Label labelx;
        private System.Windows.Forms.Label labely;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.Label lblNoSol;
    }
}