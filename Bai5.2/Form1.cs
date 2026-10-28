
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySqlConnector;

namespace Dangky
{
    public partial class Form1 : Form
    {
        public class Course
        {
            public int CourseId { get; set; }
            public string CourseName { get; set; }

            public Course(int courseId, string courseName)
            {
                CourseId = courseId;
                CourseName = courseName;
            }
        }

        public Form1()
        {
            InitializeComponent();
            LoadCourses();
        }

        private void LoadCourses()
        {
            List<Course> courses = new List<Course>();

            try
            {
                using (MySqlConnection conn = new MySqlConnection(Db.ConnectionString))
                {
                    conn.Open();

                    string sql = "SELECT Id, CourseName FROM Courses";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            courses.Add(new Course(
                                Convert.ToInt32(reader["Id"]),
                                reader["CourseName"].ToString()
                            ));
                        }
                    }
                }

                cboCourse.DataSource = courses;
                cboCourse.DisplayMember = "CourseName";
                cboCourse.ValueMember = "CourseId";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải khóa học: " + ex.Message);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string hoTen = textFullName.Text.Trim();
            string soDienThoai = mtxtPhone.Text;
            DateTime ngaySinh = dtpBirthDate.Value.Date;
            string gioiTinh = "";

            if (rdoMale.Checked)
            {
                gioiTinh = "Nam";
            }
            else if (rdoFemale.Checked)
            {
                gioiTinh = "Nữ";
            }

            string monHoc = "";

            if (chkCSharp.Checked)
            {
                monHoc += "C# ";
            }

            if (chkJava.Checked)
            {
                monHoc += "Java ";
            }

            if (chkCpp.Checked)
            {
                monHoc += "C++ ";
            }

            if (hoTen == "")
            {
                MessageBox.Show("Vui lòng nhập họ tên!");
                textFullName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(soDienThoai) ||
                soDienThoai.Contains("_"))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ số điện thoại!");
                mtxtPhone.Focus();
                return;
            }

            if (cboCourse.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn khóa học!");
                return;
            }

            if (gioiTinh == "")
            {
                MessageBox.Show("Vui lòng chọn giới tính!");
                return;
            }

            string khoaHoc = cboCourse.Text;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(Db.ConnectionString))
                {
                    conn.Open();

                    string sql = @"INSERT INTO Registrations
                        (FullName, Phone, BirthDate, Course, Gender, Languages)
                        VALUES
                        (@FullName, @Phone, @BirthDate, @Course, @Gender, @Languages)";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@FullName", hoTen);
                        cmd.Parameters.AddWithValue("@Phone", soDienThoai);
                        cmd.Parameters.AddWithValue("@BirthDate", ngaySinh);
                        cmd.Parameters.AddWithValue("@Course", khoaHoc);
                        cmd.Parameters.AddWithValue("@Gender", gioiTinh);
                        cmd.Parameters.AddWithValue("@Languages", monHoc.Trim());

                        cmd.ExecuteNonQuery();
                    }
                }

                string thongTin = "Họ tên: " + hoTen +
                                  "\nSố điện thoại: " + soDienThoai +
                                  "\nNgày sinh: " + ngaySinh.ToString("dd/MM/yyyy") +
                                  "\nKhóa học: " + khoaHoc +
                                  "\nGiới tính: " + gioiTinh +
                                  "\nNgôn ngữ: " + monHoc;

                MessageBox.Show(thongTin, "Đăng ký thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lưu dữ liệu: " + ex.Message);
            }
        }
    }
}
