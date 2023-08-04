namespace Project_PRN21
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt_pass = new TextBox();
            txt_user = new TextBox();
            btn_login = new Button();
            btn_regist = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Image = Properties.Resources.hinh_nen_4k_laptop_va_pc_toi_gian_800x500;
            label1.Location = new Point(184, 25);
            label1.Name = "label1";
            label1.Size = new Size(82, 30);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Image = Properties.Resources.hinh_nen_4k_laptop_va_pc_toi_gian_800x500;
            label2.Location = new Point(94, 91);
            label2.Name = "label2";
            label2.Size = new Size(76, 17);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Image = Properties.Resources.hinh_nen_4k_laptop_va_pc_toi_gian_800x500;
            label3.Location = new Point(94, 143);
            label3.Name = "label3";
            label3.Size = new Size(82, 17);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // txt_pass
            // 
            txt_pass.Location = new Point(184, 135);
            txt_pass.Name = "txt_pass";
            txt_pass.PasswordChar = '*';
            txt_pass.Size = new Size(135, 23);
            txt_pass.TabIndex = 2;
            // 
            // txt_user
            // 
            txt_user.Location = new Point(184, 88);
            txt_user.Name = "txt_user";
            txt_user.Size = new Size(135, 23);
            txt_user.TabIndex = 1;
            // 
            // btn_login
            // 
            btn_login.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_login.Image = Properties.Resources.hinh_nen_4k_laptop_va_pc_toi_gian_800x500;
            btn_login.Location = new Point(139, 202);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(85, 33);
            btn_login.TabIndex = 3;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = true;
 btn_login.Click += btn_login_Click;
            // 
            // btn_regist
            // 
            btn_regist.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_regist.Image = Properties.Resources.hinh_nen_4k_laptop_va_pc_toi_gian_800x500;
            btn_regist.Location = new Point(262, 202);
            btn_regist.Name = "btn_regist";
            btn_regist.Size = new Size(78, 33);
            btn_regist.TabIndex = 4;
            btn_regist.Text = "Register";
            btn_regist.UseVisualStyleBackColor = true;
btn_regist.Click += btn_regist_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._5dab4f54a463ad3a3cc9f0af5cae5bac;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(465, 278);
            Controls.Add(btn_regist);
            Controls.Add(btn_login);
            Controls.Add(txt_user);
            Controls.Add(txt_pass);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_pass;
        private TextBox txt_user;
        private Button btn_login;
        private Button btn_regist;
    }
}