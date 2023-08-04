using Microsoft.EntityFrameworkCore;
using Project_PRN21.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Reflection.Metadata.BlobBuilder;

namespace Project_PRN21
{
    public partial class Sellbook : Form
    {
        private int bid;
        private string name;
        private string author;
        private decimal price;
        private int quantity;
        private decimal totalAll;
        private string username;

        public Sellbook(string user)
        {
            InitializeComponent();
            this.username = user;
            loadCate();
            load();
            loadOrder();

        }
        void load()
        {
            PRN211_ProjectContext con = new PRN211_ProjectContext();
            var book = con.Books.Select(b => new
            {
                b.Id,
                b.BName,
                b.Title,
                b.Author,
                b.Nsx,
                b.Quantity,
                b.Price
            }).ToList();
            dgv_display.DataSource = book;
        }
        void loadOrder()
        {
            PRN211_ProjectContext con = new PRN211_ProjectContext();

            var order = con.Orders.Where(o => o.Customer.Username == username).Select(or => new
            {
                OrderID = or.OrderId,
                Book = or.OrderDetails.Select(b => b.Book.BName).FirstOrDefault(),
                DateOrder = or.OrderDate,
                Quantity = or.OrderDetails.Select(od => od.Quantity).FirstOrDefault(),
                Price = or.OrderDetails.Select(od => od.Price).FirstOrDefault(),
                TotatMount = or.TotalAmount


            }).ToList();
            dgv_displayOrder.DataSource = order;

        }
        void loadCate()
        {
            PRN211_ProjectContext con = new PRN211_ProjectContext();
            var cate = con.Categories.Select(s => s.Name).ToList();
            cbb_Cate.DataSource = cate;
        }

        private void dgv_display_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int n = e.RowIndex;
            if (n >= 0)
            {
                nUd_id.Value = (int)dgv_display[0, n].Value;
                txt_name.Text = (string)dgv_display[1, n].Value;
                txt_author.Text = (string)dgv_display[3, n].Value;

                txt_price.Text = ((decimal)dgv_display[6, n].Value).ToString();
                txt_total.Text = "0";


            }
        }

        private void nUd_quantity_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotal();

        }
        private void CalculateTotal()
        {
            int quantity = (int)nUd_quantity.Value;
            decimal price;

            if (decimal.TryParse(txt_price.Text, out price))
            {
                totalAll = quantity * price;
                txt_total.Text = totalAll.ToString();
            }
        }

        private void btn_buy_Click(object sender, EventArgs e)
        {

            PRN211_ProjectContext con = new PRN211_ProjectContext();
            bid = (int)nUd_id.Value;
            name = (string)txt_name.Text;
            author = (string)txt_author.Text;
            price = Convert.ToDecimal(txt_price.Text);
            quantity = (int)nUd_quantity.Value;
            var cus = con.Customers.FirstOrDefault(c => c.Username == username);
            var book = con.Books.Find(bid);
            if (book != null)
            {
                if (quantity > book.Quantity)
                {
                    MessageBox.Show("Quá số lượng kho chỉ còn " + book.Quantity, "Thông báo");
                }
                else
                {
                    if (book.Quantity == 0)
                    {
                        MessageBox.Show("Book này tạm thời hết hàng", "Thông báo");
                    }
                    else
                    {
                        if (cus == null)
                        {
                            if (quantity > 0)
                            {
                                this.Hide();
                                CustomerInfo customerInfo = new CustomerInfo(this);
                                customerInfo.Show();
                            }
                            else
                            {
                                MessageBox.Show("Vui lòng nhập số lượng", "Thông báo");
                            }
                        }
                        else
                        {
                            if (quantity > 0)
                            {
                                DialogResult result = MessageBox.Show("Bạn xác nhận mua quyển sách này.", "Xác nhận", MessageBoxButtons.YesNo);
                                if (result == DialogResult.Yes)
                                {
                                    DateTime currentDate = DateTime.Now;
                                    int cusID = cus.CustomerId;
                                    var oder = new Order
                                    {
                                        CustomerId = cusID,
                                        OrderDate = currentDate.Date,
                                        TotalAmount = totalAll
                                    };
                                    con.Orders.Add(oder);
                                    con.SaveChanges();
                                    int oderID = oder.OrderId;


                                    var oderDetail = new OrderDetail
                                    {
                                        OrderId = oderID,
                                        BookId = book.Id,
                                        Quantity = quantity,
                                        Price = price

                                    };
                                    con.OrderDetails.Add(oderDetail);
                                    con.SaveChanges();
                                    book.Quantity = book.Quantity - quantity;
                                    con.Books.Update(book);
                                    con.SaveChanges();
                                    load();
                                    loadOrder();

                                    MessageBox.Show("Mua hàng thành công", "Thông báo");
                                }
                                else
                                {
                                    MessageBox.Show("Mua hàng thất bại", "Thông báo");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Vui lòng nhập số lượng", "Thông báo");
                            }

                        }
                    }
                }
            }

        }
        public void ReceiveCustomerInfo(string customerName, string email, string phone)
        {
            PRN211_ProjectContext con = new PRN211_ProjectContext();
            var book = con.Books.Find(bid);

            DialogResult result = MessageBox.Show("Bạn xác nhận mua quyển sách này.", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                var custommer = new Customer
                {
                    Name = customerName,
                    Email = email,
                    Phone = phone,
                    Username = username

                };
                con.Customers.Add(custommer);
                con.SaveChanges();


                DateTime currentDate = DateTime.Now;
                int cusID = custommer.CustomerId;
                var oder = new Order
                {
                    CustomerId = cusID,
                    OrderDate = currentDate,
                    TotalAmount = totalAll
                };
                con.Orders.Add(oder);
                con.SaveChanges();
                int oderID = oder.OrderId;


                var oderDetail = new OrderDetail
                {
                    OrderId = oderID,
                    BookId = book.Id,
                    Quantity = quantity,
                    Price = price

                };
                con.OrderDetails.Add(oderDetail);
                con.SaveChanges();
                book.Quantity = book.Quantity - quantity;
                con.Books.Update(book);
                con.SaveChanges();

                MessageBox.Show("Mua hàng thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("Mua hàng thất bại", "Thông báo");
            }


        }
        private void cbb_Cate_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                PRN211_ProjectContext con = new PRN211_ProjectContext();
                string cate = cbb_Cate.SelectedValue.ToString();
                var book = con.Books.Where(b => b.Category.Name.Equals(cate)).Select(b => new
                {
                    b.Id,
                    b.BName,
                    b.Title,
                    b.Author,
                    b.Nsx,
                    b.Quantity,
                    b.Price
                }).ToList();
                dgv_display.Refresh();
                dgv_display.DataSource = book;
            }

        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            load();
            rb_author.Checked = false;
            rb_name.Checked = false;

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            PRN211_ProjectContext con = new PRN211_ProjectContext();
            if (rb_name.Checked)
            {
                string search = txt_Bname.Text;
                var book = con.Books.Where(b => b.BName.Contains(search)).Select(b => new
                {
                    b.Id,
                    b.BName,
                    b.Title,
                    b.Author,
                    b.Nsx,
                    b.Quantity,
                    b.Price
                }).ToList();
                dgv_display.Refresh();
                dgv_display.DataSource = book;
            }
            if (rb_author.Checked)
            {
                string search = txt_sAuthor.Text;
                var book = con.Books.Where(b => b.Author.Contains(search)).Select(b => new
                {
                    b.Id,
                    b.BName,
                    b.Title,
                    b.Author,
                    b.Nsx,
                    b.Quantity,
                    b.Price
                }).ToList();
                dgv_display.Refresh();
                dgv_display.DataSource = book;
            }
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            PRN211_ProjectContext con = new PRN211_ProjectContext();

            var acc = con.Accounts.FirstOrDefault(a => a.Username == txt_user.Text);
            if (acc != null && acc.Password == txt_oldp.Text)
            {
                acc.Password = txt_newp.Text;
                con.Accounts.Update(acc);
                con.SaveChanges();
                MessageBox.Show("Đổi mật khẩu thành công", "Thông báo");
                txt_user.Text = "";
                txt_oldp.Text = "";
                txt_newp.Text = "";
            }
            else
            {
                MessageBox.Show("Tài khoản or Mật khẩu không chính xác", "Thông báo");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PRN211_ProjectContext con = new PRN211_ProjectContext();

        }

        private void btn_updatecus_Click(object sender, EventArgs e)
        {
            PRN211_ProjectContext con = new PRN211_ProjectContext();
            var customer = con.Customers.FirstOrDefault(c => c.Username == username);
            if (customer != null)
            {
                if (ValidateEmail(txt_cemail.Text) && ValidatePhoneNumber(txt_cphone.Text))
                {
                    customer.Name = txt_cname.Text;
                    customer.Email = txt_cemail.Text;
                    customer.Phone = txt_cphone.Text;
                    con.Customers.Update(customer);
                    con.SaveChanges();
                    MessageBox.Show("Cập nhật thành công", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập lại email or mật khẩu");
                }

            }
            else
            {
                if (ValidateEmail(txt_cemail.Text) && ValidatePhoneNumber(txt_cphone.Text))
                {
                    var cus = new Customer
                    {
                        Name = txt_cname.Text,
                        Email = txt_cemail.Text,
                        Phone = txt_cphone.Text,
                        Username = username
                    };

                    con.Customers.Add(cus);
                    con.SaveChanges();
                    MessageBox.Show("Đăng kí khách hàng thành công", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập lại email or mật khẩu");
                }
            }
        }
        public static bool ValidatePhoneNumber(string phoneNumber)
        {
            string pattern = @"^0\\d{9}$";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(phoneNumber);
            return match.Success;
        }

        public static bool ValidateEmail(string email)
        {

            string pattern = @"^[a-zA-Z]{1}[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(email);
            return match.Success;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();

        }
    }
}
