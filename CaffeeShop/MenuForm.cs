using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using ListView = System.Windows.Forms.ListView;

namespace CaffeeShop
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        public static int[] fprice, lprice, count;
        public bool checker , checkerB = true;
        public decimal allprice = 0;

        // Nút đi tới trang của nhân viên
        private void nvfBut_Click(object sender, EventArgs e)
        {
            NhanVien formNv = new NhanVien();
            this.Hide();
            formNv.ShowDialog();
            this.Close();
        }
        // Nút tính tổng tiền cần thanh toán
        private void sumPrice_Click(object sender, EventArgs e)
        {
            decimal allprice = 0;
            for (int i = 0; i < listData.Items.Count; i++)
            {
                allprice += decimal.Parse(listData.Items[i].SubItems[3].Text);
            }
            sumTxt.Text = allprice.ToString();
            acceptBut.Enabled = true;
        }
        // Nút thanh toán
        private void acceptBut_Click(object sender, EventArgs e)
        {
            saveData(listData);
            MessageBox.Show("Xac nhan thanh toan\nSố tiền:" + allprice.ToString(), "", MessageBoxButtons.OK);
            MenuForm formLg = new MenuForm();
            this.Hide();
            formLg.ShowDialog();
            this.Close();
            
        }
        // Nút chỉnh sửa
        private void editBut_Click(object sender, EventArgs e)
        {
            if (checker == true) 
            {
                listData.Enabled = true;
                delBut.Enabled = true;
                editBut.Text = "Xong";
                checker = false;
            } else if (checker == false)
            {
                listData.Enabled = false;
                delBut.Enabled = true;
                editBut.Text = "Sửa";
                checker = true;
            }
        }
        // Nút quay về trang đăng nhập
        private void lgfBut_Click(object sender, EventArgs e)
        {
            LoginForm formLg = new LoginForm();
            this.Hide();
            formLg.ShowDialog();
            this.Close();
        }

        private void cancelBut_Click(object sender, EventArgs e)
        {
            if (checker == true)
            {
                checker = false;
                MessageBox.Show("Xác nhận xóa đơn hàng này!", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                listData.Items.Clear();
            } else if (checker == false)
            {
                checker = true;
            }
        }

        private void delBut_Click(object sender, EventArgs e)
        {
            for (int i = listData.Items.Count - 1; i >= 0; i--)
            {
                if (listData.Items[i].Selected)
                {
                    listData.Items[i].Remove();
                }
            }
        }
        public void loaddishData(FlowLayoutPanel selectDish)
        {
            FileStream fileStream = new FileStream("DishList.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(fileStream);
            string chuoi = reader.ReadLine();
            string name, costString;
            int fprice;
            while (chuoi != null)
            {
                string[] mang = chuoi.Split('|');
                name = mang[0];
                costString = mang[4];

                GroupBox dishTxt = new GroupBox();
                dishTxt.Width = 200;
                dishTxt.Height = 150;
                dishTxt.Margin= new Padding(25);
                dishTxt.Text = name;
                dishTxt.Font = new Font("Arial", 16, FontStyle.Bold);

                Label hamH = new Label();
                hamH.Text = "Hình ảnh minh họa\n" + "Giá tiền\n" +costString;
                hamH.Location = new Point(100, 30);
                hamH.Width = 90;
                hamH.Height = 110;
                hamH.BackColor = Color.White;
                hamH.BringToFront();
                hamH.Font = new Font("Arial", 10, FontStyle.Bold);

                Label cLb = new Label();
                cLb.Text = "Số lượng";
                cLb.Location = new Point(10, 50);
                cLb.Width = 80;
                cLb.Font = new Font("Arial", 10, FontStyle.Bold);

                NumericUpDown cTxt = new NumericUpDown();
                cTxt.Location = new Point(15, 80);
                cTxt.Width = 60;
                cTxt.Font = new Font("Arial", 11, FontStyle.Bold);

                System.Windows.Forms.Button selectBut = new System.Windows.Forms.Button();
                selectBut.Text = "Chọn";
                selectBut.Font = new Font("Arial", 11, FontStyle.Bold);
                selectBut.Location = new Point(15, 110);
                selectBut.FlatStyle = FlatStyle.Standard;
                selectBut.BackColor = Color.White;
                selectBut.Width = 60;
                selectBut.Height = 30;
                
                selectDish.Controls.Add(dishTxt);
                dishTxt.Controls.Add(cLb);
                dishTxt.Controls.Add(hamH);
                dishTxt.Controls.Add(cTxt);
                dishTxt.Controls.Add(selectBut);
                int cost = int.Parse(costString);
                selectBut.Click += (sender, args) =>
                {
                    int total = (int)(cost * cTxt.Value);
                    if (cTxt.Value == 0)
                    {
                        MessageBox.Show("Số lượng phải lớn hơn 0", "", MessageBoxButtons.OK);
                    } else
                    {
                        listData.Items.Add(new ListViewItem(new[] { dishTxt.Text, cost.ToString(), cTxt.Value.ToString(), total.ToString()}));
                    }
                };
                chuoi = reader.ReadLine();
            }
            reader.Close();
            fileStream.Close();
        }
        public void saveData(ListView listData)
        {
            string path = @"Statistics.txt";
            StreamWriter streamWriter = File.AppendText(path);
            for (int i = 0; i < listData.Items.Count; i++)
            {
                for (int j = 0; j < listData.Columns.Count; j++)
                {
                    streamWriter.Write(listData.Items[i].SubItems[j].Text + "|");
                }
                streamWriter.WriteLine();
            }
            streamWriter.Close();
        }
        private void MenuForm_Load(object sender, EventArgs e)
        {
            loaddishData(selectDish);
        }
        private void MenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}