
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
    public partial class Form1 : Form
    {

        List<Student> student = new List<Student>();
        FileManager fm = new FileManager();

        Form2 form2 = new Form2();

        public Form1()
        {
            InitializeComponent();

            form2.FormClosed += form2_FormClosed;
        }


        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            //openFileDialog1.FileName
            fm.LoadJsonFile(openFileDialog1.FileName, out student);

            foreach (Student s in student)
            {

                nameBox.Items.Add(s.Name);
            }
        }


        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            student.Clear();
            studentBox.Items.Clear();
        }

        private void studentBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            fm.SaveJsonFile(saveFileDialog1.FileName, student);
        }


        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void nameBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            //populating the details of the student
            foreach (Student s in student)
            {
   
                    if (s.Name == nameBox.SelectedItem.ToString())
                    {
                    studentBox.Items.Clear();
                        
                        studentBox.Items.Add(s.Name);
                        studentBox.Items.Add("Date of Birth: " + s.DateOfBirth);
                        studentBox.Items.Add("Year Level: " + s.YearLevel);
                        studentBox.Items.Add("Date of Graduation: " + s.DateOfGraduation);
                        studentBox.Items.Add("House: " + s.House);
                        studentBox.Items.Add("Has Hogsmeade Permission form: " + s.HasHogsmeadePermissionForm);
                        studentBox.Items.Add("\n");

                        for (int i = 0; i < s.Subjects.Count; i++)
                        {
                            studentBox.Items.Add("Year " + (i + 1) + ": ");
                            foreach (HogwartsSubject sub in s.Subjects[i])
                            {
                                studentBox.Items.Add("\t" + sub);
                                studentBox.Items.Add("\n");
                            }
                        }
                        studentBox.Items.Add("\n");
                        studentBox.Items.Add("Detentions: ");
                        foreach (Detention d in s.Detentions)
                        {
                            studentBox.Items.Add("\t" + d.Reason);
                            studentBox.Items.Add("\t" + d.Date);
                            studentBox.Items.Add("\t" + d.IssuedBy);
                            studentBox.Items.Add("\t" + d.Punishment);
                            studentBox.Items.Add("\t" + d.PointsTaken);
                            studentBox.Items.Add("\n");
                        }
                    }   
            }
        }

        private void newUser_Click(object sender, EventArgs e)
        {

            form2.addedStudentName = nameBox.Text;

            form2.Show();

           

        }
        //Populates the Edit form with the data of the student that is already present 
        private void editUserButton_Click(object sender, EventArgs e)
        {
            form2.Show();

            foreach(Student s in student)
            {
                if (s.HasHogsmeadePermissionForm)
                {
                    form2.HasHogsmeadePermissionForm = "Yes";
                }
                else
                {
                    form2.HasHogsmeadePermissionForm = "No";
                }

                form2.name = s.Name;
                form2.dateofBirth = s.DateOfBirth.ToString();
                form2.yearlevel = s.YearLevel;
                form2.houseofStudent = s.House.ToString();
                









                //Check if there is a DateofGrad
                if (s.DateOfGraduation >= DateTimePicker.MinimumDateTime && s.DateOfGraduation <= DateTimePicker.MaximumDateTime)
                {
                    form2.dateofGrad = s.DateOfGraduation.ToString();
                }
                else
                {
                    continue;
                }

                
            }
        }

        public void form2_FormClosed(object sender, FormClosedEventArgs args)
        {
            nameBox.Items.Add(form2.addedStudentName);
            student.Add(form2.theNewstudent);
        }

       
    }
    
}
