using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryMangmentSystem
{
    public partial class viewBorrowBooks : Form
    {
        public viewBorrowBooks()
        {
            InitializeComponent();
        }

        private void txtBookName_TextChanged(object sender, EventArgs e)
        {

            if (cbSearchBy.SelectedIndex == -1)
            {
                MessageBox.Show(@"أرجو أن تختار عن طريق ماذا تريد البحث , هل عن طريق اسم الطالب ام عن طريق اسم الكتاب", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (cbSearchBy.SelectedItem.ToString() == "اسم الطالب")
                {
                    if (txtSearchBy.Text != "")
                    {

                        dataGridView1.DataSource = clsDataLayerForBorrowBook.GetAllBorrowedBooksByStudentName(txtSearchBy.Text);

                    }
                    else
                    {
                        dataGridView1.DataSource = clsDataLayerForBorrowBook.GetAllBorrowedBooks();
                    }
                }
                else if (cbSearchBy.SelectedItem.ToString() == "اسم الكتاب")
                {
                    if (txtSearchBy.Text != "")
                    {

                        dataGridView1.DataSource = clsDataLayerForBorrowBook.GetAllBorrowedBooksStartWith(txtSearchBy.Text);

                    }
                    else
                    {
                        dataGridView1.DataSource = clsDataLayerForBorrowBook.GetAllBorrowedBooks();
                    }


                }
            }
        }


        //}
        private void viewBorrowBooks_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;

            // تحميل البيانات من قاعدة البيانات
            DataTable dt = clsDataLayerForBorrowBook.GetAllBorrowedBooks();
            dataGridView1.DataSource = dt;

            lbBooksCount.Text = clsDataLayerForBorrowBook.GetBorrowedBookCount().ToString();

            if (dataGridView1.Columns["IsDelivered"] != null)
            {
                dataGridView1.Columns["IsDelivered"].Visible = false;
            }


            // إضافة عمود زر "الإجراء" إذا لم يكن موجودًا
            if (dataGridView1.Columns["الإجراء"] == null)
            {
                DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
                btnColumn.HeaderText = "الإجراء";
                btnColumn.Text = "هل تم التسليم؟";
                btnColumn.Name = "الإجراء";
                btnColumn.UseColumnTextForButtonValue = true; // يجعل الزر يظهر النص دائماً
                dataGridView1.Columns.Add(btnColumn);
            }

            // فحص كل صف واستبدال الزر بالنص إذا كان الكتاب مسلَّمًا بالفعل
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["IsDelivered"].Value != DBNull.Value && Convert.ToBoolean(row.Cells["IsDelivered"].Value))
                {
                    // استبدال الزر بخلية نصية
                    DataGridViewTextBoxCell textCell = new DataGridViewTextBoxCell();
                    textCell.Value = "تم التسليم";
                    row.Cells["الإجراء"] = textCell;
                }
            }
        }


        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // تأكد من أن الفهرس الحالي يمثل العمود الذي يحتوي على التاريخ
            if (dataGridView1.Columns[e.ColumnIndex].Name == "انتهاء_التاريخ")
            {
                // حاول تحويل القيمة إلى DateTime
                if (e.Value != null && DateTime.TryParse(e.Value.ToString(), out DateTime tarih))
                {

                    if (tarih.Date < DateTime.Now.Date) // إذا كان التاريخ أقل من اليوم الحالي
                    {
                        //MessageBox.Show($"{tarih}   -    {DateTime.Now}");
                        dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red; // لون أحمر
                        dataGridView1.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White; // نص أبيض
                    }
                    else if (tarih.Date > DateTime.Now.Date) // إذا كان التاريخ أكبر من اليوم الحالي
                    {
                        dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Blue; // لون أزرق
                        dataGridView1.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White; // نص أبيض
                    }
                    else
                    {

                        dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow; // لون أزرق
                        dataGridView1.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black; // نص أبيض
                    }

                }
            }
        }
        /// <summary>
        /// ///////////
        /// </summary>
        public int borrowID = -1;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count &&
        e.ColumnIndex >= 0 && e.ColumnIndex < dataGridView1.Columns.Count)
            {
                var clickedColumn = dataGridView1.Columns[e.ColumnIndex];



                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    var clickedCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];

                    // التحقق مما إذا كانت الخلية لا تزال زرًا
                    if (clickedCell is DataGridViewButtonCell)
                    {
                        string recordOfBookName = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                        int bookId = -1;
                        clsDataLayer.GetBooIDByBookName(ref bookId, recordOfBookName);
                        //MessageBox.Show($"{bookId}");
                        if (clsDataLayer.addOneToAvailableBookCount(bookId))
                        {
                            // تحديث قاعدة البيانات لحفظ حالة التسليم
                            //clsDataLayer.MarkBookAsDelivered(bookId)
                            int borrowBookID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["الرقم"].Value.ToString());
                            clsDataLayerForBorrowBook.MarkBookAsDelivered(borrowBookID);

                            MessageBox.Show("تمت تأكيد العملية بنجاح", "معلومة", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // تغيير الزر إلى خلية نصية بدلاً منه
                            DataGridViewTextBoxCell textCell = new DataGridViewTextBoxCell();
                            textCell.Value = "تم التسليم";
                            dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex] = textCell;
                        }
                        else
                        {
                            MessageBox.Show("حدث خطأ ما , فشل تأكيد العملية ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                //
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    //borrowID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                    if (dataGridView1.Rows[e.RowIndex].Cells["الرقم"].Value != null)
                    {
                        borrowID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["الرقم"].Value.ToString());
                    }
                    else
                        MessageBox.Show(" حدث خطأ لم يتم التعرف على رقم المعرف", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                panel2.Visible = true;
                string studentName = "";
                int bookID = -1;
                DateTimePicker dtstart = new DateTimePicker();
                DateTimePicker dtend = new DateTimePicker();

                clsDataLayerForBorrowBook.GetBorrowedBookInfoByID(borrowID, ref studentName, ref bookID, ref dtstart, ref dtend);
                //MessageBox.Show($"{bookID}--{bookLang}");

                string bookName = "";
                int bookCounter = -1;
                string bookLang = "";
                int avbookcount = -1;
                clsDataLayer.GetBookInfoByID(bookID, ref bookName, ref bookCounter, ref bookLang, ref avbookcount);
                cbBooks.Text = bookName;
                txtStudentName.Text = studentName;
                dtStart.Value = dtstart.Value;
                dtEnd.Value = dtend.Value;


            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(borrowID.ToString());
            if (MessageBox.Show(" هل أنت متأكد بأنك تريد حذف هذا الكتاب (سوف يتم تسليم الكتاب ثم المسح) ؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)

            {
                if (clsDataLayerForBorrowBook.DeleteBorrowedBook(borrowID))
                {
                   
                    int bookId = -1;
                    clsDataLayer.GetBooIDByBookName(ref bookId, cbBooks.Text);
                    clsDataLayer.addOneToAvailableBookCount(bookId);

                        txtStudentName.Clear();
                    //dsStart , dsEnd
                    cbBooks.SelectedIndex = -1;

                    MessageBox.Show("! تم حذف السجل بنجاح", "معلومة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    panel2.Visible = false;


                    //-------------------
                    dataGridView1.DataSource = clsDataLayerForBorrowBook.GetAllBorrowedBooks();
                    lbBooksCount.Text = clsDataLayerForBorrowBook.GetBorrowedBookCount().ToString();
                }
                else
                    MessageBox.Show(" مع الأسف حدث مشكلة لم يتم حذف السجل", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //MessageBox.Show($"{dtStart.Value.Date}\n{dtEnd.Value.Date}");

            DateTimePicker startdate = dtStart;
            DateTimePicker enddate = dtEnd;

            if (startdate.Value == null || enddate.Value == null)
            {
                MessageBox.Show("أملأ جميع الحقول لأجل حفظ التعديلات", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show(" هل تريد بالفعل حفظ التغييرات ؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    if (clsDataLayerForBorrowBook.UpdateBerrowBookSdateEdate(borrowID, startdate, enddate))
                    {
                        txtStudentName.Clear();
                        cbBooks.SelectedIndex = -1;
                        MessageBox.Show("! تم حفظ التغييرات بنجاح", "معلومة", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtSearchBy.Text = "";
                        panel2.Visible = false;

                        dataGridView1.DataSource = clsDataLayerForBorrowBook.GetAllBorrowedBooks();
                        lbBooksCount.Text = clsDataLayerForBorrowBook.GetBorrowedBookCount().ToString();
                    }
                    else
                        MessageBox.Show(" مع الأسف حدث مشكلة لم يتم اضافة الكتاب", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtSearchBy.Clear();
            panel2.Visible = false;
        }

        private void btnDeleteAllCellsWithRed_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" هل أنت متأكد بأنك تريد حذف السجلات الملونة باللون الاحمر ؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {

                DateTime today = DateTime.Today; // الحصول على تاريخ اليوم

                // إنشاء قائمة لتخزين المعرفات (الأرقام) التي سيتم حذفها
                List<int> idsToDelete = new List<int>();

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["انتهاء_التاريخ"].Value != null)
                    {
                        DateTime endDate;
                        if (DateTime.TryParse(row.Cells["انتهاء_التاريخ"].Value.ToString(), out endDate))
                        {
                            if (endDate.Date < today.Date) // التحقق إذا كان التاريخ أقل من اليوم
                            {
                                // row.DefaultCellStyle.BackColor = Color.Red; // تلوين الصف بالأحمر (للتأكيد)
                                idsToDelete.Add(Convert.ToInt32(row.Cells["الرقم"].Value)); // حفظ الـ ID للحذف
                            }
                        }
                    }
                }
                if (idsToDelete.Count > 0)
                {
                    int successCount = 0;
                    foreach (int id in idsToDelete)
                    {

                        if (clsDataLayerForBorrowBook.DeleteBorrowedBook(id))
                            successCount++;
                    }
                    if (successCount == idsToDelete.Count)
                    {
                        MessageBox.Show("! تم حذف السجلات بنجاح", "معلومة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        panel2.Visible = false;
                        dataGridView1.DataSource = clsDataLayerForBorrowBook.GetAllBorrowedBooks();
                        lbBooksCount.Text = clsDataLayerForBorrowBook.GetBorrowedBookCount().ToString();
                    }
                    else
                        MessageBox.Show(" مع الأسف حدث مشكلة لم يتم حذف جميع السجلات", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                    MessageBox.Show("! لا يوجد سجلات لحذفها", "معلومة", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
        }

        private void btnBooksDelivered_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد فعلا مسح السجلات التي تم التسليم فيها ؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool success = false;
                for (int i = dataGridView1.Rows.Count - 1; i >= 0; i--)
                {
                    DataGridViewRow row = dataGridView1.Rows[i];

                    if (row.Cells["الإجراء"].Value?.ToString() == "تم التسليم")
                    {
                        success = true;
                        int id = Convert.ToInt32(row.Cells["الرقم"].Value);
                        clsDataLayerForBorrowBook.DeleteBorrowedBook(id);
                        // dataGridView1.Rows.RemoveAt(i);
                    }
                }
                if (success)
                    MessageBox.Show("تم المسح بنجاح", "معلومة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("لا يوجد سجلات لمسحها", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                DataTable dt = clsDataLayerForBorrowBook.GetAllBorrowedBooks();
                dataGridView1.DataSource = dt;

                lbBooksCount.Text = clsDataLayerForBorrowBook.GetBorrowedBookCount().ToString();
            }
        }

        private void dtStart_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
