using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj1_phase2
{
    public partial class Form2 : Form
    {
        Student s = new Student();
        Form3 form3 = new Form3();

        public string name
        {
            set
            {
                studentName.Text = value;
            }
            get
            {
                return studentName.Text;
            }
        }

        public string dateofBirth
        {
            set
            {
                dateofBirthbox.Text = value;
            }
            get
            {
                return dateofBirthbox.Text;
            }
        }

        public string dateofGrad
        {
            set
            {
                dateofGradbox.Text = value;
            }
            get
            {
                return dateofGradbox.Text;
            }
        }

        public string houseofStudent
        {
            set
            {
                house.Text = value;
            }
            get
            {
                return house.Text;
            }
        }
         public int yearlevel
        {           
            set
            {              
                yearLvl.Text = value.ToString();
            }
            get
            {
                return Int32.Parse(yearLvl.Text);
            }
        }

        public string HasHogsmeadePermissionForm {
            set
            {
                hogsmeadeForm.Text = value;
            }
            get
            {
                return hogsmeadeForm.Text;
            }
        }

        public string addedStudentName
        {
            set
            {
                studentName.Text = value;
            }
            get
            {
                return studentName.Text;
            }
        }

        public Student theNewstudent
        {
            set
            {
               
            }
            get
            {
                return s;
            }
        }



       
        public Form2()
        {
            InitializeComponent();
            form3.FormClosed += form3_FormClosed;
        }

        private void hogsmeadeForm_SelectedIndexChanged(object sender, EventArgs e)
        {         
            if ((string)hogsmeadeForm.SelectedItem == "Yes")
            {
                s.HasHogsmeadePermissionForm = true;
            }
            else
            {
                s.HasHogsmeadePermissionForm = false;
            }
        }

        private void house_SelectedIndexChanged(object sender, EventArgs e) {
            int value = house.SelectedIndex;
            s.House = (HogwartsHouse)value;

        }

        private void yearLvl_SelectedIndexChanged(object sender, EventArgs e)
        {
            int result = 0;
            if (int.TryParse(yearLvl.SelectedText, out result)){
                s.YearLevel = result;
            }
            
        }

        private void yearforClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            //EDITING Classes
            if (yearforClass.SelectedIndex == 1)
            {
                classesBox.Items.Add(s.Subjects["Subjects"[0]]);
                
            }
        }

        private void addtoClassButton_Click(object sender, EventArgs e)
        {
            //form3.subject = classesBox.Items.Add

            form3.Show();
        }

        //Check for date of grad. If it is the same as current date, student should be still in school
        private void dateofGradbox_ValueChanged(object sender, EventArgs e)
        {
            if(dateofGradbox.Value == DateTime.Now)
            {
                dateofGrad_check.Visible = true;
            }
            
        }

        private void studentName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateofBirthbox_ValueChanged(object sender, EventArgs e)
        {
            s.DateOfBirth = dateofBirthbox.Value;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {          
    
            this.Close();
        }

        public void form3_FormClosed(object sender, FormClosedEventArgs args)
        {
            classesBox.Items.Add(form3.subject);
        }
    }
}
