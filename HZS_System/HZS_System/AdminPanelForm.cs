using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HZS_System
{
    public partial class AdminPanelForm : Form
    {

        public AdminPanelForm()
        {
            InitializeComponent();
            this.button2.Click += new EventHandler(this.ShowMentorForm);
            this.button3.Click += new EventHandler(this.ShowStudentForm);
            this.button12.Click += new EventHandler(this.ShowScheduleForm);
            this.button4.Click += new EventHandler(this.ShowGroupForm);
            this.button5.Click += new EventHandler(this.ShowGroupTypeForm);
            this.button11.Click += new EventHandler(this.ShowTaskTypeForm);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TeacherPanel teacher = new TeacherPanel();
            teacher.ShowDialog();
        }


        private void ShowMentorForm(object sender, EventArgs e)
        {
            MentorForm form = new MentorForm();
            form.ShowDialog();
        }


        private void ShowStudentForm(object sender, EventArgs e)
        {
            StudentPanel form = new StudentPanel();
            form.ShowDialog();
        }

<<<<<<< HEAD
        private void button10_Click(object sender, EventArgs e)
        {
            GenderPanel gender = new GenderPanel();
            gender.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TaskPanel2 tasks = new TaskPanel2();
            tasks.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            StudentProfilForm student = new StudentProfilForm();
            student.ShowDialog();
=======
        private void ShowScheduleForm(object sender, EventArgs e)
        {
            new GroupScheduleForm().ShowDialog();
        }

        private void ShowGroupForm(object sender, EventArgs e)
        {
            new GroupForm().ShowDialog();
        }

        private void ShowGroupTypeForm(object sender, EventArgs e)
        {
            new GroupTypeForm().ShowDialog();
        }

        private void ShowTaskTypeForm(object sender, EventArgs e)
        {
            new TaskTypeForm().ShowDialog();
>>>>>>> 638bc23a2490ae9a00d197094749e2aa4f13147f
        }
    }
}
