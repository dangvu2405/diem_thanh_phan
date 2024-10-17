using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Text.RegularExpressions;

namespace dangky
{
    public partial class Form1 : Form
    {
        private int dkpass;

        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dk = 0;
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            string email = textBox4.Text;
            // Kiểm tra email với regex
            if (Regex.IsMatch(email, pattern))
            {
                dk++;
                Console.WriteLine("Email hợp lệ..");
            }
            else
            {
                textBox4.BackColor = Color.Red;
                Console.WriteLine("Email 0 hợp lệ.");
            }
            string patternpass = @"^(?=.*[!@#$%^&*(),.?""{}|<>])[A-Za-z\d!@#$%^&*(),.?""{}|<>]{8,}$";
            string password = textBox2.Text;
            string passwordcf= textBox3.Text;
            // Kiểm tra mật khẩu với regex
            if (Regex.IsMatch(password, pattern))
            {
                dk++;
                Console.WriteLine("Mật khẩu hợp lệ.");
            }
            else
            {
                textBox2.BackColor = Color.Red;
                Console.WriteLine("Mật khẩu không hợp lệ. Yêu cầu tối thiểu 8 ký tự và phải bao gồm ít nhất 1 ký tự đặc biệt.");
            }
            if (password.Length >= 8)
            {
                for (int i = 0; i < password.Length; i++)
                {
                    int dkpass = 0;
                    if (char.IsDigit(password[i]))
                    {
                        dkpass++;
                    }
                    else {
                        textBox2.BackColor = Color.Red;
                        Console.WriteLine("Mật khẩu không hợp lệ. Yêu cầu tối thiểu 8 ký tự và phải bao gồm ít nhất 1 ký tự số.");
                    }
                    if (Char.IsUpper(password[i]))
                    {
                        dkpass++;
                        Console.WriteLine("Mật khẩu hợp lệ.");
                    }
                    else
                    {
                        textBox2.BackColor = Color.Red;
                        Console.WriteLine("Mật khẩu không hợp lệ. Yêu cầu tối thiểu 8 ký tự và phải bao gồm ít nhất 1 ký in hoa.");
                    }
                }
                if (password == passwordcf && dkpass == 2 )
                {
                    dk++;
                }
                else
                {
                    textBox3.BackColor = Color.Red;
                    Console.WriteLine("Mật khẩu không trùng khớp.");
                }
            }
            else
            {
                textBox2.BackColor = Color.Red;
            }
            if (dk == 3)
            {
                MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Console.WriteLine("Đăng ký thành công.");
            }
            else
            {
                MessageBox.Show("Đăng ký thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("Đăng ký thất bại.");
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Ẩn các ký tự trong TextBox bằng dấu '*'
            textBox2.PasswordChar = '*';
            textBox3.PasswordChar = '*';
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
          
        }

    }
}
