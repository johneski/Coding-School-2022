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
    public partial class ProfessorForm : DevExpress.XtraEditors.XtraForm
    {
        private List<Professor> _professorList;
        private Professor _currentProfessor;
        public ProfessorForm()
        {
            InitializeComponent();
        }

        private void UniversityForm_Load(object sender, EventArgs e)
        {
            _professorList = Program.university.GetProfessors();
            foreach (Professor prof in _professorList) 
                this.ProfessorComboBox.AppendText(prof.GetName());
            
        }

        private void LoadCourseComboBox(object sender, EventArgs e)
        {
            try
            {
                _currentProfessor = _professorList[this.ProfessorComboBox.SelectedIndex];
                int index = 0;
                foreach (Course course in Program.university.GetCourses())
                {
                    if (_currentProfessor.TeachesCourse(course))
                    {
                        this.CourseListBox.SetItemValue(course, index);
                        index++;
                    }

                }
            }
            catch (ArgumentOutOfRangeException)
            {

            }
            
                
        }

        private void btnNewProfessor_Click(object sender, EventArgs e)
        {
            
            this.ProfessorComboBox.Properties.Items.Add("new Professor");
            this.ProfessorComboBox.EditValue = "new Professor";
            this.StudentComboBox.Properties.Items.Clear();
            this.StudentComboBox.EditValue = null;
            this.txtName.Text = string.Empty;
            this.txtAge.Text = string.Empty;
            this.CourseListBox.Items.Clear();
        }
    }
}