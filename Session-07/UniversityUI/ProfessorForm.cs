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
        private Professor? _currentProfessor;
        public ProfessorForm()
        {
            InitializeComponent();
        }

        private void UniversityForm_Load(object sender, EventArgs e)
        {
            _professorList = Program.university.GetProfessors();
            

            _professorList.Add(new Professor("Kostas", 30, "full"));
            _professorList.Add(new Professor("Nikos", 28, "full"));
            _professorList.Add(new Professor("Giorgos", 30, "full"));
            _professorList.Add(new Professor("John", 32, "associate"));
            _professorList.Add(new Professor("Dimitris", 22, "full"));

            _professorList[1].Courses = new List<Course>();
           
            _professorList[1].Courses.Add(new Course("134", "Physics"));
            _professorList[1].Courses.Add(new Course("134", "Physics"));
            _professorList[1].Courses.Add(new Course("134", "Physics"));
            _professorList[1].Courses.Add(new Course("134", "Physics"));
            
            BindingSource bsCourses = new BindingSource(_professorList, "Courses");
            cmbProfessor.DataSource = _professorList;
            cmbProfessor.DisplayMember = "Name";
            txtAge.DataBindings.Add(new Binding("Editvalue", _professorList, "Age", true));
            RankComboBox.DataBindings.Add("Editvalue", _professorList, "ProfRank", true);

            grdCourses.DataSource = bsCourses;

            grdCourses.UseEmbeddedNavigator = true;
            gridView1.Columns[0].Visible = false;            
            
        }


        private void btnNewProfessor_Click(object sender, EventArgs e)
        {
            
            
            ClearForm();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            
            

            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Program.university.Delete(_currentProfessor);
            //this.ProfessorComboBox.Properties.Items.Remove(_currentProfessor.GetName());
            //int index = this.ProfessorComboBox.SelectedIndex;
            //if (!(index < 0))
            //    _currentProfessor = _professorList[index];
            //else
            //    this.ProfessorComboBox.Text = string.Empty;

            ClearForm();

        }

        private void ClearForm()
        {
            _professorList.Clear();
            this.txtAge.Text = string.Empty;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void TableLayout_Click(object sender, EventArgs e)
        {

        }

    }
}