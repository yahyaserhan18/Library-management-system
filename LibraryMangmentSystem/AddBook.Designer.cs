namespace LibraryMangmentSystem
{
    partial class AddBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBook));
            cbBookLang = new ComboBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            ndBookCounter = new NumericUpDown();
            btnCancel = new Button();
            btnSave = new Button();
            txtBookName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ndBookCounter).BeginInit();
            SuspendLayout();
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
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(370, 548);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Wheat;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(370, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(668, 77);
            panel1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(59, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(145, 71);
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
            label1.Size = new Size(228, 64);
            label1.TabIndex = 0;
            label1.Text = "أضف كتاب";
            label1.Click += label1_Click;
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
            panel2.Location = new Point(370, 77);
            panel2.Name = "panel2";
            panel2.Size = new Size(668, 471);
            panel2.TabIndex = 2;
            // 
            // ndBookCounter
            // 
            ndBookCounter.Location = new Point(27, 142);
            ndBookCounter.Name = "ndBookCounter";
            ndBookCounter.Size = new Size(466, 27);
            ndBookCounter.TabIndex = 8;
            ndBookCounter.TextAlign = HorizontalAlignment.Center;
            ndBookCounter.ValueChanged += ndBookCounter_ValueChanged;
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
            btnCancel.Click += btnCancel_Click;
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
            btnSave.Click += btnSave_Click;
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
            // AddBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1038, 548);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(1056, 595);
            MinimumSize = new Size(1056, 595);
            Name = "AddBook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddBook";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ndBookCounter).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox2;
        private Panel panel2;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtBookName;
        private NumericUpDown ndBookCounter;
        private Button btnCancel;
        private Button btnSave;
        private ComboBox cbBookLang;
    }
}