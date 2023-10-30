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
    public class DatabaseAccessDAL
    {
        public static SqlConnection connectionFunc()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=THANHPHONG;Initial Catalog=LibraryManagementSystem;Integrated Security=True");
            return conn;
        }
    }
}
