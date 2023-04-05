using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaffeeShop
{
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
        }
        // Nút quay trở lại Menu
        private void mnfBut_Click(object sender, EventArgs e)
        {
            MenuForm formMenu = new MenuForm();
            this.Hide();
            formMenu.ShowDialog();
            this.Close();
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

        private void NhanVien_Load(object sender, EventArgs e)
        {
            loadStatistics(sttData);
        }
    }
}
