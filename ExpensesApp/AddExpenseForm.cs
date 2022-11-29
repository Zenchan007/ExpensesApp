using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpensesApp
{
    public partial class AddExpenseForm : Form
    {
        private Form1 form1 = new Form1();
        public AddExpenseForm()
        {
            InitializeComponent();
        }
        public int userIDAdd {get; set; }
        public DateTime dateTimepicker { get; set; }
        private void btnAddExpense_Click(object sender, EventArgs e)
        {
            var db =new  ExpenseDBDataContext();
            Expense expense = new Expense();
            if(cbbNameExpenese.Text != "")
            {
                expense.ExpenseName = cbbNameExpenese.Text;
            }
            else
            {
                lblWnNameExp.Text = "Vui lòng chọn loại tiền!";
                lblWnNameExp.Visible = true;
            }
            if(txtAmount.Text != "")
            {
                expense.ExpenseAmount = Double.Parse(txtAmount.Text);
            }
            else
            {
                lblWnAmountExp.Text = "Vui lòng điền số tiền!";
                lblWnAmountExp.Visible = true;
            }
            if(txtAmount.Text != "" && cbbNameExpenese.Text != "")
            {
                expense.ExpenseNote = txtNote.Text;
                expense.ExpenseDate = dtpDate.Value.ToString("dd,MM,yyyy");
                expense.UserID = userIDAdd;
                db.Expenses.InsertOnSubmit(expense);
                db.SubmitChanges();
                MessageBox.Show("Đã thêm thành công chi tiêu vào bộ nhớ!!!");
                this.Close();
            }
            
        }
        private void AddExpenseForm_Load(object sender, EventArgs e)
        {
            dtpDate.Value = dateTimepicker;
        }
    }
}
