using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;

namespace LibraryMangmentSystem
{
    public partial class viewBooks : Form
    {
        public viewBooks()
        {
            InitializeComponent();
        }

        private void viewBooks_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            dataGridView1.DataSource = clsDataLayer.GetAllBooks();
            lbBooksCount.Text = clsDataLayer.GetBookCount().ToString();

        }
        public int bookID = -1;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count &&
               e.ColumnIndex >= 0 && e.ColumnIndex < dataGridView1.Columns.Count)
            {

                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    bookID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

                }
                panel2.Visible = true;
                string bookname = "";
                string bookLang = "";
                int bookcount = -1;
                int avbookcount = -1;
                clsDataLayer.GetBookInfoByID(bookID, ref bookname, ref bookcount, ref bookLang, ref avbookcount);
                //MessageBox.Show($"{bookID}--{bookLang}");
                txtBookId.Text = bookID.ToString();
                txtBookNameForChange.Text = bookname;
                cbBookLang.Text = bookLang;
                ndBookCounter.Value = bookcount;
                ndAvailableBookCount.Value = avbookcount;

            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void txtBookName_TextChanged(object sender, EventArgs e)
        {
            if (txtBookName.Text != "")
            {
                dataGridView1.DataSource = clsDataLayer.GetAllBooksStartWith(txtBookName.Text);
            }
            else
            {
                dataGridView1.DataSource = clsDataLayer.GetAllBooks();
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            txtBookName.Clear();
            panel2.Visible = false;
            dataGridView1.DataSource = clsDataLayer.GetAllBooks();
            lbBooksCount.Text = clsDataLayer.GetBookCount().ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string bookName = txtBookNameForChange.Text;
            int bookCounter = Int32.Parse(ndBookCounter.Text);
            string bookLanguage = cbBookLang.Text;
            int availableBookCount = Int32.Parse(ndAvailableBookCount.Text);
            int id = int.Parse(txtBookId.Text);

            if (bookName == "" || bookCounter == 0 || bookLanguage == "" )
            {
                MessageBox.Show("أملأ جميع الحقول لأجل حفظ التعديلات", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show(" هل تريد بالفعل حفظ التغييرات ؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    if (clsDataLayer.UpdateBook(id, bookName, bookCounter, bookLanguage, availableBookCount))
                    {
                        txtBookNameForChange.Clear();
                        ndBookCounter.Value = 0;
                        ndAvailableBookCount.Value = 0;
                        cbBookLang.SelectedIndex = -1;
                        MessageBox.Show("! تم حفظ التغييرات بنجاح", "معلومة", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtBookName.Text = "";
                        panel2.Visible = false;

                        dataGridView1.DataSource = clsDataLayer.GetAllBooks();
                    }
                    else
                        MessageBox.Show(" مع الأسف حدث مشكلة لم يتم اضافة الكتاب", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" هل أنت متأكد بأنك تريد حذف هذا الكتاب ؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (clsDataLayer.DeleteBook(int.Parse(txtBookId.Text)))
                {
                    txtBookNameForChange.Clear();
                    ndBookCounter.Value = 0;
                    ndAvailableBookCount.Value = 0;
                    cbBookLang.SelectedIndex = -1;
                    MessageBox.Show("! تم حذف الكتاب بنجاح", "معلومة", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtBookName.Text = "";
                    panel2.Visible = false;

                    lbBooksCount.Text = clsDataLayer.GetBookCount().ToString();
                }
                else
                    MessageBox.Show(" مع الأسف حدث مشكلة لم يتم حذف الكتاب", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("لا توجد بيانات لتصديرها!", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx", Title = "احفظ الملف كـ" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                        //ExcelPackage.License = new OfficeOpenXml.License() { Context = LicenseContext.NonCommercial };

                        using (ExcelPackage package = new ExcelPackage())
                        {
                            ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Sheet1");

                            // إضافة عناوين الأعمدة
                            for (int col = 0; col < dataGridView1.Columns.Count; col++)
                            {
                                worksheet.Cells[1, col + 1].Value = dataGridView1.Columns[col].HeaderText;
                            }

                            // إضافة البيانات من DataGridView إلى ملف Excel
                            for (int row = 0; row < dataGridView1.Rows.Count; row++)
                            {
                                for (int col = 0; col < dataGridView1.Columns.Count; col++)
                                {
                                    worksheet.Cells[row + 2, col + 1].Value = dataGridView1.Rows[row].Cells[col].Value?.ToString();
                                }
                            }

                            // حفظ الملف
                            File.WriteAllBytes(sfd.FileName, package.GetAsByteArray());
                            MessageBox.Show("تم حفظ البيانات في الملف بنجاح!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("حدث خطأ أثناء التصدير: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
