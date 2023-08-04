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


namespace Project_PRN21
{
    public partial class CustomerInfo : Form
    {
        private Sellbook sellbook;
        public CustomerInfo(Sellbook sellbook1)
        {
            InitializeComponent();
            this.sellbook = sellbook1;
        }

        private void btn_customer_Click(object sender, EventArgs e)
        {

            string name = txt_name.Text;
            string email = txt_email.Text;
            string phone = txt_phone.Text;
            bool validPhone = ValidatePhoneNumber(phone);
            bool validEmail = ValidateEmail(email);
            if (validEmail && validPhone && name.Length >= 6)
            {

                sellbook.ReceiveCustomerInfo(name, email, phone);
                this.Close();
                sellbook.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập lại");
            }

        }
        public static bool ValidatePhoneNumber(string phoneNumber)
        {
            string pattern = @"^0\d{9}$";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(phoneNumber);
            return match.Success;
        }

        public static bool ValidateEmail(string email)
        {

            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(email);
            return match.Success;
        }
    }
}
