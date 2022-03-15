using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using University;

namespace UniversityUI
{
    public partial class StudentsForm : DevExpress.XtraEditors.XtraForm
    {
        private List<Student> _students;

        public StudentsForm()
        {
            InitializeComponent();
        }

        private void cmbStudent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void StudentsForm_Load(object sender, EventArgs e)
        {
            _students = Program.university.GetStudents();

            populateStudents();

            comboBox1.DataSource = _students;
            comboBox1.DisplayMember = "Fullname";

            textEdit2.DataBindings.Add(new Binding("EditValue", _students, "Age", true));
            txtRegNumber.DataBindings.Add(new Binding("EditValue", _students, "RegistrationNumber", true));

            BindingSource bsCourses = new BindingSource(_students, "Courses");
            grdCourses.DataSource = bsCourses;
            //grdCourses.DataMember = "Subject";

            gridView1.Columns[0].Visible = false;
            grdCourses.UseEmbeddedNavigator = true;

        }

        private void populateStudents()
        {
            _students.Add(new Student("john", "Eskioglou", 18, 4329));
            _students.Add(new Student("Nick", "Nikolopoulos", 19, 5429));
            _students.Add(new Student("George", "Georgopoulos", 17, 7829));

            int index = 8;
            foreach(Student student in _students)
            {
                student.Courses.Add(new Course("312" + index.ToString(), student.Name));
                student.Courses.Add(new Course("312" + index.ToString(), student.Name));
                student.Courses.Add(new Course("312" + index.ToString(), student.Name));
                student.Courses.Add(new Course("312" + index.ToString(), student.Name));
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}