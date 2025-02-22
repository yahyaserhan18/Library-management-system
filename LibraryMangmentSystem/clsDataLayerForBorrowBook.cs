using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMangmentSystem
{
    internal class clsDataLayerForBorrowBook
    {
        static public bool AddNewBorrowBook(string studentName , int bookID , DateTimePicker dtStart , DateTimePicker dtEnd)
        {
            bool isAdded = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"INSERT INTO [dbo].[قسم_الأستعارة]
                           ([اسم_الطالب]
                           ,[رقم_الكتاب]
                           ,[بدأ_التاريخ]
                           ,[انتهاء_التاريخ])
                     VALUES
                          (@studentname
                           ,@bookid
                           ,@startdate
                           ,@enddate)
                    select SCOPE_IDENTITY();";



            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@studentname", studentName);
            command.Parameters.AddWithValue("@bookid", bookID);
            command.Parameters.AddWithValue("@startdate", DateTime.Parse(dtStart.Value.ToString()));
            command.Parameters.AddWithValue("@enddate", DateTime.Parse(dtEnd.Value.ToString()));



            try
            {

                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int bookId))
                {
                    //id = bookId;
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

        static public DataTable GetAllBorrowedBooks()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            //string query = @"
            //            SELECT قسم_الأستعارة.الرقم, قسم_الأستعارة.اسم_الطالب, كتب.اسم_الكتاب, قسم_الأستعارة.بدأ_التاريخ, قسم_الأستعارة.انتهاء_التاريخ
            //            FROM     قسم_الأستعارة INNER JOIN
            //            كتب ON قسم_الأستعارة.رقم_الكتاب = كتب.الرقم";

            //string query = @"
            //                SELECT قسم_الأستعارة.الرقم, قسم_الأستعارة.اسم_الطالب, كتب.اسم_الكتاب, قسم_الأستعارة.بدأ_التاريخ, قسم_الأستعارة.انتهاء_التاريخ, كتب.IsDelivered
            //                FROM     قسم_الأستعارة INNER JOIN
            //                                  كتب ON قسم_الأستعارة.رقم_الكتاب = كتب.الرقم";

            string query = @"SELECT قسم_الأستعارة.الرقم, قسم_الأستعارة.اسم_الطالب, كتب.اسم_الكتاب, قسم_الأستعارة.بدأ_التاريخ, قسم_الأستعارة.انتهاء_التاريخ, قسم_الأستعارة.IsDelivered
FROM     قسم_الأستعارة INNER JOIN
                  كتب ON قسم_الأستعارة.رقم_الكتاب = كتب.الرقم";
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

        static public int GetBorrowedBookCount()
        {
            int count = 0;

            //select count(*) from كتب

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = "select count(*) from قسم_الأستعارة";

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

        static public DataTable GetAllBorrowedBooksStartWith(string bookName)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);
            string query = @"SELECT * 
                            FROM (
                                SELECT قسم_الأستعارة.الرقم, 
                                       قسم_الأستعارة.اسم_الطالب, 
                                       كتب.اسم_الكتاب, 
                                       قسم_الأستعارة.بدأ_التاريخ, 
                                       قسم_الأستعارة.انتهاء_التاريخ
                                FROM قسم_الأستعارة 
                                INNER JOIN كتب ON قسم_الأستعارة.رقم_الكتاب = كتب.الرقم
                            ) AS الاستعارة_المؤقتة  
                            WHERE الاستعارة_المؤقتة.اسم_الكتاب LIKE @bookname + '%'";
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


        static public DataTable GetAllBorrowedBooksByStudentName(string studentName)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);
            //string query = @"select * from قسم_الأستعارة 
            //                where اسم_الطالب like @studentname + '%'";
            string query = @"SELECT * 
                            FROM (
                                SELECT قسم_الأستعارة.الرقم, 
                                       قسم_الأستعارة.اسم_الطالب, 
                                       كتب.اسم_الكتاب, 
                                       قسم_الأستعارة.بدأ_التاريخ, 
                                       قسم_الأستعارة.انتهاء_التاريخ
                                FROM قسم_الأستعارة 
                                INNER JOIN كتب ON قسم_الأستعارة.رقم_الكتاب = كتب.الرقم
                            ) AS الاستعارة_المؤقتة  
                            WHERE الاستعارة_المؤقتة.اسم_الطالب LIKE  @studentname + '%'";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@studentname", studentName);
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

        static public bool GetBorrowedBookInfoByID(int id, ref string studentName,ref int bookID, ref DateTimePicker dtStart, ref DateTimePicker dtEdn)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = "select * from قسم_الأستعارة where الرقم = @borrowID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@borrowID", id);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())  
                {
                    bookID = Convert.ToInt32(reader["رقم_الكتاب"]);
                    studentName = Convert.ToString(reader["اسم_الطالب"]);
                    // DateTime.Parse(dtEnd.Value.ToString())
                    dtStart.Value = Convert.ToDateTime(reader["بدأ_التاريخ"]).Date;
                    dtEdn.Value = Convert.ToDateTime(reader["انتهاء_التاريخ"]).Date;
                    

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


        static public bool DeleteBorrowedBook(int ID)
        {

            int affectedRows = 0;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"delete from [dbo].[قسم_الأستعارة]
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


        static public bool UpdateBerrowBookSdateEdate(int ID, DateTimePicker startDate , DateTimePicker endDate)
        {

            bool isUpdated = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"UPDATE [dbo].[قسم_الأستعارة]
                 SET 
                     بدأ_التاريخ = @startdate,
                     انتهاء_التاريخ = @enddate
                 WHERE الرقم = @id";


            SqlCommand command = new SqlCommand(query, connection);

            //dtStart.Value = Convert.ToDateTime(reader["بدأ_التاريخ"]).Date;
            //dtEdn.Value = Convert.ToDateTime(reader["انتهاء_التاريخ"]).Date;

            command.Parameters.AddWithValue("@startdate", startDate.Value.Date);
            command.Parameters.AddWithValue("@enddate", endDate.Value.Date);
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

        public static void MarkBookAsDelivered(int borrowBookId)
        {
            string query = "UPDATE قسم_الأستعارة SET IsDelivered = 1 WHERE الرقم = @id";
            using (SqlConnection con = new SqlConnection(DataAccessSettings.connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", borrowBookId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
