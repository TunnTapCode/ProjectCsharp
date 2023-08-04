namespace Project_PRN21
{
    partial class CustomerInfo
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
            txt_name = new TextBox();
            txt_email = new TextBox();
            txt_phone = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btn_customer = new Button();
            SuspendLayout();
            // 
            // txt_name
            // 
            txt_name.Location = new Point(248, 109);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(147, 23);
            txt_name.TabIndex = 0;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(248, 165);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(147, 23);
            txt_email.TabIndex = 1;
            // 
            // txt_phone
            // 
            txt_phone.Location = new Point(248, 221);
            txt_phone.Name = "txt_phone";
            txt_phone.Size = new Size(147, 23);
            txt_phone.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MistyRose;
            label1.Font = new Font("Showcard Gothic", 18.75F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Image = Properties.Resources.hinh_nen_4k_laptop_va_pc_toi_gian_800x500;
            label1.ImageAlign = ContentAlignment.TopLeft;
            label1.Location = new Point(218, 40);
            label1.Name = "label1";
            label1.Size = new Size(146, 31);
            label1.TabIndex = 3;
            label1.Text = "Customer";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Image = Properties.Resources.hinh_nen_4k_laptop_va_pc_toi_gian_800x500;
            label2.ImageAlign = ContentAlignment.TopCenter;
            label2.Location = new Point(141, 115);
            label2.Name = "label2";
            label2.Size = new Size(86, 17);
            label2.TabIndex = 4;
            label2.Text = "Full name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Image = Properties.Resources.hinh_nen_4k_laptop_va_pc_toi_gian_800x500;
            label3.ImageAlign = ContentAlignment.TopRight;
            label3.Location = new Point(141, 171);
            label3.Name = "label3";
            label3.Size = new Size(51, 17);
            label3.TabIndex = 5;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Image = Properties.Resources.hinh_nen_4k_laptop_va_pc_toi_gian_800x500;
            label4.ImageAlign = ContentAlignment.TopRight;
            label4.Location = new Point(141, 227);
            label4.Name = "label4";
            label4.Size = new Size(58, 17);
            label4.TabIndex = 6;
            label4.Text = "Phone";
            // 
            // btn_customer
            // 
            btn_customer.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_customer.ForeColor = Color.Transparent;
            btn_customer.Image = Properties.Resources.hinh_nen_4k_laptop_va_pc_toi_gian_800x500;
            btn_customer.ImageAlign = ContentAlignment.BottomCenter;
            btn_customer.Location = new Point(269, 268);
            btn_customer.Name = "btn_customer";
            btn_customer.Size = new Size(79, 42);
            btn_customer.TabIndex = 7;
            btn_customer.Text = "OK";
            btn_customer.UseVisualStyleBackColor = true;
 btn_customer.Click += btn_customer_Click;
            // 
            // CustomerInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.hinh_nen_4k_laptop_va_pc_toi_gian_800x500;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(619, 334);
            Controls.Add(btn_customer);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_phone);
            Controls.Add(txt_email);
            Controls.Add(txt_name);
            Name = "CustomerInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thông tin khách hàng";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_name;
        private TextBox txt_email;
        private TextBox txt_phone;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btn_customer;
    }
}