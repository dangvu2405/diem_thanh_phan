namespace dangnhap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1 != null)
            {
                if (textBox1.Text == "admin" && textBox2.Text == "admin")
                {
                    MessageBox.Show("Đăng nhập thành công");

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại");
                }
            }
            else
            {
                MessageBox.Show("YÊU CẦU NHẬP MẬT KHẨU");
            }
        }
    }
}
