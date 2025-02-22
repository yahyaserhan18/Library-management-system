using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LibraryMangmentSystem
{
    public static class clsDataLayer
    {
        static public bool GetBookInfoByID(int id, ref string bookName,ref int bookCounter,ref string bookLang,ref int availbaleBookCount)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = "select * from كتب where الرقم = @bookid";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@bookid", id);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    bookName = Convert.ToString(reader["اسم_الكتاب"]);
                    bookCounter = Convert.ToInt32(reader["عدد_النسخ"]);
                    bookLang = Convert.ToString(reader["اللغة"]);
                    availbaleBookCount = Convert.ToInt32(reader["عدد_النسخ_المتاحة"]);

                    //// id = Convert.ToInt32(reader["ContactID"]);//gerek yok.
                    //firstname = Convert.ToString(reader["FirstName"]);
                    //lastname = Convert.ToString(reader["LastName"]);
                    //email = Convert.ToString(reader["Email"]);
                    //phone = Convert.ToString(reader["Phone"]);
                    //address = Convert.ToString(reader["Address"]);
                    //dateofbirth = Convert.ToDateTime(reader["DateOfBirth"]);
                    //countryid = Convert.ToInt32(reader["CountryID"]);
                    //// imagepath = Convert.ToString(reader["ImagePath"]);//this true 
                    //if (reader["ImagePath"] != DBNull.Value)
                    //    imagepath = Convert.ToString(reader["ImagePath"]);
                    //else
                    //    imagepath = "";


                    isFound = true;
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        static public bool GetBookInfoByName(ref int id, ref string bookName, ref int bookCounter, ref string bookLang, ref int availbaleBookCount)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = "select * from كتب where اسم_الكتاب like @bookname %";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@bookname", bookName);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    id = Convert.ToInt32(reader["الرقم"]);
                    bookName = Convert.ToString(reader["اسم_الكتاب"]);
                    bookCounter = Convert.ToInt32(reader["عدد_النسخ"]);
                    bookLang = Convert.ToString(reader["اللغة"]);
                    availbaleBookCount = Convert.ToInt32(reader["عدد_النسخ_المتاحة"]);

                    //// id = Convert.ToInt32(reader["ContactID"]);//gerek yok.
                    //firstname = Convert.ToString(reader["FirstName"]);
                    //lastname = Convert.ToString(reader["LastName"]);
                    //email = Convert.ToString(reader["Email"]);
                    //phone = Convert.ToString(reader["Phone"]);
                    //address = Convert.ToString(reader["Address"]);
                    //dateofbirth = Convert.ToDateTime(reader["DateOfBirth"]);
                    //countryid = Convert.ToInt32(reader["CountryID"]);
                    //// imagepath = Convert.ToString(reader["ImagePath"]);//this true 
                    //if (reader["ImagePath"] != DBNull.Value)
                    //    imagepath = Convert.ToString(reader["ImagePath"]);
                    //else
                    //    imagepath = "";


                    isFound = true;
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }


        static public bool GetBooIDByBookName(ref int id, string bookName)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = "select * from كتب where اسم_الكتاب = @bookname";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@bookname", bookName);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    id = Convert.ToInt32(reader["الرقم"]);
     
                    isFound = true;
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }



        static public bool AddNewBook(ref int id, string bookName, int bookCounter, string bookLang,int availableBookCount)
        {
            bool isAdded = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"INSERT INTO [dbo].[كتب]
                      ([اسم_الكتاب]
                      ,[عدد_النسخ]
                      ,[اللغة]
                      ,[عدد_النسخ_المتاحة])
                VALUES
                      (@bookName
                      ,@bookCount
                      ,@bookLang
                      ,@availableBookCount)
                    select SCOPE_IDENTITY();";



            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@bookName", bookName);
            command.Parameters.AddWithValue("@bookCount", bookCounter);
            command.Parameters.AddWithValue("@bookLang", bookLang);
            command.Parameters.AddWithValue("@availableBookCount", availableBookCount);



            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int bookId))
                {
                    id = bookId;
                    isAdded = true;
                }
                else
                    isAdded = false;
            }
            catch (Exception ex)
            {
                isAdded = false;
            }
            finally
            {
                connection.Close();
            }

            return isAdded;
        }


        static public bool UpdateBook(int ID, string bookName, int bookCounter, string bookLang, int availableBookCount)
        {

            bool isUpdated = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);


            string query = @"UPDATE [dbo].[كتب]
                           SET [اسم_الكتاب] = @bookname
                              ,[عدد_النسخ] = @bookcount
                              ,[اللغة] = @booklang
                              ,[عدد_النسخ_المتاحة] = @avbookcount
                         WHERE الرقم=@id";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@bookname", bookName);
            command.Parameters.AddWithValue("@bookcount", bookCounter);
            command.Parameters.AddWithValue("@booklang", bookLang);
            command.Parameters.AddWithValue("@avbookcount", availableBookCount);
            command.Parameters.AddWithValue("@id", ID);
            

            try
            {
                connection.Open();

                int affectedRows = command.ExecuteNonQuery();

                isUpdated = (affectedRows > 0);

            }
            catch (Exception ex)
            {
                isUpdated = false;
            }
            finally
            {
                connection.Close();
            }

            return isUpdated;

        }

        static public bool UpdateavBookCount(int ID, int availableBookCount)
        {

            bool isUpdated = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);


            string query = @"UPDATE [dbo].[كتب]
                           SET
                              [عدد_النسخ_المتاحة] = @avbookcount
                         WHERE الرقم=@id";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@avbookcount", availableBookCount);
            command.Parameters.AddWithValue("@id", ID);


            try
            {
                connection.Open();

                int affectedRows = command.ExecuteNonQuery();

                isUpdated = (affectedRows > 0);

            }
            catch (Exception ex)
            {
                isUpdated = false;
            }
            finally
            {
                connection.Close();
            }

            return isUpdated;

        }


        static public bool DeleteBook(int ID)
        {

            int affectedRows = 0;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"delete from [dbo].[كتب]
                            where الرقم = @id";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@id", ID);

            try
            {
                connection.Open();
                affectedRows = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //
            }
            finally
            {
                connection.Close();
            }

            return (affectedRows > 0);

        }

        static public bool isExist(int ID)
        {

            bool isfound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"select top 1 found=1 from [dbo].[Contacts]
                            where ContactID = @id";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@id", ID);

            try
            {
                connection.Open();

                //object result = command.ExecuteScalar();
                //if(result != null) 
                //    isfound = true;

                SqlDataReader reader = command.ExecuteReader();

                isfound = reader.HasRows;
                reader.Close();

            }
            catch (Exception ex)
            {
                //
            }
            finally
            {
                connection.Close();
            }

            return isfound;
        }

        static public DataTable GetAllBooks()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = "select * from كتب";
            SqlCommand command = new SqlCommand(query, connection);


            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                    dt.Load(reader);

                reader.Close();

            }
            catch (Exception ex)
            {
                //
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }

        static public DataTable GetAllBooksStartWith(string bookName)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = "SELECT * FROM كتب WHERE اسم_الكتاب LIKE @bookname + '%'";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@bookname", bookName);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                    dt.Load(reader);

                reader.Close();

            }
            catch (Exception ex)
            {
                //
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }

        static public int GetBookCount()
        {
            int count = 0;

            //select count(*) from كتب

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = "select count(*) from كتب";

            SqlCommand command = new SqlCommand(query, connection);


            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int bookCount))
                {
                    count = bookCount;
                }
            }
            catch (Exception ex)
            {
                //
            }
            finally
            {
                connection.Close();
            }

            return count;
        }

        static public bool LoadBooksToComboBox(ref ComboBox cb)
        {
            bool isLoaded = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = "SELECT اسم_الكتاب FROM كتب";
            SqlCommand command = new SqlCommand(query, connection);


            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();


                while (reader.Read())
                {
                    cb.Items.Add(reader.GetValue(0).ToString());
                    isLoaded = true;
                }
                

                reader.Close();

            }
            catch (Exception ex)
            {
                //
            }
            finally
            {
                connection.Close();
            }


            return isLoaded;
        }

        static public int GetCeilFromColumn(int bookID,string column)
        {
            //bool isAvailble = false;
            int colValue = -1;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            //string query1 = @" select كتب.عدد_النسخ from كتب
            //                    where الرقم = @bookid";

            //string query2 = @"select كتب.عدد_النسخ_المتاحة from كتب
            //                    where الرقم = @bookid";

            //string query = @"select @col from كتب
            //                    where الرقم = @bookid"
            //;
            string query = $@"SELECT {column} FROM كتب WHERE الرقم = @bookid";


            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@bookid", bookID);
            //command.Parameters.AddWithValue("@col", column);


            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int colv))
                {
                    colValue = colv;
                }
            }
            catch (Exception ex)
            {
                //
            }
            finally
            {
                connection.Close();
            }

           return colValue;
        }

        static public bool addOneToAvailableBookCount(int id)
        {
            int avBookCount = GetCeilFromColumn(id, "عدد_النسخ_المتاحة");
            avBookCount++;
            if (avBookCount < 0)
                return false;

            return UpdateavBookCount(id, avBookCount);
        }
        static public bool GetOutOneFromAvailableBookCount(int id)
        {
            int avBookCount = GetCeilFromColumn(id, "عدد_النسخ_المتاحة");
            avBookCount--;
            if (avBookCount < 0)
                return false;

            return UpdateavBookCount(id, avBookCount);
        }

       
    }
}
