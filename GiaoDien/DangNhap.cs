using Business;

namespace GiaoDien
{
    public partial class fDangNhap : Form
    {
        public fDangNhap()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            QLTaiKhoanBU qL = new QLTaiKhoanBU();
            if(txtUsername.Text == "" || txtPassWord.Text == "")
            {
                MessageBox.Show(" Tên tài khoản và mật khẩu không được trống!");
            }
            else
            {
                if (qL.DangNhap(txtUsername.Text, txtPassWord.Text))
                {
                    fQuanLy fQuanLy = new fQuanLy();
                    this.Hide();
                    fQuanLy.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show(" Tên đăng nhập hoặc mật khẩu không đúng");
                }
            }
            

        }
    }
}