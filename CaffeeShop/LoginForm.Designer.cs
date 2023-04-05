namespace CaffeeShop
{
    partial class LoginForm
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
            this.lgBut = new System.Windows.Forms.Button();
            this.userTxt = new System.Windows.Forms.TextBox();
            this.passTxt = new System.Windows.Forms.TextBox();
            this.userLb = new System.Windows.Forms.Label();
            this.passLb = new System.Windows.Forms.Label();
            this.lgLb = new System.Windows.Forms.Label();
            this.hsPass = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lgBut
            // 
            this.lgBut.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lgBut.Location = new System.Drawing.Point(187, 279);
            this.lgBut.Name = "lgBut";
            this.lgBut.Size = new System.Drawing.Size(121, 57);
            this.lgBut.TabIndex = 0;
            this.lgBut.Text = "Login";
            this.lgBut.UseVisualStyleBackColor = true;
            this.lgBut.Click += new System.EventHandler(this.lgBut_Click);
            // 
            // userTxt
            // 
            this.userTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userTxt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userTxt.Location = new System.Drawing.Point(207, 117);
            this.userTxt.Name = "userTxt";
            this.userTxt.Size = new System.Drawing.Size(221, 25);
            this.userTxt.TabIndex = 1;
            // 
            // passTxt
            // 
            this.passTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passTxt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passTxt.Location = new System.Drawing.Point(207, 167);
            this.passTxt.Name = "passTxt";
            this.passTxt.PasswordChar = '⚫';
            this.passTxt.Size = new System.Drawing.Size(221, 25);
            this.passTxt.TabIndex = 2;
            // 
            // userLb
            // 
            this.userLb.AutoSize = true;
            this.userLb.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.userLb.Location = new System.Drawing.Point(77, 116);
            this.userLb.Name = "userLb";
            this.userLb.Size = new System.Drawing.Size(90, 21);
            this.userLb.TabIndex = 3;
            this.userLb.Text = "User Name";
            // 
            // passLb
            // 
            this.passLb.AutoSize = true;
            this.passLb.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.passLb.Location = new System.Drawing.Point(77, 166);
            this.passLb.Name = "passLb";
            this.passLb.Size = new System.Drawing.Size(79, 21);
            this.passLb.TabIndex = 4;
            this.passLb.Text = "Password";
            // 
            // lgLb
            // 
            this.lgLb.AutoSize = true;
            this.lgLb.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lgLb.Location = new System.Drawing.Point(200, 30);
            this.lgLb.Name = "lgLb";
            this.lgLb.Size = new System.Drawing.Size(99, 37);
            this.lgLb.TabIndex = 5;
            this.lgLb.Text = "LOGIN";
            // 
            // hsPass
            // 
            this.hsPass.AutoSize = true;
            this.hsPass.Location = new System.Drawing.Point(438, 172);
            this.hsPass.Name = "hsPass";
            this.hsPass.Size = new System.Drawing.Size(15, 14);
            this.hsPass.TabIndex = 6;
            this.hsPass.UseVisualStyleBackColor = true;
            this.hsPass.CheckedChanged += new System.EventHandler(this.hsPass_CheckedChanged);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.hsPass);
            this.Controls.Add(this.lgLb);
            this.Controls.Add(this.passLb);
            this.Controls.Add(this.userLb);
            this.Controls.Add(this.passTxt);
            this.Controls.Add(this.userTxt);
            this.Controls.Add(this.lgBut);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button lgBut;
        private TextBox userTxt;
        private TextBox passTxt;
        private Label userLb;
        private Label passLb;
        private Label lgLb;
        private CheckBox hsPass;
    }
}