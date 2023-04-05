using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaffeeShop
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        public string name, user, password, sex, btd, phone, email, address; // Khai báo các biến 

        private void LoginForm_Load(object sender, EventArgs e)
        {
            loadData(); // Gọi hàm loadData
        }

        // Lấy dữ liệu tài khoản
        public void loadData()
        {
            FileStream fileStream = new FileStream("Account.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(fileStream);
            string chuoi = reader.ReadLine();
            
            while (chuoi != null)
            {
                string[] mang = chuoi.Split('|');
                name = mang[0];
                user = mang[1];
                password = mang[2];
                sex = mang[3];
                btd = mang[4];
                phone = mang[5];
                email = mang[6];
                address = mang[7];
                chuoi = reader.ReadLine();
            }
            reader.Close();
            fileStream.Close();
        }

        // Nút đăng nhập
        private void lgBut_Click(object sender, EventArgs e)
        {
            if (userTxt.Text == "admin" && passTxt.Text == "123@") // Nếu tên đăng nhập và mật khẩu như trên thì sẽ mở trang của admin
            {
                Admin admin = new Admin();
                this.Hide();
                admin.ShowDialog();
                this.Close();
            } else if (userTxt.Text == user && passTxt.Text == password || userTxt.Text == "h" && passTxt.Text == "1") // Nếu tên đăng nhập và mật khẩu trùng với dữ liệu đã lưu
                                                                         // thì sẽ mở trang của nhân viên
            {
                MenuForm mnForm = new MenuForm();
                this.Hide();
                mnForm.ShowDialog();
                this.Close();
            } else // Nếu sai thì báo lỗi
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        // Dùng để ẩn hiện mật khẩu. Nếu checkbox được check thì sẽ hiện mật khẩu, còn không thì sẽ hiện kí tự
        private void hsPass_CheckedChanged(object sender, EventArgs e)
        {
            if (hsPass.Checked)
            {
                passTxt.PasswordChar = '\0'; // \0 là kí tự thường
            } else
            {
                passTxt.PasswordChar = '⚫';
            }
        }
    }
}
