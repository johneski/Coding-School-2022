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
using System.Text.Json;
using System.IO;
using University;

namespace UniversityUI
{
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        public UniversityManager university;
        public Exam exam { get; set; }
        public Professor prof { get; set; }
        public XtraForm1()
        {
            InitializeComponent();

            
        }

        private void schedulleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void universityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            ProfessorForm form = new ProfessorForm();
            form.ShowDialog();
        }

        private void XtraForm1_Load(object sender, EventArgs e)
        {
            

            try
            {
                string text = File.ReadAllText("university.json");
                university = (UniversityManager)JsonSerializer.Deserialize(text, typeof(UniversityManager));
            }
            catch (FileNotFoundException ex)
            {
                university = new UniversityManager(string.Empty, 0);
            }
            
        }
    }
}