using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using BLL;
using DTO;
using DAL;

namespace GUI
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        string connString = "Data Source=THANHPHONG;Initial Catalog=LibraryManagementSystem;Integrated Security=True";
        SqlDataAdapter adapter = null;
        DataSet ds = null;
        private void Form3_Load(object sender, EventArgs e)
        {
            //dgvBook.DataSource = BookBBL.GetAllBook();
        }

        private void txtBookName_TextChanged(object sender, EventArgs e)
        {
            adapter = new SqlDataAdapter($"select * from BOOK where BOOKNAME like'%{txtBookName.Text}'", connString);
            ds = new DataSet();
            adapter.Fill(ds);
            dgvBook.DataSource = ds.Tables[0];
        }
    }
}
