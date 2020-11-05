namespace Program
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FemaleRbt = new System.Windows.Forms.RadioButton();
            this.MaleRbt = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.DoBdt = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.CountryCbb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ReadList = new System.Windows.Forms.CheckedListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SportList = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.PlayCb = new System.Windows.Forms.CheckBox();
            this.ListenMusicCb = new System.Windows.Forms.CheckBox();
            this.WatchFilmCb = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TakeInforBtn = new System.Windows.Forms.Button();
            this.CloseFormBtn = new System.Windows.Forms.Button();
            this.InforRtxtB = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin Sinh viên";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FemaleRbt);
            this.groupBox1.Controls.Add(this.MaleRbt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.DoBdt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.CountryCbb);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.NameTxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox1.Location = new System.Drawing.Point(21, 47);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(533, 99);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // FemaleRbt
            // 
            this.FemaleRbt.AutoSize = true;
            this.FemaleRbt.Location = new System.Drawing.Point(461, 66);
            this.FemaleRbt.Margin = new System.Windows.Forms.Padding(2);
            this.FemaleRbt.Name = "FemaleRbt";
            this.FemaleRbt.Size = new System.Drawing.Size(41, 17);
            this.FemaleRbt.TabIndex = 10;
            this.FemaleRbt.TabStop = true;
            this.FemaleRbt.Text = "Nữ";
            this.FemaleRbt.UseVisualStyleBackColor = true;
            // 
            // MaleRbt
            // 
            this.MaleRbt.AutoSize = true;
            this.MaleRbt.Location = new System.Drawing.Point(376, 66);
            this.MaleRbt.Margin = new System.Windows.Forms.Padding(2);
            this.MaleRbt.Name = "MaleRbt";
            this.MaleRbt.Size = new System.Drawing.Size(50, 17);
            this.MaleRbt.TabIndex = 9;
            this.MaleRbt.TabStop = true;
            this.MaleRbt.Text = "Nam";
            this.MaleRbt.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(301, 67);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Giới tính";
            // 
            // DoBdt
            // 
            this.DoBdt.CustomFormat = "dd/mm/yyyy";
            this.DoBdt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DoBdt.Location = new System.Drawing.Point(95, 64);
            this.DoBdt.Margin = new System.Windows.Forms.Padding(2);
            this.DoBdt.Name = "DoBdt";
            this.DoBdt.Size = new System.Drawing.Size(143, 20);
            this.DoBdt.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 67);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ngày sinh";
            // 
            // CountryCbb
            // 
            this.CountryCbb.FormattingEnabled = true;
            this.CountryCbb.Location = new System.Drawing.Point(376, 27);
            this.CountryCbb.Margin = new System.Windows.Forms.Padding(2);
            this.CountryCbb.Name = "CountryCbb";
            this.CountryCbb.Size = new System.Drawing.Size(124, 21);
            this.CountryCbb.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(301, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Quê quán";
            // 
            // NameTxt
            // 
            this.NameTxt.Location = new System.Drawing.Point(95, 26);
            this.NameTxt.Margin = new System.Windows.Forms.Padding(2);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(143, 20);
            this.NameTxt.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ tên";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ReadList);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.SportList);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.PlayCb);
            this.groupBox2.Controls.Add(this.ListenMusicCb);
            this.groupBox2.Controls.Add(this.WatchFilmCb);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.IndianRed;
            this.groupBox2.Location = new System.Drawing.Point(21, 161);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(532, 128);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sở thích";
            // 
            // ReadList
            // 
            this.ReadList.FormattingEnabled = true;
            this.ReadList.Items.AddRange(new object[] {"Truyện tranh", "Tiểu thuyết", "Truyện ngắn", "Thơ"});
            this.ReadList.Location = new System.Drawing.Point(376, 65);
            this.ReadList.Margin = new System.Windows.Forms.Padding(2);
            this.ReadList.Name = "ReadList";
            this.ReadList.Size = new System.Drawing.Size(124, 49);
            this.ReadList.TabIndex = 5;
            this.ReadList.SelectedIndexChanged += new System.EventHandler(this.ReadList_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(332, 65);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Đọc";
            // 
            // SportList
            // 
            this.SportList.FormattingEnabled = true;
            this.SportList.Location = new System.Drawing.Point(95, 65);
            this.SportList.Items.AddRange(new object[] {"Bóng đá", "Cầu lông", "Cờ vua", "Chạy"});
            this.SportList.Margin = new System.Windows.Forms.Padding(2);
            this.SportList.Name = "SportList";
            this.SportList.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.SportList.Size = new System.Drawing.Size(143, 43);
            this.SportList.TabIndex = 4;
            this.SportList.SelectedIndexChanged += new System.EventHandler(this.SportList_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 65);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Thể thao";
            // 
            // PlayCb
            // 
            this.PlayCb.AutoSize = true;
            this.PlayCb.Location = new System.Drawing.Point(430, 25);
            this.PlayCb.Margin = new System.Windows.Forms.Padding(2);
            this.PlayCb.Name = "PlayCb";
            this.PlayCb.Size = new System.Drawing.Size(51, 17);
            this.PlayCb.TabIndex = 8;
            this.PlayCb.Text = "Chơi";
            this.PlayCb.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.PlayCb.UseVisualStyleBackColor = true;
            // 
            // ListenMusicCb
            // 
            this.ListenMusicCb.AutoSize = true;
            this.ListenMusicCb.Location = new System.Drawing.Point(273, 25);
            this.ListenMusicCb.Margin = new System.Windows.Forms.Padding(2);
            this.ListenMusicCb.Name = "ListenMusicCb";
            this.ListenMusicCb.Size = new System.Drawing.Size(88, 17);
            this.ListenMusicCb.TabIndex = 7;
            this.ListenMusicCb.Text = "Nghe nhạc";
            this.ListenMusicCb.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ListenMusicCb.UseVisualStyleBackColor = true;
            // 
            // WatchFilmCb
            // 
            this.WatchFilmCb.AutoSize = true;
            this.WatchFilmCb.Location = new System.Drawing.Point(126, 25);
            this.WatchFilmCb.Margin = new System.Windows.Forms.Padding(2);
            this.WatchFilmCb.Name = "WatchFilmCb";
            this.WatchFilmCb.Size = new System.Drawing.Size(73, 17);
            this.WatchFilmCb.TabIndex = 6;
            this.WatchFilmCb.Text = "Xem film";
            this.WatchFilmCb.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.WatchFilmCb.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 25);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Free Time";
            // 
            // TakeInforBtn
            // 
            this.TakeInforBtn.Location = new System.Drawing.Point(93, 303);
            this.TakeInforBtn.Margin = new System.Windows.Forms.Padding(2);
            this.TakeInforBtn.Name = "TakeInforBtn";
            this.TakeInforBtn.Size = new System.Drawing.Size(145, 25);
            this.TakeInforBtn.TabIndex = 3;
            this.TakeInforBtn.Text = "Lấy thông tin";
            this.TakeInforBtn.UseVisualStyleBackColor = true;
            this.TakeInforBtn.Click += new System.EventHandler(this.TakeInforBtn_Click);
            // 
            // CloseFormBtn
            // 
            this.CloseFormBtn.Location = new System.Drawing.Point(346, 303);
            this.CloseFormBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CloseFormBtn.Name = "CloseFormBtn";
            this.CloseFormBtn.Size = new System.Drawing.Size(145, 25);
            this.CloseFormBtn.TabIndex = 4;
            this.CloseFormBtn.Text = "Đóng Form";
            this.CloseFormBtn.UseVisualStyleBackColor = true;
            this.CloseFormBtn.Click += new System.EventHandler(this.CloseFormBtn_Click);
            // 
            // InforRtxtB
            // 
            this.InforRtxtB.Location = new System.Drawing.Point(22, 341);
            this.InforRtxtB.Margin = new System.Windows.Forms.Padding(2);
            this.InforRtxtB.Name = "InforRtxtB";
            this.InforRtxtB.ShowSelectionMargin = true;
            this.InforRtxtB.Size = new System.Drawing.Size(533, 119);
            this.InforRtxtB.TabIndex = 5;
            this.InforRtxtB.Text = "";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 474);
            this.Controls.Add(this.InforRtxtB);
            this.Controls.Add(this.CloseFormBtn);
            this.Controls.Add(this.TakeInforBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin Sinh viên";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CountryCbb;
        private System.Windows.Forms.DateTimePicker DoBdt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton FemaleRbt;
        private System.Windows.Forms.RadioButton MaleRbt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox ListenMusicCb;
        private System.Windows.Forms.CheckBox WatchFilmCb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox PlayCb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox SportList;
        private System.Windows.Forms.CheckedListBox ReadList;
        private System.Windows.Forms.Button TakeInforBtn;
        private System.Windows.Forms.Button CloseFormBtn;
        private System.Windows.Forms.RichTextBox InforRtxtB;
    }
}