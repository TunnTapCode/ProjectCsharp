namespace Project_PRN21
{
    partial class Sellbook
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
            tabcontrol = new TabControl();
            tab1 = new TabPage();
            groupBox2 = new GroupBox();
            rb_author = new RadioButton();
            rb_name = new RadioButton();
            btn_load = new Button();
            btn_search = new Button();
            txt_sAuthor = new TextBox();
            txt_Bname = new TextBox();
            label5 = new Label();
            cbb_Cate = new ComboBox();
            groupBox1 = new GroupBox();
            txt_author = new TextBox();
            txt_total = new TextBox();
            label6 = new Label();
            Author = new Label();
            nUd_quantity = new NumericUpDown();
            btn_buy = new Button();
            txt_price = new TextBox();
            txt_name = new TextBox();
            nUd_id = new NumericUpDown();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgv_display = new DataGridView();
            tab2 = new TabPage();
            dgv_displayOrder = new DataGridView();
            tab3 = new TabPage();
            button1 = new Button();
            groupBox4 = new GroupBox();
            txt_cphone = new TextBox();
            txt_cemail = new TextBox();
            txt_cname = new TextBox();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            btn_updatecus = new Button();
            groupBox3 = new GroupBox();
            btn_change = new Button();
            txt_newp = new TextBox();
            txt_oldp = new TextBox();
            txt_user = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            tabcontrol.SuspendLayout();
            tab1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nUd_quantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUd_id).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_display).BeginInit();
            tab2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_displayOrder).BeginInit();
            tab3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // tabcontrol
            // 
            tabcontrol.Controls.Add(tab1);
            tabcontrol.Controls.Add(tab2);
            tabcontrol.Controls.Add(tab3);
            tabcontrol.Location = new Point(1, 1);
            tabcontrol.Name = "tabcontrol";
            tabcontrol.SelectedIndex = 0;
            tabcontrol.Size = new Size(1098, 508);
            tabcontrol.TabIndex = 0;
            // 
            // tab1
            // 
            tab1.Controls.Add(groupBox2);
            tab1.Controls.Add(groupBox1);
            tab1.Controls.Add(dgv_display);
            tab1.Location = new Point(4, 24);
            tab1.Name = "tab1";
            tab1.Padding = new Padding(3);
            tab1.Size = new Size(1090, 480);
            tab1.TabIndex = 0;
            tab1.Text = "Shop Book";
            tab1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.BackgroundImage = Properties.Resources.hinh_nen_4k_laptop_va_pc_toi_gian_800x500;
            groupBox2.BackgroundImageLayout = ImageLayout.Stretch;
            groupBox2.Controls.Add(rb_author);
            groupBox2.Controls.Add(rb_name);
            groupBox2.Controls.Add(btn_load);
            groupBox2.Controls.Add(btn_search);
            groupBox2.Controls.Add(txt_sAuthor);
            groupBox2.Controls.Add(txt_Bname);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(cbb_Cate);
            groupBox2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(597, 227);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(486, 247);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Search";
            // 
            // rb_author
            // 
            rb_author.AutoSize = true;
            rb_author.ForeColor = Color.Red;
            rb_author.Location = new Point(38, 165);
            rb_author.Name = "rb_author";
            rb_author.Size = new Size(69, 21);
            rb_author.TabIndex = 12;
            rb_author.TabStop = true;
            rb_author.Text = "Author";
            rb_author.UseVisualStyleBackColor = true;
            // 
            // rb_name
            // 
            rb_name.AutoSize = true;
            rb_name.ForeColor = Color.Red;
            rb_name.Location = new Point(38, 98);
            rb_name.Name = "rb_name";
            rb_name.Size = new Size(62, 21);
            rb_name.TabIndex = 11;
            rb_name.TabStop = true;
            rb_name.Text = "Name";
            rb_name.UseVisualStyleBackColor = true;
            // 
            // btn_load
            // 
            btn_load.BackColor = Color.Lime;
            btn_load.Location = new Point(354, 205);
            btn_load.Name = "btn_load";
            btn_load.Size = new Size(83, 36);
            btn_load.TabIndex = 10;
            btn_load.Text = "Load All";
            btn_load.UseVisualStyleBackColor = false;
btn_load.Click += btn_load_Click;
            // 
            // btn_search
            // 
            btn_search.BackColor = Color.Lime;
            btn_search.Location = new Point(166, 205);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(75, 36);
            btn_search.TabIndex = 7;
            btn_search.Text = "Search";
            btn_search.UseVisualStyleBackColor = false;
 btn_search.Click += btn_search_Click;
            // 
            // txt_sAuthor
            // 
            txt_sAuthor.Location = new Point(166, 161);
            txt_sAuthor.Name = "txt_sAuthor";
            txt_sAuthor.Size = new Size(147, 25);
            txt_sAuthor.TabIndex = 5;
            // 
            // txt_Bname
            // 
            txt_Bname.Location = new Point(166, 94);
            txt_Bname.Name = "txt_Bname";
            txt_Bname.Size = new Size(147, 25);
            txt_Bname.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(38, 35);
            label5.Name = "label5";
            label5.Size = new Size(64, 17);
            label5.TabIndex = 1;
            label5.Text = "Category";
            // 
            // cbb_Cate
            // 
            cbb_Cate.FormattingEnabled = true;
            cbb_Cate.Location = new Point(166, 33);
            cbb_Cate.MaxDropDownItems = 100;
            cbb_Cate.Name = "cbb_Cate";
            cbb_Cate.Size = new Size(147, 25);
            cbb_Cate.TabIndex = 0;
cbb_Cate.SelectedIndexChanged += cbb_Cate_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.MediumTurquoise;
            groupBox1.BackgroundImage = Properties.Resources.hinh_nen_4k_laptop_va_pc_toi_gian_800x500;
            groupBox1.BackgroundImageLayout = ImageLayout.Stretch;
            groupBox1.Controls.Add(txt_author);
            groupBox1.Controls.Add(txt_total);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(Author);
            groupBox1.Controls.Add(nUd_quantity);
            groupBox1.Controls.Add(btn_buy);
            groupBox1.Controls.Add(txt_price);
            groupBox1.Controls.Add(txt_name);
            groupBox1.Controls.Add(nUd_id);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(18, 227);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(573, 247);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Buy Book";
            // 
            // txt_author
            // 
            txt_author.Location = new Point(83, 150);
            txt_author.Name = "txt_author";
            txt_author.ReadOnly = true;
            txt_author.Size = new Size(147, 25);
            txt_author.TabIndex = 13;
            // 
            // txt_total
            // 
            txt_total.Location = new Point(404, 150);
            txt_total.Name = "txt_total";
            txt_total.ReadOnly = true;
            txt_total.Size = new Size(147, 25);
            txt_total.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(332, 156);
            label6.Name = "label6";
            label6.Size = new Size(39, 17);
            label6.TabIndex = 11;
            label6.Text = "Total";
            // 
            // Author
            // 
            Author.AutoSize = true;
            Author.BackColor = Color.Transparent;
            Author.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Author.ForeColor = Color.Red;
            Author.Location = new Point(21, 156);
            Author.Name = "Author";
            Author.Size = new Size(51, 17);
            Author.TabIndex = 10;
            Author.Text = "Author";
            // 
            // nUd_quantity
            // 
            nUd_quantity.Location = new Point(404, 33);
            nUd_quantity.Name = "nUd_quantity";
            nUd_quantity.Size = new Size(147, 25);
            nUd_quantity.TabIndex = 9;
nUd_quantity.ValueChanged += nUd_quantity_ValueChanged;
            // 
            // btn_buy
            // 
            btn_buy.BackColor = Color.Yellow;
            btn_buy.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_buy.Location = new Point(249, 205);
            btn_buy.Name = "btn_buy";
            btn_buy.Size = new Size(76, 36);
            btn_buy.TabIndex = 8;
            btn_buy.Text = "Buy";
            btn_buy.UseVisualStyleBackColor = false;
btn_buy.Click += btn_buy_Click;
            // 
            // txt_price
            // 
            txt_price.Location = new Point(404, 89);
            txt_price.Name = "txt_price";
            txt_price.ReadOnly = true;
            txt_price.Size = new Size(147, 25);
            txt_price.TabIndex = 7;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(83, 89);
            txt_name.Name = "txt_name";
            txt_name.ReadOnly = true;
            txt_name.Size = new Size(147, 25);
            txt_name.TabIndex = 5;
            // 
            // nUd_id
            // 
            nUd_id.Location = new Point(83, 33);
            nUd_id.Name = "nUd_id";
            nUd_id.ReadOnly = true;
            nUd_id.Size = new Size(147, 25);
            nUd_id.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(333, 95);
            label4.Name = "label4";
            label4.Size = new Size(38, 17);
            label4.TabIndex = 3;
            label4.Text = "Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(332, 39);
            label3.Name = "label3";
            label3.Size = new Size(62, 17);
            label3.TabIndex = 2;
            label3.Text = "Quantity";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(21, 95);
            label2.Name = "label2";
            label2.Size = new Size(44, 17);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(21, 39);
            label1.Name = "label1";
            label1.Size = new Size(22, 17);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // dgv_display
            // 
            dgv_display.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_display.BackgroundColor = Color.White;
            dgv_display.BorderStyle = BorderStyle.Fixed3D;
            dgv_display.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_display.Cursor = Cursors.Hand;
            dgv_display.Location = new Point(18, 6);
            dgv_display.Name = "dgv_display";
            dgv_display.RowTemplate.Height = 25;
            dgv_display.Size = new Size(1065, 215);
            dgv_display.TabIndex = 0;
dgv_display.CellClick += dgv_display_CellClick;
            // 
            // tab2
            // 
            tab2.BackgroundImage = Properties.Resources.hinh_nen_4k_laptop_va_pc_toi_gian_800x500;
            tab2.Controls.Add(dgv_displayOrder);
            tab2.Location = new Point(4, 24);
            tab2.Name = "tab2";
            tab2.Padding = new Padding(3);
            tab2.Size = new Size(1090, 480);
            tab2.TabIndex = 1;
            tab2.Text = "My Order";
            tab2.UseVisualStyleBackColor = true;
            // 
            // dgv_displayOrder
            // 
            dgv_displayOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_displayOrder.BackgroundColor = Color.White;
            dgv_displayOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_displayOrder.GridColor = Color.White;
            dgv_displayOrder.Location = new Point(0, 0);
            dgv_displayOrder.Name = "dgv_displayOrder";
            dgv_displayOrder.RowTemplate.Height = 25;
            dgv_displayOrder.Size = new Size(1090, 225);
            dgv_displayOrder.TabIndex = 0;
            // 
            // tab3
            // 
            tab3.BackgroundImage = Properties.Resources.anh_nen_chill_4k_cho_laptop_2476375150;
            tab3.BackgroundImageLayout = ImageLayout.Stretch;
            tab3.Controls.Add(button1);
            tab3.Controls.Add(groupBox4);
            tab3.Controls.Add(groupBox3);
            tab3.Location = new Point(4, 24);
            tab3.Name = "tab3";
            tab3.Size = new Size(1090, 480);
            tab3.TabIndex = 2;
            tab3.Text = "Setting";
            tab3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Image = Properties.Resources._5dab4f54a463ad3a3cc9f0af5cae5bac;
            button1.Location = new Point(501, 394);
            button1.Name = "button1";
            button1.Size = new Size(107, 49);
            button1.TabIndex = 2;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.Khaki;
            groupBox4.BackgroundImageLayout = ImageLayout.Stretch;
            groupBox4.Controls.Add(txt_cphone);
            groupBox4.Controls.Add(txt_cemail);
            groupBox4.Controls.Add(txt_cname);
            groupBox4.Controls.Add(label14);
            groupBox4.Controls.Add(label13);
            groupBox4.Controls.Add(label12);
            groupBox4.Controls.Add(label11);
            groupBox4.Controls.Add(btn_updatecus);
            groupBox4.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox4.Location = new Point(566, 34);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(481, 299);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Update Info";
            // 
            // txt_cphone
            // 
            txt_cphone.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_cphone.Location = new Point(203, 194);
            txt_cphone.Name = "txt_cphone";
            txt_cphone.Size = new Size(164, 25);
            txt_cphone.TabIndex = 7;
            // 
            // txt_cemail
            // 
            txt_cemail.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_cemail.Location = new Point(203, 138);
            txt_cemail.Name = "txt_cemail";
            txt_cemail.Size = new Size(164, 25);
            txt_cemail.TabIndex = 6;
            // 
            // txt_cname
            // 
            txt_cname.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_cname.Location = new Point(203, 90);
            txt_cname.Name = "txt_cname";
            txt_cname.Size = new Size(164, 25);
            txt_cname.TabIndex = 5;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ImageAlign = ContentAlignment.BottomCenter;
            label14.Location = new Point(172, 21);
            label14.Name = "label14";
            label14.Size = new Size(139, 30);
            label14.TabIndex = 4;
            label14.Text = "Customer";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(102, 202);
            label13.Name = "label13";
            label13.Size = new Size(58, 17);
            label13.TabIndex = 3;
            label13.Text = "Phone";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(102, 146);
            label12.Name = "label12";
            label12.Size = new Size(51, 17);
            label12.TabIndex = 2;
            label12.Text = "Email";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(102, 98);
            label11.Name = "label11";
            label11.Size = new Size(86, 17);
            label11.TabIndex = 1;
            label11.Text = "Full Name";
            // 
            // btn_updatecus
            // 
            btn_updatecus.BackgroundImage = Properties.Resources.hinh_nen_4k_laptop_va_pc_toi_gian_800x500;
            btn_updatecus.Location = new Point(203, 239);
            btn_updatecus.Name = "btn_updatecus";
            btn_updatecus.Size = new Size(89, 35);
            btn_updatecus.TabIndex = 0;
            btn_updatecus.Text = "Update";
            btn_updatecus.UseVisualStyleBackColor = true;
btn_updatecus.Click += btn_updatecus_Click;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Khaki;
            groupBox3.BackgroundImageLayout = ImageLayout.Stretch;
            groupBox3.Controls.Add(btn_change);
            groupBox3.Controls.Add(txt_newp);
            groupBox3.Controls.Add(txt_oldp);
            groupBox3.Controls.Add(txt_user);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label7);
            groupBox3.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.Location = new Point(70, 34);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(479, 299);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Change Password";
            // 
            // btn_change
            // 
            btn_change.BackgroundImage = Properties.Resources.hinh_nen_4k_laptop_va_pc_toi_gian_800x500;
            btn_change.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_change.Location = new Point(196, 239);
            btn_change.Name = "btn_change";
            btn_change.Size = new Size(95, 35);
            btn_change.TabIndex = 7;
            btn_change.Text = "Change";
            btn_change.UseVisualStyleBackColor = true;
btn_change.Click += btn_change_Click;
            // 
            // txt_newp
            // 
            txt_newp.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_newp.Location = new Point(215, 191);
            txt_newp.Name = "txt_newp";
            txt_newp.Size = new Size(157, 25);
            txt_newp.TabIndex = 6;
            // 
            // txt_oldp
            // 
            txt_oldp.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_oldp.Location = new Point(215, 138);
            txt_oldp.Name = "txt_oldp";
            txt_oldp.Size = new Size(157, 25);
            txt_oldp.TabIndex = 5;
            // 
            // txt_user
            // 
            txt_user.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_user.Location = new Point(215, 91);
            txt_user.Name = "txt_user";
            txt_user.Size = new Size(157, 25);
            txt_user.TabIndex = 4;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(121, 21);
            label10.Name = "label10";
            label10.Size = new Size(240, 30);
            label10.TabIndex = 3;
            label10.Text = "Change Password";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(71, 198);
            label9.Name = "label9";
            label9.Size = new Size(127, 17);
            label9.TabIndex = 2;
            label9.Text = "New Password";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(71, 146);
            label8.Name = "label8";
            label8.Size = new Size(124, 17);
            label8.TabIndex = 1;
            label8.Text = "Old Password";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(71, 98);
            label7.Name = "label7";
            label7.Size = new Size(84, 17);
            label7.TabIndex = 0;
            label7.Text = "Username";
            // 
            // Sellbook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1101, 515);
            Controls.Add(tabcontrol);
            Name = "Sellbook";
            Text = "Sellbook";
            tabcontrol.ResumeLayout(false);
            tab1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nUd_quantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUd_id).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_display).EndInit();
            tab2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_displayOrder).EndInit();
            tab3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabcontrol;
        private TabPage tab1;
        private TabPage tab2;
        private DataGridView dgv_display;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txt_price;
        private TextBox txt_name;
        private NumericUpDown nUd_id;
        private Button btn_buy;
        private TextBox txt_author;
        private TextBox txt_total;
        private Label label6;
        private Label Author;
        private NumericUpDown nUd_quantity;
        private GroupBox groupBox2;
        private Label label5;
        private ComboBox cbb_Cate;
        private Button btn_search;
        private TextBox txt_sAuthor;
        private TextBox txt_Bname;
        private Button btn_load;
        private RadioButton rb_author;
        private RadioButton rb_name;
        private DataGridView dgv_displayOrder;
        private TabPage tab3;
        private GroupBox groupBox4;
        private GroupBox groupBox3;
        private Button btn_change;
        private TextBox txt_newp;
        private TextBox txt_oldp;
        private TextBox txt_user;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox txt_cphone;
        private TextBox txt_cemail;
        private TextBox txt_cname;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Button btn_updatecus;
        private Button button1;
    }
}