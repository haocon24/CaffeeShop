namespace CaffeeShop
{
    partial class MenuForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listData = new System.Windows.Forms.ListView();
            this.nameCln = new System.Windows.Forms.ColumnHeader();
            this.fpriceCln = new System.Windows.Forms.ColumnHeader();
            this.countCln = new System.Windows.Forms.ColumnHeader();
            this.lpriceCln = new System.Windows.Forms.ColumnHeader();
            this.panel1 = new System.Windows.Forms.Panel();
            this.delBut = new System.Windows.Forms.Button();
            this.cancelBut = new System.Windows.Forms.Button();
            this.acceptBut = new System.Windows.Forms.Button();
            this.editBut = new System.Windows.Forms.Button();
            this.sumTxt = new System.Windows.Forms.TextBox();
            this.sumPrice = new System.Windows.Forms.Button();
            this.nvfBut = new System.Windows.Forms.Button();
            this.rfTimer = new System.Windows.Forms.Timer(this.components);
            this.dsLb = new System.Windows.Forms.Label();
            this.lgfBut = new System.Windows.Forms.Button();
            this.selectDish = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listData
            // 
            this.listData.AllowDrop = true;
            this.listData.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameCln,
            this.fpriceCln,
            this.countCln,
            this.lpriceCln});
            this.listData.Enabled = false;
            this.listData.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listData.GridLines = true;
            this.listData.Location = new System.Drawing.Point(0, 0);
            this.listData.Name = "listData";
            this.listData.Size = new System.Drawing.Size(384, 410);
            this.listData.TabIndex = 0;
            this.listData.UseCompatibleStateImageBehavior = false;
            this.listData.View = System.Windows.Forms.View.Details;
            // 
            // nameCln
            // 
            this.nameCln.Text = "Tên món";
            this.nameCln.Width = 147;
            // 
            // fpriceCln
            // 
            this.fpriceCln.Text = "Giá tiền";
            this.fpriceCln.Width = 75;
            // 
            // countCln
            // 
            this.countCln.Text = "Số lượng";
            this.countCln.Width = 73;
            // 
            // lpriceCln
            // 
            this.lpriceCln.Text = "Thành tiền";
            this.lpriceCln.Width = 85;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.delBut);
            this.panel1.Controls.Add(this.cancelBut);
            this.panel1.Controls.Add(this.acceptBut);
            this.panel1.Controls.Add(this.editBut);
            this.panel1.Controls.Add(this.sumTxt);
            this.panel1.Controls.Add(this.sumPrice);
            this.panel1.Controls.Add(this.listData);
            this.panel1.Location = new System.Drawing.Point(588, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 600);
            this.panel1.TabIndex = 2;
            // 
            // delBut
            // 
            this.delBut.Enabled = false;
            this.delBut.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.delBut.Location = new System.Drawing.Point(99, 416);
            this.delBut.Name = "delBut";
            this.delBut.Size = new System.Drawing.Size(90, 60);
            this.delBut.TabIndex = 8;
            this.delBut.Text = "Xóa";
            this.delBut.UseVisualStyleBackColor = true;
            this.delBut.Click += new System.EventHandler(this.delBut_Click);
            // 
            // cancelBut
            // 
            this.cancelBut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cancelBut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.cancelBut.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cancelBut.Location = new System.Drawing.Point(280, 565);
            this.cancelBut.Name = "cancelBut";
            this.cancelBut.Size = new System.Drawing.Size(101, 32);
            this.cancelBut.TabIndex = 7;
            this.cancelBut.Text = "Hủy đơn";
            this.cancelBut.UseVisualStyleBackColor = true;
            this.cancelBut.Click += new System.EventHandler(this.cancelBut_Click);
            // 
            // acceptBut
            // 
            this.acceptBut.Enabled = false;
            this.acceptBut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.acceptBut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.acceptBut.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.acceptBut.Location = new System.Drawing.Point(280, 485);
            this.acceptBut.Name = "acceptBut";
            this.acceptBut.Size = new System.Drawing.Size(101, 74);
            this.acceptBut.TabIndex = 6;
            this.acceptBut.Text = "Xác nhận thanh toán";
            this.acceptBut.UseVisualStyleBackColor = true;
            this.acceptBut.Click += new System.EventHandler(this.acceptBut_Click);
            // 
            // editBut
            // 
            this.editBut.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.editBut.Location = new System.Drawing.Point(3, 416);
            this.editBut.Name = "editBut";
            this.editBut.Size = new System.Drawing.Size(90, 60);
            this.editBut.TabIndex = 5;
            this.editBut.Text = "Sửa";
            this.editBut.UseVisualStyleBackColor = true;
            this.editBut.Click += new System.EventHandler(this.editBut_Click);
            // 
            // sumTxt
            // 
            this.sumTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sumTxt.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sumTxt.Location = new System.Drawing.Point(280, 452);
            this.sumTxt.Name = "sumTxt";
            this.sumTxt.ReadOnly = true;
            this.sumTxt.Size = new System.Drawing.Size(101, 27);
            this.sumTxt.TabIndex = 3;
            this.sumTxt.Text = "0";
            this.sumTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sumPrice
            // 
            this.sumPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sumPrice.Location = new System.Drawing.Point(280, 416);
            this.sumPrice.Name = "sumPrice";
            this.sumPrice.Size = new System.Drawing.Size(101, 30);
            this.sumPrice.TabIndex = 2;
            this.sumPrice.Text = "Tổng tiền";
            this.sumPrice.UseVisualStyleBackColor = true;
            this.sumPrice.Click += new System.EventHandler(this.sumPrice_Click);
            // 
            // nvfBut
            // 
            this.nvfBut.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nvfBut.Location = new System.Drawing.Point(868, 12);
            this.nvfBut.Name = "nvfBut";
            this.nvfBut.Size = new System.Drawing.Size(104, 28);
            this.nvfBut.TabIndex = 3;
            this.nvfBut.Text = "Nhân Viên";
            this.nvfBut.UseVisualStyleBackColor = true;
            this.nvfBut.Click += new System.EventHandler(this.nvfBut_Click);
            // 
            // rfTimer
            // 
            this.rfTimer.Tick += new System.EventHandler(this.MenuForm_Load);
            // 
            // dsLb
            // 
            this.dsLb.AutoSize = true;
            this.dsLb.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dsLb.Location = new System.Drawing.Point(196, 15);
            this.dsLb.Name = "dsLb";
            this.dsLb.Size = new System.Drawing.Size(125, 25);
            this.dsLb.TabIndex = 4;
            this.dsLb.Text = "DANH SÁCH";
            // 
            // lgfBut
            // 
            this.lgfBut.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lgfBut.Location = new System.Drawing.Point(751, 12);
            this.lgfBut.Name = "lgfBut";
            this.lgfBut.Size = new System.Drawing.Size(111, 28);
            this.lgfBut.TabIndex = 5;
            this.lgfBut.Text = " Login";
            this.lgfBut.UseVisualStyleBackColor = true;
            this.lgfBut.Click += new System.EventHandler(this.lgfBut_Click);
            // 
            // selectDish
            // 
            this.selectDish.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.selectDish.Location = new System.Drawing.Point(12, 46);
            this.selectDish.Name = "selectDish";
            this.selectDish.Size = new System.Drawing.Size(570, 600);
            this.selectDish.TabIndex = 6;
            // 
            // MenuForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.selectDish);
            this.Controls.Add(this.lgfBut);
            this.Controls.Add(this.dsLb);
            this.Controls.Add(this.nvfBut);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MenuForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuForm_FormClosed);
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView listData;
        private ColumnHeader nameCln;
        private ColumnHeader fpriceCln;
        private ColumnHeader countCln;
        private ColumnHeader lpriceCln;
        private Panel panel1;
        private Button sumPrice;
        private Button nvfBut;
        private TextBox sumTxt;
        private System.Windows.Forms.Timer rfTimer;
        private Button cancelBut;
        private Button acceptBut;
        private Button editBut;
        private Label dsLb;
        private Button lgfBut;
        private FlowLayoutPanel selectDish;
        private Button delBut;
    }
}