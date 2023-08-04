using Project_PRN21.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_PRN21
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_regist_Click(object sender, EventArgs e)
        {
            PRN211_ProjectContext con = new PRN211_ProjectContext();
            var acc = con.Accounts.FirstOrDefault(a => a.Username == txt_user.Text);

            if (acc == null)
            {
                if (txt_user.Text != "" && txt_pass.Text != "" && txt_repass.Text != "")
                {

                    if (txt_pass.Text == txt_repass.Text)
                    {
                        con.Accounts.Add(new Account
                        {
                            Username = (string)txt_user.Text,
                            Password = (string)txt_pass.Text,
                            RoleId = 2
                        });
                        con.SaveChanges();
                        MessageBox.Show("Đăng kí thành công", "Thông báo");
                        this.Close();
                        Form1 f1 = new Form1();
                        f1.Show();
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu không khớp", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng điền hết thông tin .", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Tài khoản đã tồn tại", "Thông báo");
            }
        }
    }
}

