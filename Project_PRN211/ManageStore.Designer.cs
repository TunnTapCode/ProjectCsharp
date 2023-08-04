namespace Project_PRN21
{
    partial class ManageStore
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            groupbox = new GroupBox();
            label8 = new Label();
            cbb_cate = new ComboBox();
            nUd_price = new NumericUpDown();
            nUd_quantity = new NumericUpDown();
            dtp_nsx = new DateTimePicker();
            btn_delete = new Button();
            btn_update = new Button();
            btn_add = new Button();
            txt_title = new TextBox();
            txt_author = new TextBox();
            txt_name = new TextBox();
            nUd_id = new NumericUpDown();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgv_display = new DataGridView();
            tabPage2 = new TabPage();
            rd_sid = new RadioButton();
            rd_sdate = new RadioButton();
            dtp_sdate = new DateTimePicker();
            btn_sort = new Button();
            btn_find = new Button();
            nud_searchID = new NumericUpDown();
            rb_price = new RadioButton();
            rb_day = new RadioButton();
            dgv_order = new DataGridView();
            tabPage3 = new TabPage();
            dgv_customer = new DataGridView();
            tabPage4 = new TabPage();
            button1 = new Button();
            groupBox1 = new GroupBox();
            txt_newpass = new TextBox();
            txt_opass = new TextBox();
            txtx_user = new TextBox();
            btn_change = new Button();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nUd_price).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUd_quantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUd_id).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_display).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nud_searchID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_order).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_customer).BeginInit();
            tabPage4.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(12, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1129, 512);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupbox);
            tabPage1.Controls.Add(dgv_display);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1121, 484);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Manage Book";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupbox
            // 
            groupbox.BackgroundImage = Properties.Resources._5dab4f54a463ad3a3cc9f0af5cae5bac;
            groupbox.BackgroundImageLayout = ImageLayout.Stretch;
            groupbox.Controls.Add(label8);
            groupbox.Controls.Add(cbb_cate);
            groupbox.Controls.Add(nUd_price);
            groupbox.Controls.Add(nUd_quantity);
            groupbox.Controls.Add(dtp_nsx);
            groupbox.Controls.Add(btn_delete);
            groupbox.Controls.Add(btn_update);
            groupbox.Controls.Add(btn_add);
            groupbox.Controls.Add(txt_title);
            groupbox.Controls.Add(txt_author);
            groupbox.Controls.Add(txt_name);
            groupbox.Controls.Add(nUd_id);
            groupbox.Controls.Add(label7);
            groupbox.Controls.Add(label6);
            groupbox.Controls.Add(label5);
            groupbox.Controls.Add(label4);
            groupbox.Controls.Add(label3);
            groupbox.Controls.Add(label2);
            groupbox.Controls.Add(label1);
            groupbox.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupbox.Location = new Point(6, 250);
            groupbox.Name = "groupbox";
            groupbox.Size = new Size(1109, 234);
            groupbox.TabIndex = 1;
            groupbox.TabStop = false;
            groupbox.Text = "Manage";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(518, 145);
            label8.Name = "label8";
            label8.Size = new Size(79, 15);
            label8.TabIndex = 21;
            label8.Text = "Categories";
            // 
            // cbb_cate
            // 
            cbb_cate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbb_cate.FormattingEnabled = true;
            cbb_cate.Location = new Point(607, 137);
            cbb_cate.Name = "cbb_cate";
            cbb_cate.Size = new Size(143, 23);
            cbb_cate.TabIndex = 0;
            // 
            // nUd_price
            // 
            nUd_price.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            nUd_price.Location = new Point(328, 28);
            nUd_price.Maximum = new decimal(new int[] { -1530494976, 232830, 0, 0 });
            nUd_price.Name = "nUd_price";
            nUd_price.Size = new Size(158, 23);
            nUd_price.TabIndex = 19;
            // 
            // nUd_quantity
            // 
            nUd_quantity.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            nUd_quantity.Location = new Point(607, 74);
            nUd_quantity.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nUd_quantity.Name = "nUd_quantity";
            nUd_quantity.Size = new Size(143, 23);
            nUd_quantity.TabIndex = 18;
            // 
            // dtp_nsx
            // 
            dtp_nsx.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtp_nsx.Format = DateTimePickerFormat.Short;
            dtp_nsx.Location = new Point(328, 77);
            dtp_nsx.Name = "dtp_nsx";
            dtp_nsx.Size = new Size(158, 23);
            dtp_nsx.TabIndex = 17;
            // 
            // btn_delete
            // 
            btn_delete.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_delete.Location = new Point(871, 165);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(75, 37);
            btn_delete.TabIndex = 16;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
btn_delete.Click += btn_delete_Click;
            // 
            // btn_update
            // 
            btn_update.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_update.Location = new Point(871, 98);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(75, 36);
            btn_update.TabIndex = 15;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
btn_update.Click += btn_update_Click;
            // 
            // btn_add
            // 
            btn_add.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_add.Location = new Point(871, 24);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(75, 39);
            btn_add.TabIndex = 14;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
btn_add.Click += btn_add_Click;
            // 
            // txt_title
            // 
            txt_title.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_title.Location = new Point(328, 138);
            txt_title.Name = "txt_title";
            txt_title.Size = new Size(158, 23);
            txt_title.TabIndex = 11;
            // 
            // txt_author
            // 
            txt_author.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_author.Location = new Point(93, 138);
            txt_author.Name = "txt_author";
            txt_author.Size = new Size(149, 23);
            txt_author.TabIndex = 9;
            // 
            // txt_name
            // 
            txt_name.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_name.Location = new Point(89, 77);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(149, 23);
            txt_name.TabIndex = 8;
            // 
            // nUd_id
            // 
            nUd_id.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            nUd_id.Location = new Point(89, 24);
            nUd_id.Name = "nUd_id";
            nUd_id.Size = new Size(149, 23);
            nUd_id.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(518, 82);
            label7.Name = "label7";
            label7.Size = new Size(69, 15);
            label7.TabIndex = 6;
            label7.Text = "Quantity";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(36, 146);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 5;
            label6.Text = "Author";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 81);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 4;
            label5.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(271, 146);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 3;
            label4.Text = "Title";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(271, 85);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 2;
            label3.Text = "NSX";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(271, 36);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 1;
            label2.Text = "Price";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 32);
            label1.Name = "label1";
            label1.Size = new Size(22, 15);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // dgv_display
            // 
            dgv_display.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_display.BackgroundColor = Color.White;
            dgv_display.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_display.Location = new Point(6, 6);
            dgv_display.Name = "dgv_display";
            dgv_display.RowTemplate.Height = 25;
            dgv_display.Size = new Size(1109, 238);
            dgv_display.TabIndex = 0;
dgv_display.CellClick += dgv_display_CellClick;
            // 
            // tabPage2
            // 
            tabPage2.BackgroundImage = Properties.Resources.hinh_nen_4k_laptop_va_pc_toi_gian_800x500;
            tabPage2.Controls.Add(rd_sid);
            tabPage2.Controls.Add(rd_sdate);
            tabPage2.Controls.Add(dtp_sdate);
            tabPage2.Controls.Add(btn_sort);
            tabPage2.Controls.Add(btn_find);
            tabPage2.Controls.Add(nud_searchID);
            tabPage2.Controls.Add(rb_price);
            tabPage2.Controls.Add(rb_day);
            tabPage2.Controls.Add(dgv_order);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1121, 484);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "History Order";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // rd_sid
            // 
            rd_sid.AutoSize = true;
            rd_sid.Font = new Font("Showcard Gothic", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            rd_sid.ForeColor = Color.FromArgb(255, 255, 192);
            rd_sid.Location = new Point(811, 308);
            rd_sid.Name = "rd_sid";
            rd_sid.Size = new Size(42, 22);
            rd_sid.TabIndex = 10;
            rd_sid.TabStop = true;
            rd_sid.Text = "ID";
            rd_sid.UseVisualStyleBackColor = true;
            // 
            // rd_sdate
            // 
            rd_sdate.AutoSize = true;
            rd_sdate.Font = new Font("Showcard Gothic", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            rd_sdate.ForeColor = Color.FromArgb(255, 255, 192);
            rd_sdate.Location = new Point(811, 222);
            rd_sdate.Name = "rd_sdate";
            rd_sdate.Size = new Size(64, 22);
            rd_sdate.TabIndex = 9;
            rd_sdate.TabStop = true;
            rd_sdate.Text = "Date";
            rd_sdate.UseVisualStyleBackColor = true;
            // 
            // dtp_sdate
            // 
            dtp_sdate.Format = DateTimePickerFormat.Short;
            dtp_sdate.Location = new Point(905, 221);
            dtp_sdate.Name = "dtp_sdate";
            dtp_sdate.Size = new Size(150, 23);
            dtp_sdate.TabIndex = 8;
            // 
            // btn_sort
            // 
            btn_sort.Font = new Font("Showcard Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_sort.Image = Properties.Resources.hinh_nen_4k_laptop_va_pc_toi_gian_800x500;
            btn_sort.Location = new Point(893, 110);
            btn_sort.Name = "btn_sort";
            btn_sort.Size = new Size(95, 25);
            btn_sort.TabIndex = 7;
            btn_sort.Text = "Sort";
            btn_sort.UseVisualStyleBackColor = true;
btn_sort.Click += btn_sort_Click;
            // 
            // btn_find
            // 
            btn_find.Font = new Font("Showcard Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_find.Image = Properties.Resources.hinh_nen_4k_laptop_va_pc_toi_gian_800x500;
            btn_find.Location = new Point(905, 398);
            btn_find.Name = "btn_find";
            btn_find.Size = new Size(95, 25);
            btn_find.TabIndex = 6;
            btn_find.Text = "Find";
            btn_find.UseVisualStyleBackColor = true;
btn_find.Click += btn_find_Click;
            // 
            // nud_searchID
            // 
            nud_searchID.Location = new Point(905, 307);
            nud_searchID.Name = "nud_searchID";
            nud_searchID.Size = new Size(150, 23);
            nud_searchID.TabIndex = 5;
            // 
            // rb_price
            // 
            rb_price.AutoSize = true;
            rb_price.Font = new Font("Showcard Gothic", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            rb_price.ForeColor = Color.FromArgb(255, 255, 192);
            rb_price.Location = new Point(959, 66);
            rb_price.Name = "rb_price";
            rb_price.Size = new Size(126, 22);
            rb_price.TabIndex = 3;
            rb_price.TabStop = true;
            rb_price.Text = "SortByPrice";
            rb_price.UseVisualStyleBackColor = true;
            // 
            // rb_day
            // 
            rb_day.AutoSize = true;
            rb_day.Font = new Font("Showcard Gothic", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            rb_day.ForeColor = Color.FromArgb(255, 255, 192);
            rb_day.Location = new Point(801, 66);
            rb_day.Name = "rb_day";
            rb_day.Size = new Size(121, 22);
            rb_day.TabIndex = 2;
            rb_day.TabStop = true;
            rb_day.Text = "SortByDate";
            rb_day.UseVisualStyleBackColor = true;
            // 
            // dgv_order
            // 
            dgv_order.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_order.BackgroundColor = Color.White;
            dgv_order.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_order.Location = new Point(-4, 0);
            dgv_order.Name = "dgv_order";
            dgv_order.RowTemplate.Height = 25;
            dgv_order.Size = new Size(765, 484);
            dgv_order.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.BackgroundImage = Properties.Resources.hinh_nen_4k_laptop_va_pc_toi_gian_800x500;
            tabPage3.Controls.Add(dgv_customer);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1121, 484);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Customer";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgv_customer
            // 
            dgv_customer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_customer.BackgroundColor = Color.White;
            dgv_customer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_customer.Location = new Point(-7, 0);
            dgv_customer.Name = "dgv_customer";
            dgv_customer.RowTemplate.Height = 25;
            dgv_customer.Size = new Size(728, 488);
            dgv_customer.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.BackgroundImage = Properties.Resources.anh_nen_chill_4k_cho_laptop_2476375150;
            tabPage4.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage4.Controls.Add(button1);
            tabPage4.Controls.Add(groupBox1);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(1121, 484);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Setting";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.LightCoral;
            button1.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(654, 34);
            button1.Name = "button1";
            button1.Size = new Size(109, 51);
            button1.TabIndex = 1;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = false;
button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(255, 255, 192);
            groupBox1.Controls.Add(txt_newpass);
            groupBox1.Controls.Add(txt_opass);
            groupBox1.Controls.Add(txtx_user);
            groupBox1.Controls.Add(btn_change);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(51, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(530, 303);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Change Password";
            // 
            // txt_newpass
            // 
            txt_newpass.Location = new Point(245, 181);
            txt_newpass.Name = "txt_newpass";
            txt_newpass.Size = new Size(149, 24);
            txt_newpass.TabIndex = 7;
            // 
            // txt_opass
            // 
            txt_opass.Location = new Point(245, 125);
            txt_opass.Name = "txt_opass";
            txt_opass.Size = new Size(149, 24);
            txt_opass.TabIndex = 6;
            // 
            // txtx_user
            // 
            txtx_user.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtx_user.Location = new Point(245, 80);
            txtx_user.Name = "txtx_user";
            txtx_user.Size = new Size(149, 25);
            txtx_user.TabIndex = 5;
            // 
            // btn_change
            // 
            btn_change.Location = new Point(227, 230);
            btn_change.Name = "btn_change";
            btn_change.Size = new Size(75, 37);
            btn_change.TabIndex = 4;
            btn_change.Text = "Change";
            btn_change.UseVisualStyleBackColor = true;
btn_change.Click += btn_change_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(124, 184);
            label12.Name = "label12";
            label12.Size = new Size(115, 17);
            label12.TabIndex = 3;
            label12.Text = "New password";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(124, 128);
            label11.Name = "label11";
            label11.Size = new Size(112, 17);
            label11.TabIndex = 2;
            label11.Text = "Old Password";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(124, 80);
            label10.Name = "label10";
            label10.Size = new Size(76, 17);
            label10.TabIndex = 1;
            label10.Text = "Username";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(151, 20);
            label9.Name = "label9";
            label9.Size = new Size(212, 27);
            label9.TabIndex = 0;
            label9.Text = "Change Password";
            // 
            // ManageAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1153, 515);
            Controls.Add(tabControl1);
            Name = "Manage_Store";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage_Store";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupbox.ResumeLayout(false);
            groupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nUd_price).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUd_quantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUd_id).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_display).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nud_searchID).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_order).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_customer).EndInit();
            tabPage4.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private GroupBox groupBox1;
        private DataGridView dgv_display;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label7;
        private NumericUpDown nUd_id;
        private Button btn_delete;
        private Button btn_update;
        private Button btn_add;
        private TextBox txt_title;
        private TextBox txt_author;
        private TextBox txt_name;
        private DateTimePicker dtp_nsx;
        private NumericUpDown nUd_price;
        private NumericUpDown nUd_quantity;
        private Label label8;
        private ComboBox cbb_cate;
        private GroupBox groupbox;
        private TabPage tabPage3;
        private TabPage tabPage2;
        private RadioButton rd_sid;
        private RadioButton rd_sdate;
        private DateTimePicker dtp_sdate;
        private Button btn_sort;
        private Button btn_find;
        private NumericUpDown nud_searchID;
        private RadioButton rb_price;
        private RadioButton rb_day;
        private DataGridView dgv_order;
        private DataGridView dgv_customer;
        private TabPage tabPage4;
        private TextBox txt_newpass;
        private TextBox txt_opass;
        private TextBox txtx_user;
        private Button btn_change;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Button button1;
    }
}