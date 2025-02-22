namespace LibraryMangmentSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            الكتبToolStripMenuItem = new ToolStripMenuItem();
            اضافةكتابجديدToolStripMenuItem = new ToolStripMenuItem();
            عرضالكتبToolStripMenuItem = new ToolStripMenuItem();
            الأستعارةToolStripMenuItem = new ToolStripMenuItem();
            أستعToolStripMenuItem = new ToolStripMenuItem();
            عرضالكتبالمستعارةToolStripMenuItem = new ToolStripMenuItem();
            الخروجToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Wheat;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { الكتبToolStripMenuItem, الأستعارةToolStripMenuItem, الخروجToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1294, 58);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // الكتبToolStripMenuItem
            // 
            الكتبToolStripMenuItem.BackColor = Color.OldLace;
            الكتبToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { اضافةكتابجديدToolStripMenuItem, عرضالكتبToolStripMenuItem });
            الكتبToolStripMenuItem.Image = (Image)resources.GetObject("الكتبToolStripMenuItem.Image");
            الكتبToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            الكتبToolStripMenuItem.Name = "الكتبToolStripMenuItem";
            الكتبToolStripMenuItem.Size = new Size(109, 54);
            الكتبToolStripMenuItem.Text = "الكتب";
            // 
            // اضافةكتابجديدToolStripMenuItem
            // 
            اضافةكتابجديدToolStripMenuItem.Image = (Image)resources.GetObject("اضافةكتابجديدToolStripMenuItem.Image");
            اضافةكتابجديدToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            اضافةكتابجديدToolStripMenuItem.Name = "اضافةكتابجديدToolStripMenuItem";
            اضافةكتابجديدToolStripMenuItem.Size = new Size(230, 56);
            اضافةكتابجديدToolStripMenuItem.Text = "اضافة كتاب جديد";
            اضافةكتابجديدToolStripMenuItem.Click += اضافةكتابجديدToolStripMenuItem_Click;
            // 
            // عرضالكتبToolStripMenuItem
            // 
            عرضالكتبToolStripMenuItem.Image = (Image)resources.GetObject("عرضالكتبToolStripMenuItem.Image");
            عرضالكتبToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            عرضالكتبToolStripMenuItem.Name = "عرضالكتبToolStripMenuItem";
            عرضالكتبToolStripMenuItem.Size = new Size(230, 56);
            عرضالكتبToolStripMenuItem.Text = "عرض الكتب";
            عرضالكتبToolStripMenuItem.Click += عرضالكتبToolStripMenuItem_Click;
            // 
            // الأستعارةToolStripMenuItem
            // 
            الأستعارةToolStripMenuItem.BackColor = Color.Wheat;
            الأستعارةToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { أستعToolStripMenuItem, عرضالكتبالمستعارةToolStripMenuItem });
            الأستعارةToolStripMenuItem.Image = (Image)resources.GetObject("الأستعارةToolStripMenuItem.Image");
            الأستعارةToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            الأستعارةToolStripMenuItem.Name = "الأستعارةToolStripMenuItem";
            الأستعارةToolStripMenuItem.Size = new Size(164, 54);
            الأستعارةToolStripMenuItem.Text = "قسم الأستعارة";
            الأستعارةToolStripMenuItem.Click += الأستعارةToolStripMenuItem_Click;
            // 
            // أستعToolStripMenuItem
            // 
            أستعToolStripMenuItem.Image = (Image)resources.GetObject("أستعToolStripMenuItem.Image");
            أستعToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            أستعToolStripMenuItem.Name = "أستعToolStripMenuItem";
            أستعToolStripMenuItem.Size = new Size(262, 56);
            أستعToolStripMenuItem.Text = "أستعر كتاب";
            أستعToolStripMenuItem.Click += أستعToolStripMenuItem_Click;
            // 
            // عرضالكتبالمستعارةToolStripMenuItem
            // 
            عرضالكتبالمستعارةToolStripMenuItem.Image = (Image)resources.GetObject("عرضالكتبالمستعارةToolStripMenuItem.Image");
            عرضالكتبالمستعارةToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            عرضالكتبالمستعارةToolStripMenuItem.Name = "عرضالكتبالمستعارةToolStripMenuItem";
            عرضالكتبالمستعارةToolStripMenuItem.Size = new Size(262, 56);
            عرضالكتبالمستعارةToolStripMenuItem.Text = "عرض الكتب المستعارة";
            عرضالكتبالمستعارةToolStripMenuItem.Click += عرضالكتبالمستعارةToolStripMenuItem_Click;
            // 
            // الخروجToolStripMenuItem
            // 
            الخروجToolStripMenuItem.BackColor = Color.OldLace;
            الخروجToolStripMenuItem.Image = (Image)resources.GetObject("الخروجToolStripMenuItem.Image");
            الخروجToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            الخروجToolStripMenuItem.Name = "الخروجToolStripMenuItem";
            الخروجToolStripMenuItem.Size = new Size(114, 54);
            الخروجToolStripMenuItem.Text = "الخروج";
            الخروجToolStripMenuItem.Click += الخروجToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1294, 608);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Library mangment system";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem الكتبToolStripMenuItem;
        private ToolStripMenuItem اضافةكتابجديدToolStripMenuItem;
        private ToolStripMenuItem عرضالكتبToolStripMenuItem;
        private ToolStripMenuItem الأستعارةToolStripMenuItem;
        private ToolStripMenuItem أستعToolStripMenuItem;
        private ToolStripMenuItem عرضالكتبالمستعارةToolStripMenuItem;
        private ToolStripMenuItem الخروجToolStripMenuItem;
    }
}
