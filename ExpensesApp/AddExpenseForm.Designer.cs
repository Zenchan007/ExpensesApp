namespace ExpensesApp
{
    partial class AddExpenseForm
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
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cbbNameExpenese = new System.Windows.Forms.ComboBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddExpense = new System.Windows.Forms.Button();
            this.lblWnNameExp = new System.Windows.Forms.Label();
            this.lblWnAmountExp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(75, 61);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(257, 22);
            this.dtpDate.TabIndex = 0;
            // 
            // cbbNameExpenese
            // 
            this.cbbNameExpenese.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbNameExpenese.FormattingEnabled = true;
            this.cbbNameExpenese.Items.AddRange(new object[] {
            "Tiền Nhà",
            "Tiền Điện Nước",
            "Tiền Ăn",
            "Tiền Thuốc",
            "Other"});
            this.cbbNameExpenese.Location = new System.Drawing.Point(75, 136);
            this.cbbNameExpenese.Name = "cbbNameExpenese";
            this.cbbNameExpenese.Size = new System.Drawing.Size(257, 24);
            this.cbbNameExpenese.TabIndex = 1;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(75, 222);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(257, 22);
            this.txtAmount.TabIndex = 2;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(75, 301);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(257, 89);
            this.txtNote.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên Chi Tiêu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Số Tiền";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Chú Thích";
            // 
            // btnAddExpense
            // 
            this.btnAddExpense.Location = new System.Drawing.Point(257, 411);
            this.btnAddExpense.Name = "btnAddExpense";
            this.btnAddExpense.Size = new System.Drawing.Size(75, 23);
            this.btnAddExpense.TabIndex = 7;
            this.btnAddExpense.Text = "Thêm";
            this.btnAddExpense.UseVisualStyleBackColor = true;
            this.btnAddExpense.Click += new System.EventHandler(this.btnAddExpense_Click);
            // 
            // lblWnNameExp
            // 
            this.lblWnNameExp.AutoSize = true;
            this.lblWnNameExp.ForeColor = System.Drawing.Color.Red;
            this.lblWnNameExp.Location = new System.Drawing.Point(75, 167);
            this.lblWnNameExp.Name = "lblWnNameExp";
            this.lblWnNameExp.Size = new System.Drawing.Size(44, 16);
            this.lblWnNameExp.TabIndex = 8;
            this.lblWnNameExp.Text = "label4";
            this.lblWnNameExp.Visible = false;
            // 
            // lblWnAmountExp
            // 
            this.lblWnAmountExp.AutoSize = true;
            this.lblWnAmountExp.ForeColor = System.Drawing.Color.Red;
            this.lblWnAmountExp.Location = new System.Drawing.Point(75, 251);
            this.lblWnAmountExp.Name = "lblWnAmountExp";
            this.lblWnAmountExp.Size = new System.Drawing.Size(44, 16);
            this.lblWnAmountExp.TabIndex = 9;
            this.lblWnAmountExp.Text = "label5";
            this.lblWnAmountExp.Visible = false;
            // 
            // AddExpenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 460);
            this.Controls.Add(this.lblWnAmountExp);
            this.Controls.Add(this.lblWnNameExp);
            this.Controls.Add(this.btnAddExpense);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.cbbNameExpenese);
            this.Controls.Add(this.dtpDate);
            this.Name = "AddExpenseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddExpenseForm";
            this.Load += new System.EventHandler(this.AddExpenseForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ComboBox cbbNameExpenese;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddExpense;
        private System.Windows.Forms.Label lblWnNameExp;
        private System.Windows.Forms.Label lblWnAmountExp;
    }
}