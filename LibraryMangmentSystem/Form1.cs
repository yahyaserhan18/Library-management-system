namespace LibraryMangmentSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void الأستعارةToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void الخروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد الخروج بالفعل من البرنامج ؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();

        }

        private void اضافةكتابجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBook addBookForm = new AddBook();
            addBookForm.ShowDialog();
        }

        private void عرضالكتبToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewBooks vb = new viewBooks();
            vb.ShowDialog();
        }

        private void أستعToolStripMenuItem_Click(object sender, EventArgs e)
        {
            borrowBook borrowBook = new borrowBook();
        
            borrowBook.ShowDialog();
        }

        private void عرضالكتبالمستعارةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewBorrowBooks viewBorrowBooks = new viewBorrowBooks();
            viewBorrowBooks.ShowDialog();
        }
    }
}
