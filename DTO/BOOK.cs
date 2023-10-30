using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BOOK
    {
        private string bookID;
        private string bookName;
        private string author;
        private int year;

        public BOOK(string bookID, string bookName, string author, int year)
        {
            this.bookID = bookID;
            this.bookName = bookName;
            this.author = author;
            this.year = year;
        }

        public string BookID { get => bookID; set => bookID = value; }
        public string BookName { get => bookName; set => bookName = value; }
        public string Author { get => author; set => author = value; }
        public int Year { get => year; set => year = value; }
    }
}
