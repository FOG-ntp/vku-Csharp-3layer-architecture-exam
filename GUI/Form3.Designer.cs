namespace GUI
{
    partial class Form3
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
            txtBookName = new TextBox();
            label2 = new Label();
            dgvBook = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvBook).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(85, 36);
            label1.Name = "label1";
            label1.Size = new Size(125, 20);
            label1.TabIndex = 0;
            label1.Text = "Enter Book Name";
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(227, 29);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(404, 27);
            txtBookName.TabIndex = 1;
            txtBookName.TextChanged += txtBookName_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 106);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 2;
            label2.Text = "Results:";
            // 
            // dgvBook
            // 
            dgvBook.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBook.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBook.Location = new Point(12, 129);
            dgvBook.Name = "dgvBook";
            dgvBook.RowHeadersWidth = 51;
            dgvBook.RowTemplate.Height = 29;
            dgvBook.Size = new Size(776, 309);
            dgvBook.TabIndex = 3;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvBook);
            Controls.Add(label2);
            Controls.Add(txtBookName);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Search by Book Name";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBook).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtBookName;
        private Label label2;
        private DataGridView dgvBook;
    }
}