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
    public partial class Form3 : Form
    {
        public static List<string> yearlevel;
        public static List<string> subjects = new List<string>();

        public List<String> subject
        {
            set
            {
                subjects = value;
            }
            get
            {
                return subjects;
            }
        }
        public Form3()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void subjectsCheckedlist_ItemCheck(object sender, ItemCheckEventArgs e)
        {       
         
        }

        private void addClasses_addbutton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < subjectsCheckedlist.Items.Count; i++)
            {
                if (subjectsCheckedlist.GetItemChecked(i))
                {
                    subjects.Add((String)subjectsCheckedlist.Items[i]);
                }
            }
            this.Close();
        }

        private void subjectsCheckedlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
