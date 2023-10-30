using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

namespace BLL
{
    public class BookBBL
    {
        public static DataTable GetAllBook()
        {
            return BookAccessDAL.getData();
        }

        public static void InsertBook(BOOK bk)
        {
            BookAccessDAL.InsertBook(bk);
        }

        public static void UpdateBook(BOOK bk)
        {
            BookAccessDAL.UpdateBook(bk);
        }

        public static void DeleteBook(string bookId)
        {
            BookAccessDAL.DeleteBook(bookId);
        }
    }
}
