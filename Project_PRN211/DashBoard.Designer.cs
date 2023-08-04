namespace Project_PRN21
{
    partial class DashBoard
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
            btn_delete = new Button();
            btn_add = new Button();
            label1 = new Label();
            nUd_role = new NumericUpDown();
            txt_pass = new TextBox();
            txt_user = new TextBox();
            label2 = new Label();
            lb = new Label();
            dgv_display = new DataGridView();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            dgv_customer = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nUd_role).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_display).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_customer).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(913, 426);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btn_delete);
            tabPage1.Controls.Add(btn_add);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(nUd_role);
            tabPage1.Controls.Add(txt_pass);
            tabPage1.Controls.Add(txt_user);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(lb);
            tabPage1.Controls.Add(dgv_display);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(905, 398);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Manage Staff";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(792, 273);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(75, 23);
            btn_delete.TabIndex = 8;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
btn_delete.Click += btn_delete_Click;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(671, 273);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(75, 23);
            btn_add.TabIndex = 7;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
btn_add.Click += btn_add_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(671, 174);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 6;
            label1.Text = "Role";
            // 
            // nUd_role
            // 
            nUd_role.Location = new Point(737, 166);
            nUd_role.Name = "nUd_role";
            nUd_role.Size = new Size(130, 23);
            nUd_role.TabIndex = 5;
            // 
            // txt_pass
            // 
            txt_pass.Location = new Point(734, 114);
            txt_pass.Name = "txt_pass";
            txt_pass.Size = new Size(133, 23);
            txt_pass.TabIndex = 4;
            // 
            // txt_user
            // 
            txt_user.Location = new Point(734, 65);
            txt_user.Name = "txt_user";
            txt_user.Size = new Size(133, 23);
            txt_user.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(671, 122);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // lb
            // 
            lb.AutoSize = true;
            lb.Location = new Point(668, 73);
            lb.Name = "lb";
            lb.Size = new Size(60, 15);
            lb.TabIndex = 1;
            lb.Text = "Username";
            // 
            // dgv_display
            // 
            dgv_display.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_display.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_display.Location = new Point(16, 6);
            dgv_display.Name = "dgv_display";
            dgv_display.RowTemplate.Height = 25;
            dgv_display.Size = new Size(624, 386);
            dgv_display.TabIndex = 0;
//dgv_display.CellClick += dgv_display_CellClick;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgv_customer);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(905, 398);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Manage Customer";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(905, 398);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Thống kê";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgv_customer
            // 
            dgv_customer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_customer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_customer.Location = new Point(6, 6);
            dgv_customer.Name = "dgv_customer";
            dgv_customer.RowTemplate.Height = 25;
            dgv_customer.Size = new Size(625, 392);
            dgv_customer.TabIndex = 0;
            // 
            // DashBoard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(929, 450);
            Controls.Add(tabControl1);
            Name = "DashBoard";
            Text = "DashBoard";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nUd_role).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_display).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_customer).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dgv_display;
        private TabPage tabPage3;
        private Label label2;
        private Label label1;
        private NumericUpDown nUd_role;
        private TextBox txt_pass;
        private TextBox txt_user;
        private Label lb;
        private Button btn_delete;
        private Button btn_add;
        private DataGridView dgv_customer;
    }
}