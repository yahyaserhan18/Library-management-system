namespace LibraryMangmentSystem
{
    partial class viewBorrowBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewBorrowBooks));
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel3 = new Panel();
            label8 = new Label();
            label10 = new Label();
            lbBooksCount = new Label();
            button1 = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnCancel = new Button();
            dataGridView1 = new DataGridView();
            txtSearchBy = new TextBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            cbBooks = new ComboBox();
            txtStudentName = new TextBox();
            dtEnd = new DateTimePicker();
            label2 = new Label();
            dtStart = new DateTimePicker();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            panel1 = new Panel();
            cbSearchBy = new ComboBox();
            btnDeleteAllCellsWithRed = new Button();
            btnBooksDelivered = new Button();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(lbBooksCount);
            panel3.Location = new Point(995, 179);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(5);
            panel3.Size = new Size(135, 39);
            panel3.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(93, 10);
            label8.Name = "label8";
            label8.Size = new Size(43, 20);
            label8.TabIndex = 8;
            label8.Text = "يوجد ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(8, 10);
            label10.Name = "label10";
            label10.Size = new Size(41, 20);
            label10.TabIndex = 10;
            label10.Text = "سجل";
            // 
            // lbBooksCount
            // 
            lbBooksCount.AutoSize = true;
            lbBooksCount.Location = new Point(60, 10);
            lbBooksCount.Name = "lbBooksCount";
            lbBooksCount.Size = new Size(27, 20);
            lbBooksCount.TabIndex = 9;
            lbBooksCount.Text = "---";
            // 
            // button1
            // 
            button1.FlatAppearance.BorderColor = Color.Wheat;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(281, 176);
            button1.Name = "button1";
            button1.Size = new Size(33, 34);
            button1.TabIndex = 17;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.FlatAppearance.MouseDownBackColor = Color.Blue;
            btnUpdate.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Location = new Point(601, 285);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(103, 43);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "حفظ";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.FlatAppearance.CheckedBackColor = Color.FromArgb(255, 128, 128);
            btnDelete.FlatAppearance.MouseDownBackColor = Color.Red;
            btnDelete.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Location = new Point(461, 285);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(103, 43);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "مسح";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCancel
            // 
            btnCancel.FlatAppearance.CheckedBackColor = Color.FromArgb(255, 128, 128);
            btnCancel.FlatAppearance.MouseDownBackColor = Color.Red;
            btnCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Location = new Point(321, 285);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(103, 43);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "الغاء";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(25, 224);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RightToLeft = RightToLeft.Yes;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(0, 0, 192);
            dataGridViewCellStyle2.Padding = new Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = Color.Yellow;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1105, 376);
            dataGridView1.TabIndex = 15;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            // 
            // txtSearchBy
            // 
            txtSearchBy.Location = new Point(320, 176);
            txtSearchBy.Multiline = true;
            txtSearchBy.Name = "txtSearchBy";
            txtSearchBy.Size = new Size(386, 34);
            txtSearchBy.TabIndex = 0;
            txtSearchBy.TextAlign = HorizontalAlignment.Center;
            txtSearchBy.TextChanged += txtBookName_TextChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(243, 156);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Harlow Solid Italic", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(681, 61);
            label1.Name = "label1";
            label1.Size = new Size(231, 35);
            label1.TabIndex = 1;
            label1.Text = "عرض الكتب المستعارة";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(441, -13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(353, 195);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(224, 224, 224);
            panel2.Controls.Add(cbBooks);
            panel2.Controls.Add(txtStudentName);
            panel2.Controls.Add(dtEnd);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(dtStart);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnCancel);
            panel2.Location = new Point(25, 651);
            panel2.Name = "panel2";
            panel2.Size = new Size(1105, 332);
            panel2.TabIndex = 16;
            panel2.Paint += panel2_Paint;
            // 
            // cbBooks
            // 
            cbBooks.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbBooks.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbBooks.Enabled = false;
            cbBooks.FormattingEnabled = true;
            cbBooks.Location = new Point(238, 35);
            cbBooks.Name = "cbBooks";
            cbBooks.Size = new Size(466, 28);
            cbBooks.TabIndex = 22;
            // 
            // txtStudentName
            // 
            txtStudentName.Enabled = false;
            txtStudentName.Location = new Point(238, 90);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(466, 27);
            txtStudentName.TabIndex = 21;
            txtStudentName.TextAlign = HorizontalAlignment.Center;
            // 
            // dtEnd
            // 
            dtEnd.CustomFormat = "yyyy-MM-dd";
            dtEnd.Format = DateTimePickerFormat.Custom;
            dtEnd.Location = new Point(238, 205);
            dtEnd.Name = "dtEnd";
            dtEnd.Size = new Size(466, 27);
            dtEnd.TabIndex = 20;
            dtEnd.Value = new DateTime(2025, 2, 20, 0, 0, 0, 0);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label2.Location = new Point(704, 203);
            label2.Name = "label2";
            label2.Size = new Size(131, 31);
            label2.TabIndex = 19;
            label2.Text = "انتهاء التاريخ";
            // 
            // dtStart
            // 
            dtStart.CustomFormat = "yyyy-MM-dd";
            dtStart.Format = DateTimePickerFormat.Custom;
            dtStart.Location = new Point(238, 151);
            dtStart.Name = "dtStart";
            dtStart.Size = new Size(466, 27);
            dtStart.TabIndex = 18;
            dtStart.Value = new DateTime(2025, 2, 20, 0, 0, 0, 0);
            dtStart.ValueChanged += dtStart_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label5.Location = new Point(728, 146);
            label5.Name = "label5";
            label5.Size = new Size(107, 31);
            label5.TabIndex = 17;
            label5.Text = "بدأ التاريخ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label6.Location = new Point(709, 89);
            label6.Name = "label6";
            label6.Size = new Size(126, 31);
            label6.TabIndex = 16;
            label6.Text = "اسم الطالب";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label7.Location = new Point(710, 32);
            label7.Name = "label7";
            label7.Size = new Size(125, 31);
            label7.TabIndex = 15;
            label7.Text = "اسم الكتاب ";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1139, 159);
            panel1.TabIndex = 12;
            // 
            // cbSearchBy
            // 
            cbSearchBy.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbSearchBy.FormattingEnabled = true;
            cbSearchBy.Items.AddRange(new object[] { "اسم الطالب", "اسم الكتاب" });
            cbSearchBy.Location = new Point(728, 178);
            cbSearchBy.Name = "cbSearchBy";
            cbSearchBy.Size = new Size(114, 35);
            cbSearchBy.TabIndex = 19;
            // 
            // btnDeleteAllCellsWithRed
            // 
            btnDeleteAllCellsWithRed.BackColor = Color.FromArgb(255, 128, 128);
            btnDeleteAllCellsWithRed.Cursor = Cursors.Hand;
            btnDeleteAllCellsWithRed.Location = new Point(883, 608);
            btnDeleteAllCellsWithRed.Name = "btnDeleteAllCellsWithRed";
            btnDeleteAllCellsWithRed.Size = new Size(244, 29);
            btnDeleteAllCellsWithRed.TabIndex = 20;
            btnDeleteAllCellsWithRed.Text = "مسح جميع السجلات  باللون الأحمر";
            btnDeleteAllCellsWithRed.UseVisualStyleBackColor = false;
            btnDeleteAllCellsWithRed.Visible = false;
            btnDeleteAllCellsWithRed.Click += btnDeleteAllCellsWithRed_Click;
            // 
            // btnBooksDelivered
            // 
            btnBooksDelivered.BackColor = Color.FromArgb(255, 128, 128);
            btnBooksDelivered.Location = new Point(367, 608);
            btnBooksDelivered.Name = "btnBooksDelivered";
            btnBooksDelivered.Size = new Size(328, 29);
            btnBooksDelivered.TabIndex = 21;
            btnBooksDelivered.Text = "مسح جميع السجلات التي تم تسليم الكتب فيها";
            btnBooksDelivered.UseVisualStyleBackColor = false;
            btnBooksDelivered.Click += btnBooksDelivered_Click;
            // 
            // viewBorrowBooks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1160, 741);
            Controls.Add(btnBooksDelivered);
            Controls.Add(btnDeleteAllCellsWithRed);
            Controls.Add(cbSearchBy);
            Controls.Add(panel3);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(txtSearchBy);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "viewBorrowBooks";
            Text = "viewBorrowBooks";
            Load += viewBorrowBooks_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel3;
        private Label label8;
        private Label label10;
        private Label lbBooksCount;
        private Button button1;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnCancel;
        private DataGridView dataGridView1;
        private TextBox txtSearchBy;
        private PictureBox pictureBox2;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel panel1;
        private ComboBox cbSearchBy;
        private ComboBox cbBooks;
        private TextBox txtStudentName;
        private DateTimePicker dtEnd;
        private Label label2;
        private DateTimePicker dtStart;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnDeleteAllCellsWithRed;
        private Button btnBooksDelivered;
    }
}