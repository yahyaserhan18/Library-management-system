using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LibraryMangmentSystem
{
    public partial class AddBook : Form
    {
        public string connectionString = "Server =.; database = Library; integrated security=True;";
        public AddBook()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            string bookName = txtBookName.Text;
            int bookCounter = Int32.Parse(ndBookCounter.Text);
            string bookLanguage = cbBookLang.Text;
            int id = -1;

            if (bookName == "" || bookCounter == 0 || bookLanguage == "")
            {
                MessageBox.Show(" أملأ جميع الحقول ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (clsDataLayer.AddNewBook(ref id, bookName, bookCounter, bookLanguage,bookCounter))
                {
                    txtBookName.Clear();
                    ndBookCounter.Value = 0;
                    cbBookLang.SelectedIndex = -1;
                    MessageBox.Show("! تمت اضافة الكتاب بنجاح", "معلومة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show(" مع الأسف حدث مشكلة لم يتم اضافة الكتاب", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ndBookCounter_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
