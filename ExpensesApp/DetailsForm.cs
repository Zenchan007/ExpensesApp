using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
namespace ExpensesApp
{
    public partial class DetailsForm : Form
    {

        public int DetailsUserID
        {
            set;get;
        }
        public DetailsForm()
        {
            InitializeComponent();
        }
        public DetailsForm(string month, string year, int dtuserid)
        {
            DetailsMonth = month;
            DetailsYear = year;
            DetailsUserID = dtuserid;
            InitializeComponent();
            if (totalItemMonth("Tiền Ăn") != 0)
            {
                pieChartItem.Series["s1"].Points.AddXY("Tiền Ăn: ", totalItemMonth("Tiền Ăn").ToString());
            }
            if (totalItemMonth("Tiền Nhà") != 0)
            {
                pieChartItem.Series["s1"].Points.AddXY("Tiền Nhà: " , totalItemMonth("Tiền Nhà").ToString());
            }
            if (totalItemMonth("Tiền Điện Nước") != 0)
            {
                pieChartItem.Series["s1"].Points.AddXY("Tiền Điện Nước: " , totalItemMonth("Tiền Điện Nước").ToString());
            }
            if (totalItemMonth("Tiền Thuốc") != 0)
            {
                pieChartItem.Series["s1"].Points.AddXY("Tiền Thuốc: " , totalItemMonth("Tiền Thuốc").ToString());
            }
            if (totalItemMonth("Other") != 0)
            {
                pieChartItem.Series["s1"].Points.AddXY("Other: ", totalItemMonth("Other").ToString());

            }
            lblTitleChart.Text = "Biểu đồ tháng " + DetailsMonth + " năm " + DetailsYear;
        }

        public string DetailsMonth
        {
            get;
            set;
        }
        public string DetailsYear
        {
            set;
            get;
        }
        public double totalItemMonth(string nameItem)
        {
            
            double total = 0;
            var data = new ExpenseDBDataContext();
            string dateSearch = DetailsMonth + "," + DetailsYear;
            var sqlData = from dt in data.Expenses
                          where SqlMethods.Like(dt.ExpenseDate, "%" + dateSearch + "%") && SqlMethods.Like(dt.ExpenseName, "%" + nameItem + "%") && DetailsUserID == dt.UserID
                          select new
                          {
                              dt.ExpenseName,
                              dt.ExpenseAmount,
                              dt.ExpenseDate
                          };
            
            foreach (var i in sqlData.ToList())
            {
                total += i.ExpenseAmount;
            }
            return total;
        }

        private void DetailsForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            sendEmail();
        }
        public void sendEmail()
        {
            try
            {
                MailMessage mail = new MailMessage("testingappbyzenchan@gmail.com", loginForm.userName)
                {
                    Subject = "Báo Cáo Chi Tiêu Trong Tháng " + DetailsMonth + " Năm " + DetailsYear,
                    Body = "<strong>Gửi bạn báo cáo trong tháng</strong>" + "<br>Tiền Điện Nước trong tháng đã tiêu là:" + totalItemMonth("Tiền Điện Nước") + "$" +  
                    "<br>Tiền Nhà tháng đã tiêu là:" + totalItemMonth("Tiền Nhà") + "$" +
                    "<br>Tiền Thuốc trong tháng đã tiêu là:" + totalItemMonth("Tiền Thuốc") + "$" +
                    "<br>Tiền Ăn Nước trong tháng đã tiêu là:" + totalItemMonth("Ăn") + "$" +
                    "<br>Các loại tiền khác là:" + totalItemMonth("Other") + "$" 
                }; 
                mail.IsBodyHtml = true;
                SmtpClient client = new SmtpClient();
                client.Host = "smtp.gmail.com";
                client.UseDefaultCredentials = false;
                client.Port = 587;
                client.Credentials = new System.Net.NetworkCredential("testingappbyzenchan@gmail.com", "tibdquzztykrdaco");
                client.EnableSsl = true;
                client.Send(mail);
                MessageBox.Show("Đã gửi thành công báo cáo về mail của bạn!! Check Email nhé");
            }catch(Exception e)
            {
                MessageBox.Show("Có lỗi, mail chưa được gửi đi!!!");
            }
              
        }
    }
}
