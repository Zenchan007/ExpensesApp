namespace ExpensesApp
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.xemChiTieuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoatToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cbbExpenseName = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dtExpense = new System.Windows.Forms.DataGridView();
            this.btnAddExpense = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbDay = new System.Windows.Forms.ComboBox();
            this.cbbMonth = new System.Windows.Forms.ComboBox();
            this.btnDetailsMonth = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtExpense)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xemChiTieuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(648, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // xemChiTieuToolStripMenuItem
            // 
            this.xemChiTieuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thoatToolStripMenuItem1});
            this.xemChiTieuToolStripMenuItem.Name = "xemChiTieuToolStripMenuItem";
            this.xemChiTieuToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.xemChiTieuToolStripMenuItem.Text = "Xem chi tieu";
            // 
            // thoatToolStripMenuItem1
            // 
            this.thoatToolStripMenuItem1.Name = "thoatToolStripMenuItem1";
            this.thoatToolStripMenuItem1.Size = new System.Drawing.Size(130, 26);
            this.thoatToolStripMenuItem1.Text = "Thoat";
            this.thoatToolStripMenuItem1.Click += new System.EventHandler(this.thoatToolStripMenuItem1_Click);
            // 
            // cbbExpenseName
            // 
            this.cbbExpenseName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbExpenseName.FormattingEnabled = true;
            this.cbbExpenseName.Items.AddRange(new object[] {
            "",
            "Tiền Nhà",
            "Tiền Điện Nước",
            "Tiền Ăn",
            "Tiền Thuốc",
            "Other"});
            this.cbbExpenseName.Location = new System.Drawing.Point(12, 112);
            this.cbbExpenseName.Name = "cbbExpenseName";
            this.cbbExpenseName.Size = new System.Drawing.Size(174, 24);
            this.cbbExpenseName.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(525, 112);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 24);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Tìm Kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtExpense
            // 
            this.dtExpense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtExpense.Location = new System.Drawing.Point(12, 153);
            this.dtExpense.Name = "dtExpense";
            this.dtExpense.RowHeadersWidth = 51;
            this.dtExpense.RowTemplate.Height = 24;
            this.dtExpense.Size = new System.Drawing.Size(594, 269);
            this.dtExpense.TabIndex = 7;
            this.dtExpense.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtExpense_CellClick);
            // 
            // btnAddExpense
            // 
            this.btnAddExpense.Location = new System.Drawing.Point(498, 439);
            this.btnAddExpense.Name = "btnAddExpense";
            this.btnAddExpense.Size = new System.Drawing.Size(108, 59);
            this.btnAddExpense.TabIndex = 8;
            this.btnAddExpense.Text = "Thêm Chi Tiêu";
            this.btnAddExpense.UseVisualStyleBackColor = true;
            this.btnAddExpense.Click += new System.EventHandler(this.btnAddExpense_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Chọn chi tiêu";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(429, 113);
            this.txtYear.Multiline = true;
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(80, 24);
            this.txtYear.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(426, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Năm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(324, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Tháng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Ngày";
            // 
            // cbbDay
            // 
            this.cbbDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDay.FormattingEnabled = true;
            this.cbbDay.Items.AddRange(new object[] {
            "",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cbbDay.Location = new System.Drawing.Point(227, 112);
            this.cbbDay.Name = "cbbDay";
            this.cbbDay.Size = new System.Drawing.Size(80, 24);
            this.cbbDay.TabIndex = 17;
            // 
            // cbbMonth
            // 
            this.cbbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMonth.FormattingEnabled = true;
            this.cbbMonth.Items.AddRange(new object[] {
            "",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cbbMonth.Location = new System.Drawing.Point(327, 112);
            this.cbbMonth.Name = "cbbMonth";
            this.cbbMonth.Size = new System.Drawing.Size(80, 24);
            this.cbbMonth.TabIndex = 18;
            // 
            // btnDetailsMonth
            // 
            this.btnDetailsMonth.Location = new System.Drawing.Point(379, 439);
            this.btnDetailsMonth.Name = "btnDetailsMonth";
            this.btnDetailsMonth.Size = new System.Drawing.Size(103, 59);
            this.btnDetailsMonth.TabIndex = 19;
            this.btnDetailsMonth.Text = "Xem thống kê";
            this.btnDetailsMonth.UseVisualStyleBackColor = true;
            this.btnDetailsMonth.Click += new System.EventHandler(this.btnDetailsMonth_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(260, 439);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(103, 59);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(648, 542);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnDetailsMonth);
            this.Controls.Add(this.cbbMonth);
            this.Controls.Add(this.cbbDay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddExpense);
            this.Controls.Add(this.dtExpense);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cbbExpenseName);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtExpense)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xemChiTieuToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbbExpenseName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dtExpense;
        private System.Windows.Forms.Button btnAddExpense;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem thoatToolStripMenuItem1;
        private System.Windows.Forms.ComboBox cbbDay;
        private System.Windows.Forms.ComboBox cbbMonth;
        private System.Windows.Forms.Button btnDetailsMonth;
        private System.Windows.Forms.Button btnDelete;
    }
}

