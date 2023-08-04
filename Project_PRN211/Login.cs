using Project_PRN21.Models;

namespace Project_PRN21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            PRN211_ProjectContext con = new PRN211_ProjectContext();
            string user = txt_user.Text;
            var acc = con.Accounts.Find(user);
            if (acc != null && acc.Password == txt_pass.Text)
            {
                if (acc.RoleId == 3)
                {
                    MessageBox.Show("Bạn đăng nhập thành công Staff", "Thông báo");
                    this.Hide();
                    ManageStore manageStore = new ManageStore();
                    manageStore.Show();


                }
                else if (acc.RoleId == 1)
                {
                    MessageBox.Show("Bạn đăng nhập thành công Admin", "Thông báo");
                    this.Hide();
                    DashBoard dashBoard = new DashBoard();
                    dashBoard.Show();
                }
                else
                {
                    MessageBox.Show("Bạn đăng nhập thành công user", "Thông báo");
                    this.Hide();
                    Sellbook sellbook = new Sellbook(user);
                    sellbook.Show();

                }

            }
            else
            {
                MessageBox.Show("Bạn đăng nhập không thành công thành công. ", "Thông báo");
                this.Show();
            }
        }

        private void btn_regist_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f = new Form2();
            f.ShowDialog();
            f = null;
            this.Show();

        }


    }
}