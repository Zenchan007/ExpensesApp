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
    public partial class loginForm : Form
    {
        public static string userName;
        public loginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtNameuser.Text != "" && txtPassword.Text != "")
            {
                lblwn1.Visible = false;
                lblwn2.Visible = false;
                var data = new ExpenseDBDataContext();
                var allUser = (from us in data.Users
                               where us.UserName == txtNameuser.Text.ToString() && us.PassWord == Convert.ToBase64String(Encoding.UTF8.GetBytes(txtPassword.Text.ToString()))
                               select us);
                if (allUser.Count() != 0)
                {
                    var x = allUser.ToList()[0];
                    Form1 form1 = new Form1()
                    {
                        userID = x.UserID
                    };
                    userName = txtNameuser.Text.ToString();
                    form1.ShowDialog();
                    this.Hide();
                }
                else
                {
                    lblwn1.Text = "Tài khoản hoặc mật khẩu không đúng.Vui lòng kiểm tra lại!!";
                    lblwn1.Visible = true;
                    txtPassword.Text = "";
                }
            }
            else
            {
                if (txtNameuser.Text == "")
                {
                    lblwn1.Visible = true;
                    lblwn1.Text = "Vui lòng điền email!";
                }
                if (txtPassword.Text == "")
                {
                    lblwn2.Visible = true;
                    lblwn2.Text = "Vui lòng điền mật khẩu!";
                }
            }
            
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            lblwn1.Visible = false;
            lblwn2.Visible = false;
            if (txtNameuser.Text != "" && txtPassword.Text != "")
            {
                var data = new ExpenseDBDataContext();
                var allUser = (from us in data.Users
                               where us.UserName == txtNameuser.Text.ToString()
                               select us);
                
                    if (allUser.Count() != 0)
                    {
                        lblwn2.Text = "Tài Khoản Đã Tồn Tại!";
                        lblwn2.Visible = true;
                    }
                    else
                    {
                        User user = new User();
                        user.UserName = txtNameuser.Text.ToString();
                        user.PassWord = Convert.ToBase64String(Encoding.UTF8.GetBytes(txtPassword.Text.ToString()));
                        data.Users.InsertOnSubmit(user);
                        data.SubmitChanges();
                        MessageBox.Show("Đăng ký thành công tài khoản!! Vui lòng đăng nhập lại!!!");
                        txtNameuser.Text = "";
                        txtPassword.Text = "";
                    }
                
            }
            else
            {
                if(txtNameuser.Text == "")
                {
                    lblwn1.Visible = true;
                    lblwn1.Text = "Vui lòng điền email!";
                }
                if (txtPassword.Text == "")
                {
                    lblwn2.Visible = true;
                    lblwn2.Text = "Vui lòng điền mật khẩu!";
                }

            }

        }

        private void loginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
