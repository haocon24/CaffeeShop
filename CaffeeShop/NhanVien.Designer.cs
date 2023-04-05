namespace CaffeeShop
{
    partial class NhanVien
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
            this.mnfBut = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.dataPage = new System.Windows.Forms.TabPage();
            this.sttData = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.dataPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sttData)).BeginInit();
            this.SuspendLayout();
            // 
            // mnfBut
            // 
            this.mnfBut.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mnfBut.Location = new System.Drawing.Point(862, 11);
            this.mnfBut.Name = "mnfBut";
            this.mnfBut.Size = new System.Drawing.Size(104, 28);
            this.mnfBut.TabIndex = 5;
            this.mnfBut.Text = "Trở lại Menu";
            this.mnfBut.UseVisualStyleBackColor = true;
            this.mnfBut.Click += new System.EventHandler(this.mnfBut_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.dataPage);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(960, 637);
            this.tabControl1.TabIndex = 6;
            // 
            // dataPage
            // 
            this.dataPage.BackColor = System.Drawing.Color.RosyBrown;
            this.dataPage.Controls.Add(this.sttData);
            this.dataPage.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataPage.Location = new System.Drawing.Point(4, 29);
            this.dataPage.Name = "dataPage";
            this.dataPage.Padding = new System.Windows.Forms.Padding(3);
            this.dataPage.Size = new System.Drawing.Size(952, 604);
            this.dataPage.TabIndex = 0;
            this.dataPage.Text = "Thống kê";
            // 
            // sttData
            // 
            this.sttData.BackgroundColor = System.Drawing.SystemColors.Control;
            this.sttData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sttData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.sttData.Enabled = false;
            this.sttData.Location = new System.Drawing.Point(0, 272);
            this.sttData.Name = "sttData";
            this.sttData.RowHeadersVisible = false;
            this.sttData.RowTemplate.Height = 25;
            this.sttData.Size = new System.Drawing.Size(703, 332);
            this.sttData.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Tên món";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Số lượng";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Đã bán";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Còn lại";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Giá bán";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Tổng giá";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // NhanVien
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.mnfBut);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "NhanVien";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NhanVien";
            this.Load += new System.EventHandler(this.NhanVien_Load);
            this.tabControl1.ResumeLayout(false);
            this.dataPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sttData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button mnfBut;
        private TabControl tabControl1;
        private TabPage dataPage;
        private DataGridView sttData;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}