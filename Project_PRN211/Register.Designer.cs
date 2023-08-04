namespace Project_PRN21
{
    partial class Form2
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
            Label label1;
            Button btn_regist;
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txt_user = new TextBox();
            txt_pass = new TextBox();
            txt_repass = new TextBox();
            label1 = new Label();
            btn_regist = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Image = Properties.Resources.tải_xuống;
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(197, 28);
            label1.Name = "label1";
            label1.Size = new Size(123, 30);
            label1.TabIndex = 0;
            label1.Text = "Register";
            // 
            // btn_regist
            // 
            btn_regist.BackColor = SystemColors.ButtonFace;
            btn_regist.BackgroundImage = Properties.Resources.tải_xuống;
            btn_regist.BackgroundImageLayout = ImageLayout.Stretch;
            btn_regist.CausesValidation = false;
            btn_regist.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            btn_regist.ForeColor = Color.Transparent;
            btn_regist.Image = Properties.Resources.tải_xuống;
            btn_regist.Location = new Point(219, 220);
            btn_regist.Name = "btn_regist";
            btn_regist.Size = new Size(89, 32);
            btn_regist.TabIndex = 4;
            btn_regist.Text = "Register";
            btn_regist.UseVisualStyleBackColor = false;
btn_regist.Click += btn_regist_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLight;
            label2.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Image = Properties.Resources.hinh_nen_4k_laptop_va_pc_toi_gian_800x500;
            label2.ImageAlign = ContentAlignment.TopLeft;
            label2.Location = new Point(120, 91);
            label2.Name = "label2";
            label2.Size = new Size(76, 17);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Image = Properties.Resources.hinh_nen_4k_laptop_va_pc_toi_gian_800x500;
            label3.Location = new Point(120, 175);
            label3.Name = "label3";
            label3.Size = new Size(105, 17);
            label3.TabIndex = 2;
            label3.Text = "Re_password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Image = Properties.Resources.hinh_nen_4k_laptop_va_pc_toi_gian_800x500;
            label4.Location = new Point(120, 135);
            label4.Name = "label4";
            label4.Size = new Size(82, 17);
            label4.TabIndex = 3;
            label4.Text = "Password";
            // 
            // txt_user
            // 
            txt_user.Location = new Point(248, 90);
            txt_user.Name = "txt_user";
            txt_user.Size = new Size(135, 23);
            txt_user.TabIndex = 5;
            // 
            // txt_pass
            // 
            txt_pass.Location = new Point(248, 129);
            txt_pass.Name = "txt_pass";
            txt_pass.PasswordChar = '*';
            txt_pass.Size = new Size(135, 23);
            txt_pass.TabIndex = 6;
            // 
            // txt_repass
            // 
            txt_repass.Location = new Point(248, 169);
            txt_repass.Name = "txt_repass";
            txt_repass.PasswordChar = '*';
            txt_repass.Size = new Size(135, 23);
            txt_repass.TabIndex = 7;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.tải_xuống;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(532, 318);
            Controls.Add(txt_repass);
            Controls.Add(txt_pass);
            Controls.Add(txt_user);
            Controls.Add(btn_regist);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btn_regist;
        private TextBox txt_user;
        private TextBox txt_pass;
        private TextBox txt_repass;
    }
}