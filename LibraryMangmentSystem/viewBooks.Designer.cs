namespace LibraryMangmentSystem
{
    partial class viewBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewBooks));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnUpload = new Button();
            label2 = new Label();
            txtBookName = new TextBox();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnCancel = new Button();
            cbBookLang = new ComboBox();
            ndAvailableBookCount = new NumericUpDown();
            ndBookCounter = new NumericUpDown();
            txtBookNameForChange = new TextBox();
            txtBookId = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            button1 = new Button();
            label8 = new Label();
            lbBooksCount = new Label();
            label10 = new Label();
            panel3 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ndAvailableBookCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ndBookCounter).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
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
            panel1.Size = new Size(1143, 159);
            panel1.TabIndex = 0;
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
            label1.Font = new Font("Harlow Solid Italic", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(681, 61);
            label1.Name = "label1";
            label1.Size = new Size(164, 43);
            label1.TabIndex = 1;
            label1.Text = "عرض الكتب";
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
            // btnUpload
            // 
            btnUpload.BackColor = Color.FromArgb(255, 128, 128);
            btnUpload.Cursor = Cursors.Hand;
            btnUpload.FlatStyle = FlatStyle.Popup;
            btnUpload.Location = new Point(384, 615);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(393, 29);
            btnUpload.TabIndex = 12;
            btnUpload.Text = "  excel  اضغط هنا لتحميل قاعدة البيانات كملف  ";
            btnUpload.UseVisualStyleBackColor = false;
            btnUpload.Click += btnUpload_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label2.Location = new Point(710, 185);
            label2.Name = "label2";
            label2.Size = new Size(125, 31);
            label2.TabIndex = 1;
            label2.Text = "اسم الكتاب ";
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(318, 182);
            txtBookName.Multiline = true;
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(386, 34);
            txtBookName.TabIndex = 2;
            txtBookName.TextAlign = HorizontalAlignment.Center;
            txtBookName.TextChanged += txtBookName_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(23, 233);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RightToLeft = RightToLeft.Yes;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(0, 0, 192);
            dataGridViewCellStyle1.Padding = new Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = Color.Yellow;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1105, 376);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(224, 224, 224);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(cbBookLang);
            panel2.Controls.Add(ndAvailableBookCount);
            panel2.Controls.Add(ndBookCounter);
            panel2.Controls.Add(txtBookNameForChange);
            panel2.Controls.Add(txtBookId);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(23, 657);
            panel2.Name = "panel2";
            panel2.Size = new Size(1105, 332);
            panel2.TabIndex = 6;
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
            // cbBookLang
            // 
            cbBookLang.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBookLang.FormattingEnabled = true;
            cbBookLang.Items.AddRange(new object[] { "عربي", "تركي", "انكليزي", "ألماني", "فرنسي" });
            cbBookLang.Location = new Point(547, 217);
            cbBookLang.Name = "cbBookLang";
            cbBookLang.Size = new Size(384, 28);
            cbBookLang.TabIndex = 11;
            cbBookLang.UseWaitCursor = true;
            // 
            // ndAvailableBookCount
            // 
            ndAvailableBookCount.Location = new Point(23, 135);
            ndAvailableBookCount.Name = "ndAvailableBookCount";
            ndAvailableBookCount.Size = new Size(241, 27);
            ndAvailableBookCount.TabIndex = 10;
            ndAvailableBookCount.TextAlign = HorizontalAlignment.Center;
            // 
            // ndBookCounter
            // 
            ndBookCounter.Location = new Point(23, 58);
            ndBookCounter.Name = "ndBookCounter";
            ndBookCounter.Size = new Size(241, 27);
            ndBookCounter.TabIndex = 9;
            ndBookCounter.TextAlign = HorizontalAlignment.Center;
            // 
            // txtBookNameForChange
            // 
            txtBookNameForChange.Location = new Point(547, 128);
            txtBookNameForChange.Multiline = true;
            txtBookNameForChange.Name = "txtBookNameForChange";
            txtBookNameForChange.Size = new Size(384, 34);
            txtBookNameForChange.TabIndex = 6;
            txtBookNameForChange.TextAlign = HorizontalAlignment.Center;
            // 
            // txtBookId
            // 
            txtBookId.Enabled = false;
            txtBookId.Location = new Point(547, 57);
            txtBookId.Multiline = true;
            txtBookId.Name = "txtBookId";
            txtBookId.Size = new Size(384, 34);
            txtBookId.TabIndex = 5;
            txtBookId.TextAlign = HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label7.Location = new Point(270, 131);
            label7.Name = "label7";
            label7.Size = new Size(183, 31);
            label7.TabIndex = 4;
            label7.Text = "عدد النسخ المتاحة";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label6.Location = new Point(970, 211);
            label6.Name = "label6";
            label6.Size = new Size(114, 31);
            label6.TabIndex = 3;
            label6.Text = "لغة الكتاب";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label5.Location = new Point(318, 51);
            label5.Name = "label5";
            label5.Size = new Size(111, 31);
            label5.TabIndex = 2;
            label5.Text = "عدد النسخ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label4.Location = new Point(966, 131);
            label4.Name = "label4";
            label4.Size = new Size(119, 31);
            label4.TabIndex = 1;
            label4.Text = "اسم الكتاب";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label3.Location = new Point(970, 51);
            label3.Name = "label3";
            label3.Size = new Size(114, 31);
            label3.TabIndex = 0;
            label3.Text = "رقم الكتاب";
            // 
            // button1
            // 
            button1.FlatAppearance.BorderColor = Color.Wheat;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(279, 182);
            button1.Name = "button1";
            button1.Size = new Size(33, 34);
            button1.TabIndex = 7;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(113, 5);
            label8.Name = "label8";
            label8.Size = new Size(43, 20);
            label8.TabIndex = 8;
            label8.Text = "يوجد ";
            // 
            // lbBooksCount
            // 
            lbBooksCount.AutoSize = true;
            lbBooksCount.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbBooksCount.Location = new Point(64, 1);
            lbBooksCount.Name = "lbBooksCount";
            lbBooksCount.Size = new Size(33, 25);
            lbBooksCount.TabIndex = 9;
            lbBooksCount.Text = "---";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(9, 5);
            label10.Name = "label10";
            label10.Size = new Size(40, 20);
            label10.TabIndex = 10;
            label10.Text = "كتاب";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(lbBooksCount);
            panel3.Location = new Point(962, 185);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(5);
            panel3.Size = new Size(166, 31);
            panel3.TabIndex = 11;
            // 
            // viewBooks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.Wheat;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1164, 640);
            Controls.Add(btnUpload);
            Controls.Add(panel3);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(txtBookName);
            Controls.Add(label2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1182, 1061);
            Name = "viewBooks";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "viewBooks";
            WindowState = FormWindowState.Maximized;
            Load += viewBooks_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ndAvailableBookCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)ndBookCounter).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private Label label2;
        private TextBox txtBookName;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtBookNameForChange;
        private TextBox txtBookId;
        private NumericUpDown ndAvailableBookCount;
        private NumericUpDown ndBookCounter;
        private ComboBox cbBookLang;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnCancel;
        private Button button1;
        private Label label8;
        private Label lbBooksCount;
        private Label label10;
        private Panel panel3;
        private Button btnUpload;
    }
}