using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryMangmentSystem
{
    public partial class borrowBook : Form
    {
        public borrowBook()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cbBooks.SelectedItem == null || txtStudentName.Text == "")
            {
                MessageBox.Show(" أملأ جميع الحقول ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            int bookid = -1;


            clsDataLayer.GetBooIDByBookName(ref bookid, cbBooks.SelectedItem.ToString());
            int bookCount = clsDataLayer.GetCeilFromColumn(bookid, "عدد_النسخ");
            int availbeBookCount = clsDataLayer.GetCeilFromColumn(bookid, "عدد_النسخ_المتاحة");

            if (cbBooks.SelectedItem == null)
            {
                MessageBox.Show(" اختر اسم الكتاب بشكل صحيح", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(!(bookCount >= availbeBookCount && availbeBookCount > 0))
            {
                //MessageBox.Show($"{bookCount}  \n {availbeBookCount}");
                MessageBox.Show("لا يوجد نسخة من هذا الكتاب لاجل الاستعارة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //else if(!clsDataLayer.isAvaibleToBorrow(id))
            //{
            //    MessageBox.Show("لا يوجد نسخة من هذا الكتاب لاجل الاستعارة","خطأ",MessageBoxButtons.OK,MessageBoxIcon.Error);
            //}
            else
            {
                if (txtStudentName.Text.Trim() != "" || dtStart != null || dtEnd != null)
                {
                    //MessageBox.Show(cbBooks.SelectedItem.ToString());

                    int id = -1;
                    if (clsDataLayer.GetBooIDByBookName(ref id, cbBooks.SelectedItem.ToString()) && id != -1)
                    {
                        string studentName = txtStudentName.Text;

                        if (clsDataLayerForBorrowBook.AddNewBorrowBook(studentName, id, dtStart, dtEnd))
                            {
                            if (clsDataLayer.GetOutOneFromAvailableBookCount(id))
                            {
                                cbBooks.SelectedIndex = -1;
                                txtStudentName.Clear();

                                MessageBox.Show("! تم حفظ عملية الاستعارة بنجاح", "معلومة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                                MessageBox.Show(" مع الأسف حدث مشكلة لم يتم انقاص عدد الكتب المتاحة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);


                        }
                        else
                            MessageBox.Show(" مع الأسف حدث مشكلة لم يتم حفظ عملية الأستعارة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }


                }
                else
                    MessageBox.Show(" أملأ جميع الحقول ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void borrowBook_Load(object sender, EventArgs e)
        {
            clsDataLayer.LoadBooksToComboBox(ref cbBooks);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
