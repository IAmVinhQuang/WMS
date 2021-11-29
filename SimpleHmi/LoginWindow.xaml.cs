using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SimpleHmi
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {

            /*
             * Cách lấy " @"Data Source=DESKTOP-RG2IF9P\SQLEXPRESS;Initial Catalog=LoginDB;Integrated Security=True; "
             * Vào Server Explorer -> Chọn Data Connection (nếu chưa kết nối thì chọn COnnect to Database)
             * Mục Server name lấy từ SQL Server 
             * Tiếp tục chọn Advanced
             * Cuối cùng Copy tất cả từ ô cuối cùng.
             * 
             * Sau khi làm xong tất cả chúc mừng bạn đã có thể liên kết với SQL Server. 
             */
            //tạo kết nối với sql //
            SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-RG2IF9P\SQLEXPRESS;Initial Catalog=LoginDB;Integrated Security=True;");

            try
            {
                //Kiểm tra sql đóng hay mở. nếu đóng sẽ mở
                if (sqlCon.State == System.Data.ConnectionState.Closed)
                    //Mở SQL Sever
                    sqlCon.Open();

                //Khai báo truy vấn từ SQL Server
                //Lựa chọn một UserID trong tblUser từ tên Username và Password
                string query = "SELECT COUNT(1) FROM tblUser WHERE Username=@Username AND Password=@Password";
                SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                sqlCmd.CommandType = System.Data.CommandType.Text;
                sqlCmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                sqlCmd.Parameters.AddWithValue("@Password", txtPassword.Password);
                int count = Convert.ToInt32(sqlCmd.ExecuteScalar());

                //Nếu điều kiện đúng thì vào Trang chính, sai thì báo lỗi
                if (count == 1)
                {
                    Views.MainWindow MainWindow = new Views.MainWindow();
                    MainWindow.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Username or Password is Incorrect.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }


        }
    }
}
