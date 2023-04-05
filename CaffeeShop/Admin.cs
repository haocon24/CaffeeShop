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
using static System.Windows.Forms.DataFormats;

namespace CaffeeShop
{
    public partial class Admin : Form
    {
        public MenuForm formMenu;
        public Admin()
        {
            InitializeComponent();
        }
        private void mnfBut_Click(object sender, EventArgs e)
        {
            formMenu = new MenuForm();
            this.Hide();
            formMenu.ShowDialog();
            this.Close();
        }
        // Nút thêm thông 
        private void addNv_Click(object sender, EventArgs e)
        {
            if (nameTxt.Text == "" || userTxt.Text == "" || passTxt.Text == "" || sexTxt.Text == "" || btdTxt.Text == "" || phoneTxt.Text == "" || emailTxt.Text == "" || addressTxt.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } else if (phoneTxt.Text.Length < 10) // Kiểm tra độ dài số 
            {
                MessageBox.Show("Vui lòng nhập đúng số điện thoại!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } else
            {
                nvdataGridView.Rows.Add(nameTxt.Text, userTxt.Text, passTxt.Text, sexTxt.Text, btdTxt.Text, phoneTxt.Text, emailTxt.Text, addressTxt.Text);
                nameTxt.Text = "";
                nameTxt.Focus();
                userTxt.Text = "";
                passTxt.Text = "";
                sexTxt.Text = "";
                btdTxt.Text = "";
                phoneTxt.Text = "";
                emailTxt.Text = "";
                addressTxt.Text = "";
            }
        }
        // Nút chỉnh sửa thông tin
        private void editBut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Xác nhận chỉnh sửa thông tin!", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            nvdataGridView.Rows[nvdataGridView.CurrentRow.Index].Cells[0].Value = nameTxt.Text;
            nvdataGridView.Rows[nvdataGridView.CurrentRow.Index].Cells[1].Value = userTxt.Text;
            nvdataGridView.Rows[nvdataGridView.CurrentRow.Index].Cells[2].Value = passTxt.Text;
            nvdataGridView.Rows[nvdataGridView.CurrentRow.Index].Cells[3].Value = sexTxt.Text;
            nvdataGridView.Rows[nvdataGridView.CurrentRow.Index].Cells[4].Value = btdTxt.Text;
            nvdataGridView.Rows[nvdataGridView.CurrentRow.Index].Cells[5].Value = phoneTxt.Text;
            nvdataGridView.Rows[nvdataGridView.CurrentRow.Index].Cells[6].Value = emailTxt.Text;
            nvdataGridView.Rows[nvdataGridView.CurrentRow.Index].Cells[7].Value = addressTxt.Text;
        }
        // Nút hủy thông tin vừa nhập
        private void cancelBut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Xác nhận hủy!", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            nameTxt.Text = "";
            nameTxt.Focus();
            userTxt.Text = "";
            passTxt.Text = "";
            sexTxt.Text = "";
            btdTxt.Text = "";
            phoneTxt.Text = "";
            emailTxt.Text = "";
            addressTxt.Text = "";
        }

        // Bắt buộc định dạng của số điện thoại phải là số
        private void sdtTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        // Xóa thông tin
        private void delBut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Xác nhận xóa thông tin nhân viên!", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (nvdataGridView.Rows.Count >= 0)
            {
                nvdataGridView.Rows.RemoveAt(nvdataGridView.CurrentCell.RowIndex);
            }
        }

        // Lưu dữ liệu từ DataGridView sang file Account.txt
        public void setData(DataGridView nvdataGridView)
        {
            FileStream fileStream = new FileStream("Account.txt", FileMode.Create, FileAccess.Write);
            StreamWriter streamWriter = new StreamWriter(fileStream);
            for( int i = 0; i < nvdataGridView.Rows.Count - 1; i++)
            {
                for (int j = 0; j < nvdataGridView.Columns.Count; j++)
                {
                    streamWriter.Write(nvdataGridView.Rows[i].Cells[j].Value + "|");
                }
                streamWriter.WriteLine();
            }
            streamWriter.Close();
            fileStream.Close();
        }
        // Lấy dữ liệu từ file Account.txt sang DataGridView
        public void loadData(DataGridView nvdataGridView)
        {
            FileStream fileStream = new FileStream("Account.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(fileStream);
            string chuoi = reader.ReadLine();
            string name, user, password, sex, birth, phone, email, address;
            while (chuoi != null)
            {
                string[] mang = chuoi.Split('|');
                name = mang[0];
                user = mang[1];
                password = mang[2];
                sex = mang[3];
                birth = mang[4];
                phone = mang[5];
                email = mang[6];
                address = mang[7];
                nvdataGridView.Rows.Add(name, user, password, sex, birth, phone, email, address);
                chuoi = reader.ReadLine();
            }
            reader.Close();
            fileStream.Close();
        }

        // Lấy dữ liệu từ DataGridView sang TextBox
        private void nvdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0 && nameTxt.Text != null)
            {
                nameTxt.Text = nvdataGridView.Rows[index].Cells[0].Value.ToString();
                userTxt.Text = nvdataGridView.Rows[index].Cells[1].Value.ToString();
                passTxt.Text = nvdataGridView.Rows[index].Cells[2].Value.ToString();
                sexTxt.Text = nvdataGridView.Rows[index].Cells[3].Value.ToString();
                btdTxt.Text = nvdataGridView.Rows[index].Cells[4].Value.ToString();
                phoneTxt.Text = nvdataGridView.Rows[index].Cells[5].Value.ToString();
                emailTxt.Text = nvdataGridView.Rows[index].Cells[6].Value.ToString();
                addressTxt.Text = nvdataGridView.Rows[index].Cells[7].Value.ToString();
            }
        }
        public void setdishData(DataGridView dishGridView)
        {
            FileStream fileStream = new FileStream("DishList.txt", FileMode.Create, FileAccess.Write);
            StreamWriter streamWriter = new StreamWriter(fileStream);
            for (int i = 0; i < dishGridView.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dishGridView.Columns.Count; j++)
                {
                    streamWriter.Write(dishGridView.Rows[i].Cells[j].Value + "|");
                }
                streamWriter.WriteLine();
            }
            streamWriter.Close();
            fileStream.Close();
        }
        // Lấy dữ liệu từ file sang DataGridView
        public void loaddishData(DataGridView dishGridView)
        {
            FileStream fileStream = new FileStream("DishList.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(fileStream);
            string chuoi = reader.ReadLine();
            string name, user, password, sex, birth, phone;
            while (chuoi != null)
            {
                string[] mang = chuoi.Split('|');
                name = mang[0];
                user = mang[1];
                password = mang[2];
                sex = mang[3];
                birth = mang[4];
                phone = mang[5];
                dishGridView.Rows.Add(name, user, password, sex, birth, phone);
                chuoi = reader.ReadLine();
            }
            reader.Close();
            fileStream.Close();
        }
        public void loadStatistics(DataGridView sttData)
        {
            FileStream fileStream = new FileStream("Statistics.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(fileStream);
            string chuoi = reader.ReadLine();
            string name, fprice, selled, lprice;
            while (chuoi != null)
            {
                string[] mang = chuoi.Split('|');   
                name = mang[0];
                fprice = mang[1];
                selled = mang[2];
                lprice = mang[3];
                sttData.Rows.Add(name, selled, "", "", fprice, lprice);
                chuoi = reader.ReadLine();
            }
            reader.Close();
            fileStream.Close();
        }
        private void addDishBut_Click(object sender, EventArgs e)
        {
            if (nDishTxt.Text == "" || cDishTxt.Text == "" || sDishTxt.Text == "" || rDishTxt.Text == "" || coDishTxt.Text == "" || ciDishTxt.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                dishGridView.Rows.Add(nDishTxt.Text, cDishTxt.Text, sDishTxt.Text, rDishTxt.Text, coDishTxt.Text, ciDishTxt.Text);
                nDishTxt.Text = "";
                nDishTxt.Focus();
                cDishTxt.Text = "";
                sDishTxt.Text = "";
                rDishTxt.Text = "";
                coDishTxt.Text = "";
                ciDishTxt.Text = "";
                MessageBox.Show("Đã thêm món mới. \nVui lòng khởi động lại để cập nhật!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void editDishBut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Xác nhận chỉnh sửa thông tin!", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            dishGridView.Rows[dishGridView.CurrentRow.Index].Cells[0].Value = nDishTxt.Text;
            dishGridView.Rows[dishGridView.CurrentRow.Index].Cells[1].Value = cDishTxt.Text;
            dishGridView.Rows[dishGridView.CurrentRow.Index].Cells[2].Value = sDishTxt.Text;
            dishGridView.Rows[dishGridView.CurrentRow.Index].Cells[3].Value = rDishTxt.Text;
            dishGridView.Rows[dishGridView.CurrentRow.Index].Cells[4].Value = coDishTxt.Text;
            dishGridView.Rows[dishGridView.CurrentRow.Index].Cells[5].Value = ciDishTxt.Text;
        }

        private void delDishBut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Xác nhận xóa thông tin món ăn!", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (dishGridView.Rows.Count >= 0)
            {
                dishGridView.Rows.RemoveAt(dishGridView.CurrentCell.RowIndex);
            }
        }

        private void ccDishBut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Xác nhận hủy!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            nDishTxt.Text = "";
            nDishTxt.Focus();
            cDishTxt.Text = "";
            sDishTxt.Text = "";
            rDishTxt.Text = "";
            coDishTxt.Text = "";
            ciDishTxt.Text = "";
        }

        private void dishGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0 && nDishTxt.Text != null)
            {
                nDishTxt.Text = dishGridView.Rows[index].Cells[0].Value.ToString();
                cDishTxt.Text = dishGridView.Rows[index].Cells[1].Value.ToString();
                sDishTxt.Text = dishGridView.Rows[index].Cells[2].Value.ToString();
                rDishTxt.Text = dishGridView.Rows[index].Cells[3].Value.ToString();
                coDishTxt.Text = dishGridView.Rows[index].Cells[4].Value.ToString();
                ciDishTxt.Text = dishGridView.Rows[index].Cells[5].Value.ToString();
            }
        }
        
        private void Admin_Load(object sender, EventArgs e)
        {
            loadData(nvdataGridView);
            loaddishData(dishGridView);
            loadStatistics(sttData);
        }

        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void rDishTxt_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(Math.Round(cDishTxt.Value, 0));
            int sell = Convert.ToInt32(Math.Round(sDishTxt.Value, 0));
            int remain = Convert.ToInt32(Math.Round(rDishTxt.Value, 0));
            if (count >= sell && sell > 0)
            {
                remain = count - sell;
                rDishTxt.Value = remain;
            } else
            {
                MessageBox.Show("Số lượng bán ra phải nhỏ hơn hoặc bằng số lượng sẵn có!", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                sDishTxt.Value = count;
            }
        }

        private void Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            setData(nvdataGridView);
            setdishData(dishGridView);
        }
    }
}
