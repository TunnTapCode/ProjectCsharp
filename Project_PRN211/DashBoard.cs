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
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
            load();
            customer();
        }
        void customer()
        {

            PRN211_ProjectContext con = new PRN211_ProjectContext();
            var customer = con.Customers.Select(c => new
            {
                c.CustomerId,
                c.Name,
                c.Email,
                c.Phone,
                c.Username,
                c.UsernameNavigation.Password,
                TotalOrder = c.Orders.Sum(o => o.TotalAmount)
            }).ToList();
            dgv_customer.DataSource = customer;
        }
        void load()
        {
            PRN211_ProjectContext con = new PRN211_ProjectContext();
            var st = con.Accounts.Where(s => s.RoleId == 3).Select(e => new
            {
                Username = e.Username,
                Password = e.Password,
                RoleId = e.RoleId

            }).ToList();
            dgv_display.DataSource = st;
        }

        private void dgv_display_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;
            if (n >= 0)
            {

                txt_user.Text = (string)dgv_display[0, n].Value;
                txt_pass.Text = (string)dgv_display[1, n].Value;
                nUd_role.Value = (int)dgv_display[2, n].Value;


            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            PRN211_ProjectContext con = new PRN211_ProjectContext();
            var st = con.Accounts.Find(txt_user.Text);
            if (st == null)
            {
                st = new Account
                {
                    Username = txt_user.Text,
                    Password = txt_pass.Text,
                    RoleId = 3

                };
                con.Accounts.Add(st);
                con.SaveChanges();
                MessageBox.Show("Add successfull");
                load();
            }
            else
            {
                MessageBox.Show("Staff đã tồn tại");
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            PRN211_ProjectContext con = new PRN211_ProjectContext();
            var st = con.Accounts.Find(txt_user.Text);
            if (st != null)
            {
                con.Accounts.Remove(st);
                con.SaveChanges();
                MessageBox.Show("Delete successfull");
                load();
            }
            else
            {
                MessageBox.Show("Staff không tồn tại");
            }
        }
    }
}

