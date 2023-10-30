using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
using DAL;

namespace GUI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlDataAdapter adapter = null;
        DataSet ds = null;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dgvBook.DataSource = BookBBL.GetAllBook();
        }

        private void btnINSERT_Click(object sender, EventArgs e)
        {
            string bookId = txtBookID.Text;
            string bookName = txtBookName.Text;
            string author = txtAuthor.Text;
            int year = int.Parse(txtYear.Text);
            BOOK book = new BOOK(bookId, bookName, author, year);
            BookBBL.InsertBook(book);
            MessageBox.Show("Bạn đã thêm " + bookName + " thành công !");
            dgvBook.DataSource = BookBBL.GetAllBook();
        }

        private void dgvBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgvBook.Rows[e.RowIndex];
            txtBookID.Text = row.Cells[0].Value.ToString();
            txtBookName.Text = row.Cells[1].Value.ToString();
            txtAuthor.Text = row.Cells[2].Value.ToString();
            txtYear.Text = row.Cells[3].Value.ToString();
        }

        private void btnUPDATE_Click(object sender, EventArgs e)
        {
            string bookId = txtBookID.Text.Trim();
            string bookName = txtBookName.Text.Trim();
            string author = txtAuthor.Text.Trim();
            int year = int.Parse(txtYear.Text);
            BOOK book = new BOOK(bookId, bookName, author, year);
            BookBBL.UpdateBook(book);
            MessageBox.Show("Bạn đã cập nhật " + bookName + " thành công !");
            dgvBook.DataSource = BookBBL.GetAllBook();
        }

        private void btnDELETE_Click(object sender, EventArgs e)
        {
            string bookId = txtBookID.Text;
            string bookName = txtBookName.Text;
            string author = txtAuthor.Text;
            int year = int.Parse(txtYear.Text);
            BOOK book = new BOOK(bookId, bookName, author, year);
            BookBBL.DeleteBook(bookId);
            MessageBox.Show("Bạn đã xóa " + bookName + " thành công !");
            dgvBook.DataSource = BookBBL.GetAllBook();
        }

        private void btnEXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
