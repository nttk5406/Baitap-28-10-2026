
using MySqlConnector;

namespace LoginForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();

            bool hopLe = true;

            if (txtUsername.Text.Trim() == "")
            {
                errorProvider.SetError(txtUsername, "Không được để trống tên đăng nhập!");
                hopLe = false;
            }

            if (txtPassword.Text == "")
            {
                errorProvider.SetError(txtPassword, "Không được để trống mật khẩu!");
                hopLe = false;
            }

            if (!hopLe)
            {
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(Db.ConnectionString))
                {
                    conn.Open();

                    string sql = "SELECT COUNT(*) FROM Users WHERE Username = @username AND Password = @password";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", txtUsername.Text.Trim());
                        cmd.Parameters.AddWithValue("@password", txtPassword.Text);

                        int ketQua = Convert.ToInt32(cmd.ExecuteScalar());

                        if (ketQua > 0)
                        {
                            MessageBox.Show("Đăng nhập thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối CSDL: " + ex.Message);
            }
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
