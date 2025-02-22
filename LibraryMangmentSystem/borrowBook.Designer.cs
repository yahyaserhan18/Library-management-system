namespace LibraryMangmentSystem
{
    partial class borrowBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(borrowBook));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            cbBookLang = new ComboBox();
            ndBookCounter = new NumericUpDown();
            btnCancel = new Button();
            btnSave = new Button();
            txtBookName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            panel3 = new Panel();
            cbBooks = new ComboBox();
            txtStudentName = new TextBox();
            dtEnd = new DateTimePicker();
            label8 = new Label();
            dtStart = new DateTimePicker();
            button1 = new Button();
            button2 = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ndBookCounter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(370, 548);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Wheat;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(370, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(668, 77);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(255, 192, 128);
            panel2.Controls.Add(cbBookLang);
            panel2.Controls.Add(ndBookCounter);
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(btnSave);
            panel2.Controls.Add(txtBookName);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(0, 76);
            panel2.Name = "panel2";
            panel2.Size = new Size(356, 0);
            panel2.TabIndex = 3;
            // 
            // cbBookLang
            // 
            cbBookLang.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBookLang.FormattingEnabled = true;
            cbBookLang.Items.AddRange(new object[] { "عربي", "تركي", "انكليزي", "ألماني", "فرنسي" });
            cbBookLang.Location = new Point(27, 204);
            cbBookLang.Name = "cbBookLang";
            cbBookLang.Size = new Size(466, 28);
            cbBookLang.TabIndex = 9;
            cbBookLang.UseWaitCursor = true;
            // 
            // ndBookCounter
            // 
            ndBookCounter.Location = new Point(27, 142);
            ndBookCounter.Name = "ndBookCounter";
            ndBookCounter.Size = new Size(466, 27);
            ndBookCounter.TabIndex = 8;
            ndBookCounter.TextAlign = HorizontalAlignment.Center;
            // 
            // btnCancel
            // 
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            btnCancel.Location = new Point(107, 296);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(124, 50);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "إلغاء";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            btnSave.Location = new Point(283, 296);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(124, 50);
            btnSave.TabIndex = 6;
            btnSave.Text = "حفظ";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(27, 80);
            txtBookName.Multiline = true;
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(466, 34);
            txtBookName.TabIndex = 3;
            txtBookName.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label4.Location = new Point(498, 204);
            label4.Name = "label4";
            label4.Size = new Size(126, 31);
            label4.TabIndex = 2;
            label4.Text = " لغة الكتاب ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label3.Location = new Point(501, 142);
            label3.Name = "label3";
            label3.Size = new Size(123, 31);
            label3.TabIndex = 1;
            label3.Text = " عدد النسخ ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label2.Location = new Point(499, 83);
            label2.Name = "label2";
            label2.Size = new Size(125, 31);
            label2.TabIndex = 0;
            label2.Text = "اسم الكتاب ";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(116, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(106, 70);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Goudy Stout", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(240, 9);
            label1.Name = "label1";
            label1.Size = new Size(234, 64);
            label1.TabIndex = 0;
            label1.Text = "أستعر كتاب";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 192, 128);
            panel3.Controls.Add(cbBooks);
            panel3.Controls.Add(txtStudentName);
            panel3.Controls.Add(dtEnd);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(dtStart);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label7);
            panel3.Location = new Point(370, 76);
            panel3.Name = "panel3";
            panel3.Size = new Size(668, 472);
            panel3.TabIndex = 3;
            panel3.Paint += panel3_Paint;
            // 
            // cbBooks
            // 
            cbBooks.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbBooks.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbBooks.FormattingEnabled = true;
            cbBooks.Location = new Point(27, 86);
            cbBooks.Name = "cbBooks";
            cbBooks.Size = new Size(466, 28);
            cbBooks.TabIndex = 12;
            // 
            // txtStudentName
            // 
            txtStudentName.Location = new Point(27, 141);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(466, 27);
            txtStudentName.TabIndex = 11;
            txtStudentName.TextAlign = HorizontalAlignment.Center;
            // 
            // dtEnd
            // 
            dtEnd.CustomFormat = "yyyy-MM-dd";
            dtEnd.Format = DateTimePickerFormat.Custom;
            dtEnd.Location = new Point(27, 256);
            dtEnd.Name = "dtEnd";
            dtEnd.Size = new Size(466, 27);
            dtEnd.TabIndex = 10;
            dtEnd.Value = new DateTime(2025, 2, 20, 0, 0, 0, 0);
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label8.Location = new Point(493, 254);
            label8.Name = "label8";
            label8.Size = new Size(131, 31);
            label8.TabIndex = 9;
            label8.Text = "انتهاء التاريخ";
            // 
            // dtStart
            // 
            dtStart.CustomFormat = "yyyy-MM-dd";
            dtStart.Format = DateTimePickerFormat.Custom;
            dtStart.Location = new Point(27, 202);
            dtStart.Name = "dtStart";
            dtStart.Size = new Size(466, 27);
            dtStart.TabIndex = 8;
            dtStart.Value = new DateTime(2025, 2, 20, 0, 0, 0, 0);
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            button1.Location = new Point(153, 352);
            button1.Name = "button1";
            button1.Size = new Size(124, 50);
            button1.TabIndex = 7;
            button1.Text = "إلغاء";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            button2.Location = new Point(329, 352);
            button2.Name = "button2";
            button2.Size = new Size(124, 50);
            button2.TabIndex = 6;
            button2.Text = "حفظ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label5.Location = new Point(517, 197);
            label5.Name = "label5";
            label5.Size = new Size(107, 31);
            label5.TabIndex = 2;
            label5.Text = "بدأ التاريخ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label6.Location = new Point(498, 140);
            label6.Name = "label6";
            label6.Size = new Size(126, 31);
            label6.TabIndex = 1;
            label6.Text = "اسم الطالب";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label7.Location = new Point(499, 83);
            label7.Name = "label7";
            label7.Size = new Size(125, 31);
            label7.TabIndex = 0;
            label7.Text = "اسم الكتاب ";
            // 
            // borrowBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1038, 548);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(1056, 595);
            MinimumSize = new Size(1056, 595);
            Name = "borrowBook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Borrow book";
            Load += borrowBook_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ndBookCounter).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Label label1;
        private Panel panel2;
        private ComboBox cbBookLang;
        private NumericUpDown ndBookCounter;
        private Button btnCancel;
        private Button btnSave;
        private TextBox txtBookName;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel panel3;
        private Button button1;
        private Button button2;
        private Label label5;
        private Label label6;
        private Label label7;
        private DateTimePicker dtStart;
        private TextBox txtStudentName;
        private DateTimePicker dtEnd;
        private Label label8;
        private ComboBox cbBooks;
    }
}