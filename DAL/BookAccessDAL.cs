using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class BookAccessDAL
    {
        public static DataTable getData()
        {
            SqlConnection conn = DatabaseAccessDAL.connectionFunc();
            SqlCommand command = new SqlCommand("sp_GetAllBook", conn);
            command.CommandType = CommandType.StoredProcedure;
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            conn.Close();
            return dt;
        }

        public static void InsertBook(BOOK bk)
        {
            SqlConnection conn = DatabaseAccessDAL.connectionFunc();
            SqlCommand command = new SqlCommand("sp_InsertBook", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@BOOK_ID", SqlDbType.NChar, 10);
            command.Parameters.Add("@BOOKNAME", SqlDbType.NChar, 100);
            command.Parameters.Add("@AUTHOR", SqlDbType.NChar, 50);
            command.Parameters.Add("@PUBLICATION_YEAR", SqlDbType.Int);
            command.Parameters["@BOOK_ID"].Value = bk.BookID;
            command.Parameters["@BOOKNAME"].Value = bk.BookName;
            command.Parameters["@AUTHOR"].Value = bk.Author;
            command.Parameters["@PUBLICATION_YEAR"].Value = bk.Year;

            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();

        }

        public static void UpdateBook(BOOK bk)
        {
            SqlConnection conn = DatabaseAccessDAL.connectionFunc();
            SqlCommand command = new SqlCommand("sp_UpdateBook", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@BOOK_ID", SqlDbType.NChar, 10);
            command.Parameters.Add("@BOOKNAME", SqlDbType.NChar, 100);
            command.Parameters.Add("@AUTHOR", SqlDbType.NChar, 50);
            command.Parameters.Add("@PUBLICATION_YEAR", SqlDbType.Int);
            command.Parameters["@BOOK_ID"].Value = bk.BookID;
            command.Parameters["@BOOKNAME"].Value = bk.BookName;
            command.Parameters["@AUTHOR"].Value = bk.Author;
            command.Parameters["@PUBLICATION_YEAR"].Value = bk.Year;

            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();

        }

        public static void DeleteBook(string bookId)
        {
            SqlConnection conn = DatabaseAccessDAL.connectionFunc();
            SqlCommand command = new SqlCommand("sp_DeleteBook", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@BOOK_ID", SqlDbType.NChar, 10);
            command.Parameters["@BOOK_ID"].Value = bookId;

            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();

        }
    }
}
