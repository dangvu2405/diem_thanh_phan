namespace quanlisinhvien
{
    public partial class Form1 : Form
    {
        List<Student> students = new List<Student>();
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Chỉ thực hiện khi chỉ số hàng và cột hợp lệ
                int rowIndex = e.RowIndex;
                // Tiếp tục xử lý logic
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một ô hợp lệ.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = students;
            dataGridView1.AutoGenerateColumns = true;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int studentId;
            if (!int.TryParse(textBox1.Text, out studentId))
            {
                MessageBox.Show("Vui lòng nhập ID là số nguyên hợp lệ.");
                return;
            }

            // Thêm sinh viên mới nếu ID hợp lệ
            Student newStudent = new Student()
            {
                Id = studentId,
                Name = textBox2.Text,
                Class = textBox3.Text,
            };
            students.Add(newStudent);
            dataGridView1.DataSource = null;  // Reset lại nguồn dữ liệu
            dataGridView1.DataSource = students; // Cập nhật lại DataGridView
            dataGridView1.Refresh();  // Làm mới DataGridView sau khi cập nhật dữ liệu

        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int index = dataGridView1.CurrentRow.Index; // Chỉ số hàng hiện tại
                Student selectedStudent = students[index];

                // Cập nhật thông tin sinh viên
                int studentId;
                if (!int.TryParse(textBox1.Text, out studentId))
                {
                    MessageBox.Show("Vui lòng nhập ID là số nguyên hợp lệ.");
                    return;
                }

                selectedStudent.Id = studentId;
                selectedStudent.Name = textBox2.Text;
                selectedStudent.Class = textBox3.Text;

                // Cập nhật lại DataGridView
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = students;
                dataGridView1.Refresh();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sinh viên để sửa."); // Thông báo nếu không có hàng nào được chọn
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int index = dataGridView1.CurrentRow.Index;
                students.RemoveAt(index);

                dataGridView1.DataSource = null;  // Reset lại nguồn dữ liệu
                dataGridView1.DataSource = students; // Cập nhật lại DataGridView
                dataGridView1.Refresh();  // Làm mới DataGridView sau khi cập nhật dữ liệu

            }
            else
            {
                MessageBox.Show("Vui lòng chọn sinh viên để xóa.");
            }
        }
    }
    public class Student
    {
        public int Id { get; set; }  // Đổi kiểu từ string sang int
        public string Name { get; set; }
        public string Class { get; set; }
    }

}
