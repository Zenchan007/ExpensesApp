using System;
using System.Data;
using System.Data.Linq.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace ExpensesApp
{
    public partial class Form1 : Form
    {

        
        public Form1()
        {
            InitializeComponent();
        }

        public int userID
        {
            set;get;
        }
        private void btnAddExpense_Click(object sender, EventArgs e)
        {
            btnDelete.Visible = false;
            AddExpenseForm addExpenseForm = new AddExpenseForm()
            {
                userIDAdd = userID,
                dateTimepicker = new DateTime(Int32.Parse(txtYear.Text.ToString()), Int32.Parse(cbbMonth.Text.ToString()), Int32.Parse(cbbDay.Text.ToString()))
                
            };
            addExpenseForm.ShowDialog();
            loadData();
            this.Refresh();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnDelete.Visible = false;
            cbbDay.Text = DateTime.Now.ToString("dd");
            cbbMonth.Text = DateTime.Now.ToString("MM");
            txtYear.Text = DateTime.Now.ToString("yyyy");
            loadData();
        }

        private void loadData()
        {
            String dateForm = cbbDay.Text + "," + cbbMonth.Text + "," + txtYear.Text;
            var data = new ExpenseDBDataContext();
            var sqlData = from dt in data.Expenses
                          where SqlMethods.Like(dt.ExpenseDate, "%" + dateForm + "%") && dt.UserID == userID
                          select new
                          {
                              dt.ExpenseID,
                              dt.ExpenseName,
                              dt.ExpenseAmount,
                              dt.ExpenseDate
                          };
            dtExpense.DataSource = sqlData;
            dtExpense.Columns["ExpenseID"].Visible = false;
            dtExpense.AutoSizeColumnsMode =
    DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void btnDetailsMonth_Click(object sender, EventArgs e)
        {
            btnDelete.Visible = false;
            DetailsForm detailsForm = new DetailsForm(cbbMonth.Text.ToString(), txtYear.Text.ToString(), userID);
           
            detailsForm.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            btnDelete.Visible = false;
            var data = new ExpenseDBDataContext();
            
            if (cbbMonth.Text != "")
            {
                String dateSearch = cbbDay.Text + "," + cbbMonth.Text + "," + txtYear.Text;
                var sqlData = from dt in data.Expenses
                              where SqlMethods.Like(dt.ExpenseDate, "%" + dateSearch + "%") && SqlMethods.Like(dt.ExpenseName, "%" + cbbExpenseName.Text + "%") && userID == dt.UserID
                              select new
                              {
                                  dt.ExpenseID,
                                  dt.ExpenseName,
                                  dt.ExpenseAmount,
                                  dt.ExpenseDate
                              };
                dtExpense.DataSource = sqlData;
                dtExpense.Columns["ExpenseID"].Visible = false;
                dtExpense.AutoSizeColumnsMode =
        DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                var sqlData = from dt in data.Expenses
                              where SqlMethods.Like(dt.ExpenseDate, cbbDay.Text + "%") && SqlMethods.Like(dt.ExpenseDate, "%" + txtYear.Text) && SqlMethods.Like(dt.ExpenseName, "%" + cbbExpenseName.Text + "%") && userID == dt.UserID
                              select new
                              { 
                                  dt.ExpenseID,
                                  dt.ExpenseName,
                                  dt.ExpenseAmount,
                                  dt.ExpenseDate
                              };
                dtExpense.DataSource = sqlData;
                dtExpense.Columns["ExpenseID"].Visible = false;
                dtExpense.AutoSizeColumnsMode =
        DataGridViewAutoSizeColumnsMode.Fill;
            }
            dtExpense.Sort(dtExpense.Columns["ExpenseDate"], System.ComponentModel.ListSortDirection.Ascending);
        }

        private void dtExpense_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDelete.Visible = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dtExpense.SelectedRows)
            {
                
                
                var data = new ExpenseDBDataContext();
                if (dtExpense.SelectedCells.Count > 0)
                {
                    int selectedrowindex = dtExpense.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dtExpense.Rows[selectedrowindex];
                    string cellValue = Convert.ToString(selectedRow.Cells["ExpenseID"].Value);
                    var x = (from dt in data.Expenses
                             where dt.ExpenseID == Int32.Parse(cellValue)
                             select dt).FirstOrDefault();
                    if(x != null)
                    {
                        data.Expenses.DeleteOnSubmit(x);
                        data.SubmitChanges();
                    }
                }
                dtExpense.Rows.RemoveAt(row.Index);
            }
        }

        private void thoatToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
