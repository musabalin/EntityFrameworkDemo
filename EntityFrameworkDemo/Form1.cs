using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EntityFrameworkDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Lesson_List_Click(object sender, EventArgs e)
        {//Adonet
            SqlConnection connection = new SqlConnection(@"Data Source=MUSA-BALIN\SQLEXPRESS;Initial Catalog=Dbo_EntityFrameworkDemo;Integrated Security=True");
            SqlCommand kmt = new SqlCommand("Select * from Tbl_Lessons", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(kmt);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;


        }
        Dbo_EntityFrameworkDemoEntities db = new Dbo_EntityFrameworkDemoEntities();
        private void btn_Student_List_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = db.Tbl_Student.ToList();
        }

        private void btn_Grade_List_Click(object sender, EventArgs e)
        {
            var query = from item in db.Tbl_CourseGrades
                        select new { 
                            item.CGID,
                            item.Student,
                            item.Lesson, 
                            item.CourseGrade1,
                            item.CourseGrade2,
                            item.CourseGrade3 };

            dataGridView1.DataSource = query.ToList();

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Tbl_Student student = new Tbl_Student();
            student.FirstName = txt_ogrname.Text;
            student.LastName = txt_lastname.Text;
            db.Tbl_Student.Add(student);
            db.SaveChanges();
            MessageBox.Show("Added");
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(txt_ogrid.Text);
            //var id = txt_ogrid.Text;
            var result = db.Tbl_Student.Find(id);
            db.Tbl_Student.Remove(result);
            db.SaveChanges();
            MessageBox.Show("Deleted");

        }
    }
}
