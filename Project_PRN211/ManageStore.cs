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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Project_PRN21
{
    public partial class ManageStore : Form
    {
        private PRN211_ProjectContext con = new PRN211_ProjectContext();

        public ManageStore()
        {
            InitializeComponent();
            load();
            loadCate();
            loadOrder();
            loadCustomer();
        }
        void load()
        {
            var book = con.Books.Select(b => new
            {
                b.Id,
                b.BName,
                b.Title,
                b.Author,
                b.Nsx,
                b.Quantity,
                b.Price,
                CategoryName = b.Category.CategoryId

            }).ToList();
            dgv_display.DataSource = book;
        }
        void loadCate()
        {
            var cate = con.Categories.Select(s => new
            {
                s.Name,
                s.CategoryId
            }).ToList();
            cbb_cate.DataSource = cate;
            cbb_cate.DisplayMember = "Name";
            cbb_cate.ValueMember = "CategoryId";




        }
        void loadCustomer()
        {
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
        void loadOrder()
        {

            var order = con.Orders.Select(or => new
            {
                OrderID = or.OrderId,
                Book = or.OrderDetails.Select(b => b.Book.BName).FirstOrDefault(),
                DateOrder = or.OrderDate,
                Quantity = or.OrderDetails.Select(od => od.Quantity).FirstOrDefault(),
                Price = or.OrderDetails.Select(od => od.Price).FirstOrDefault(),
                TotatMount = or.TotalAmount


            }).ToList();
            dgv_order.DataSource = order;

        }

        private void dgv_display_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;
            if (n >= 0)
            {
                nUd_id.Value = (int)dgv_display[0, n].Value;
                txt_name.Text = (string)dgv_display[1, n].Value;
                txt_title.Text = (string)dgv_display[2, n].Value;
                txt_author.Text = (string)dgv_display[3, n].Value;
                dtp_nsx.Value = (DateTime)dgv_display[4, n].Value;
                nUd_quantity.Value = ((int)dgv_display[5, n].Value);
                nUd_price.Value = ((decimal)dgv_display[6, n].Value);
                int categoryName = (int)dgv_display[7, n].Value;
                cbb_cate.SelectedValue = categoryName;

            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.Now;
            DateTime nsx = (DateTime)dtp_nsx.Value.Date;
            if (nsx < currentDate.Date)
            {
                try
                {

                    Book book = new Book
                    {
                        BName = (string)txt_name.Text,
                        Title = (string)txt_title.Text,
                        Author = (string)txt_author.Text,
                        Nsx = (DateTime)dtp_nsx.Value.Date,
                        Quantity = (int)(nUd_quantity.Value),
                        Price = Convert.ToDecimal(nUd_price.Value),
                        CategoryId = (int)cbb_cate.SelectedValue

                    };

                    con.Books.Add(book);
                    con.SaveChanges();
                    MessageBox.Show("Thêm sách thành công ", "Thông báo");
                    load();
                }
                catch
                {
                    MessageBox.Show("Vui lòng nhập lại đúng format", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập lại ngày", "Thông báo");
            }

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            var book = con.Books.FirstOrDefault(b => b.Id == nUd_id.Value);
            if (book != null)
            {
                try
                {
                    book.BName = txt_name.Text;
                    book.Title = txt_title.Text;
                    book.Author = txt_author.Text;
                    book.Nsx = dtp_nsx.Value;
                    book.Quantity = (int)nUd_quantity.Value;
                    book.Price = nUd_price.Value;

                    con.Books.Update(book);
                    con.SaveChanges();
                    MessageBox.Show("Update thành công", "Thông báo");
                    load();


                }
                catch
                {
                    MessageBox.Show("Vui lòng nhập đúng format", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy quyển sách này", "Thông báo");

            }

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            var book = con.Books.FirstOrDefault(b => b.Id == nUd_id.Value);
            if (book != null)
            {
                DialogResult result = MessageBox.Show("Bạn có xác nhận xoá quyển sách có ID = " + nUd_id.Value, "Thông báo", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    con.Books.Remove(book);
                    con.SaveChanges();
                    MessageBox.Show("Xoá thành công ", "Thông báo");
                    load();
                }
                else
                {
                    MessageBox.Show("Xoá thất bại ", "Thông báo");
                }



            }
            else
            {
                MessageBox.Show("Không tìm thấy quyển sách này", "Thông báo");

            }
        }

        private void btn_find_Click(object sender, EventArgs e)
        {

            PRN211_ProjectContext con = new PRN211_ProjectContext();
            if (rd_sid.Checked)
            {
                var order = con.Orders.Where(o => o.OrderId == nud_searchID.Value).Select(or => new
                {
                    OrderID = or.OrderId,
                    Book = or.OrderDetails.Select(b => b.Book.BName).FirstOrDefault(),
                    DateOrder = or.OrderDate,
                    Quantity = or.OrderDetails.Select(od => od.Quantity).FirstOrDefault(),
                    Price = or.OrderDetails.Select(od => od.Price).FirstOrDefault(),
                    TotatMount = or.TotalAmount

                }).ToList();
                dgv_order.DataSource = order;
            }
            if (rd_sdate.Checked)
            {
                var order = con.Orders.Where(o => o.OrderDate.Date == dtp_sdate.Value.Date).Select(or => new
                {
                    OrderID = or.OrderId,
                    Book = or.OrderDetails.Select(b => b.Book.BName).FirstOrDefault(),
                    DateOrder = or.OrderDate,
                    Quantity = or.OrderDetails.Select(od => od.Quantity).FirstOrDefault(),
                    Price = or.OrderDetails.Select(od => od.Price).FirstOrDefault(),
                    TotatMount = or.TotalAmount

                }).ToList();
                dgv_order.DataSource = order;
            }


        }

        private void btn_sort_Click(object sender, EventArgs e)
        {
            if (rb_day.Checked)
            {
                var order = con.Orders.OrderByDescending(o => o.OrderDate).Select(or => new
                {
                    OrderID = or.OrderId,
                    Book = or.OrderDetails.Select(b => b.Book.BName).FirstOrDefault(),
                    DateOrder = or.OrderDate,
                    Quantity = or.OrderDetails.Select(od => od.Quantity).FirstOrDefault(),
                    Price = or.OrderDetails.Select(od => od.Price).FirstOrDefault(),
                    TotatMount = or.TotalAmount

                }).ToList();
                dgv_order.DataSource = order;
            }
            if (rb_price.Checked)
            {
                var order = con.Orders.OrderBy(o => o.TotalAmount).Select(or => new
                {
                    OrderID = or.OrderId,
                    Book = or.OrderDetails.Select(b => b.Book.BName).FirstOrDefault(),
                    DateOrder = or.OrderDate,
                    Quantity = or.OrderDetails.Select(od => od.Quantity).FirstOrDefault(),
                    Price = or.OrderDetails.Select(od => od.Price).FirstOrDefault(),
                    TotatMount = or.TotalAmount

                }).ToList();
                dgv_order.DataSource = order;
            }
        }

        private void btn_change_Click(object sender, EventArgs e)
        {

            var acc = con.Accounts.FirstOrDefault(a => a.Username == txtx_user.Text);
            if (acc != null && acc.Password == txt_opass.Text)
            {
                acc.Password = txt_newpass.Text;
                con.Accounts.Update(acc);
                con.SaveChanges();
                MessageBox.Show("Đổi mật khẩu thành công", "Thông báo");
                txtx_user.Text = "";
                txt_opass.Text = "";
                txt_newpass.Text = "";
            }
            else
            {
                MessageBox.Show("Tài khoản or Mật khẩu không chính xác", "Thông báo");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }
    }

}
