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
        public ProfessorForm()
        {
            InitializeComponent();
        }

        private void UniversityForm_Load(object sender, EventArgs e)
        {
            foreach (Course course in Program.university.GetCourses())
                this.ProfessorComboBox.AppendText(course.Code);
        }
    }
}