namespace GUI
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtBookID = new TextBox();
            txtBookName = new TextBox();
            txtAuthor = new TextBox();
            txtYear = new TextBox();
            btnINSERT = new Button();
            btnDELETE = new Button();
            btnUPDATE = new Button();
            btnEXIT = new Button();
            dgvBook = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvBook).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(313, 23);
            label1.Name = "label1";
            label1.Size = new Size(151, 28);
            label1.TabIndex = 0;
            label1.Text = "UPDATE BOOK";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(56, 75);
            label2.Name = "label2";
            label2.Size = new Size(83, 25);
            label2.TabIndex = 1;
            label2.Text = "BOOK ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(56, 109);
            label3.Name = "label3";
            label3.Size = new Size(115, 25);
            label3.TabIndex = 2;
            label3.Text = "BOOK NAME";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(56, 145);
            label4.Name = "label4";
            label4.Size = new Size(83, 25);
            label4.TabIndex = 3;
            label4.Text = "AUTHOR";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(56, 181);
            label5.Name = "label5";
            label5.Size = new Size(167, 25);
            label5.TabIndex = 4;
            label5.Text = "PUBLICATION YEAR";
            // 
            // txtBookID
            // 
            txtBookID.Location = new Point(267, 73);
            txtBookID.Name = "txtBookID";
            txtBookID.Size = new Size(390, 27);
            txtBookID.TabIndex = 5;
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(267, 107);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(390, 27);
            txtBookName.TabIndex = 6;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(267, 146);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(390, 27);
            txtAuthor.TabIndex = 7;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(267, 179);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(390, 27);
            txtYear.TabIndex = 8;
            // 
            // btnINSERT
            // 
            btnINSERT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnINSERT.Location = new Point(56, 246);
            btnINSERT.Name = "btnINSERT";
            btnINSERT.Size = new Size(127, 48);
            btnINSERT.TabIndex = 9;
            btnINSERT.Text = "INSERT";
            btnINSERT.UseVisualStyleBackColor = true;
            btnINSERT.Click += btnINSERT_Click;
            // 
            // btnDELETE
            // 
            btnDELETE.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDELETE.Location = new Point(237, 246);
            btnDELETE.Name = "btnDELETE";
            btnDELETE.Size = new Size(127, 48);
            btnDELETE.TabIndex = 14;
            btnDELETE.Text = "DELETE";
            btnDELETE.UseVisualStyleBackColor = true;
            btnDELETE.Click += btnDELETE_Click;
            // 
            // btnUPDATE
            // 
            btnUPDATE.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUPDATE.Location = new Point(423, 246);
            btnUPDATE.Name = "btnUPDATE";
            btnUPDATE.Size = new Size(127, 48);
            btnUPDATE.TabIndex = 15;
            btnUPDATE.Text = "UPDATE";
            btnUPDATE.UseVisualStyleBackColor = true;
            btnUPDATE.Click += btnUPDATE_Click;
            // 
            // btnEXIT
            // 
            btnEXIT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEXIT.Location = new Point(597, 246);
            btnEXIT.Name = "btnEXIT";
            btnEXIT.Size = new Size(127, 48);
            btnEXIT.TabIndex = 16;
            btnEXIT.Text = "EXIT";
            btnEXIT.UseVisualStyleBackColor = true;
            btnEXIT.Click += btnEXIT_Click;
            // 
            // dgvBook
            // 
            dgvBook.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBook.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBook.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dgvBook.Location = new Point(26, 307);
            dgvBook.Name = "dgvBook";
            dgvBook.RowHeadersWidth = 51;
            dgvBook.RowTemplate.Height = 29;
            dgvBook.Size = new Size(749, 262);
            dgvBook.TabIndex = 17;
            dgvBook.CellClick += dgvBook_CellClick;
            dgvBook.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "BOOK_ID";
            Column1.HeaderText = "Book ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.DataPropertyName = "BOOKNAME";
            Column2.HeaderText = "Book Name";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.DataPropertyName = "AUTHOR";
            Column3.HeaderText = "Author";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.DataPropertyName = "PUBLICATION_YEAR";
            Column4.HeaderText = "Publication Year";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 582);
            Controls.Add(dgvBook);
            Controls.Add(btnEXIT);
            Controls.Add(btnUPDATE);
            Controls.Add(btnDELETE);
            Controls.Add(btnINSERT);
            Controls.Add(txtYear);
            Controls.Add(txtAuthor);
            Controls.Add(txtBookName);
            Controls.Add(txtBookID);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Update Book";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBook).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtBookID;
        private TextBox txtBookName;
        private TextBox txtAuthor;
        private TextBox txtYear;
        private Button btnINSERT;
        private Button btnDELETE;
        private Button btnUPDATE;
        private Button btnEXIT;
        private DataGridView dgvBook;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}