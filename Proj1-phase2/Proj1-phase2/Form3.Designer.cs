namespace Proj1_phase2
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.yearlevelCheckbox = new System.Windows.Forms.CheckedListBox();
            this.subjectsCheckedlist = new System.Windows.Forms.CheckedListBox();
            this.addClasses_yearlabel = new System.Windows.Forms.Label();
            this.addClasses_subjectlabel = new System.Windows.Forms.Label();
            this.addClasses_addbutton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // yearlevelCheckbox
            // 
            this.yearlevelCheckbox.FormattingEnabled = true;
            this.yearlevelCheckbox.Items.AddRange(new object[] {
            "Year 1",
            "Year 2",
            "Year 3",
            "Year 4",
            "Year 5",
            "Year 6"});
            this.yearlevelCheckbox.Location = new System.Drawing.Point(14, 38);
            this.yearlevelCheckbox.Margin = new System.Windows.Forms.Padding(5);
            this.yearlevelCheckbox.MultiColumn = true;
            this.yearlevelCheckbox.Name = "yearlevelCheckbox";
            this.yearlevelCheckbox.Size = new System.Drawing.Size(726, 19);
            this.yearlevelCheckbox.TabIndex = 0;
            this.yearlevelCheckbox.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // subjectsCheckedlist
            // 
            this.subjectsCheckedlist.BackColor = System.Drawing.SystemColors.Window;
            this.subjectsCheckedlist.ColumnWidth = 200;
            this.subjectsCheckedlist.FormattingEnabled = true;
            this.subjectsCheckedlist.Items.AddRange(new object[] {
            "Astronomy",
            "Charms",
            "DefenceAgainstTheDarkArts",
            "Flying",
            "Herbology",
            "HistoryOfMagic",
            "MuggleStudies",
            "Potions",
            "Transfiguration",
            "Alchemy",
            "Apparition",
            "Arithmancy",
            "CareOfMagicalCreatures",
            "Divination",
            "StudyOfAncientRunes",
            "AncientStudies",
            "Art",
            "FrogChoir",
            "GhoulStudies",
            "MagicalTheory",
            "MuggleArt",
            "Music",
            "MuggleMusic",
            "Orchestra",
            "Xylomancy"});
            this.subjectsCheckedlist.Location = new System.Drawing.Point(14, 119);
            this.subjectsCheckedlist.MultiColumn = true;
            this.subjectsCheckedlist.Name = "subjectsCheckedlist";
            this.subjectsCheckedlist.Size = new System.Drawing.Size(726, 139);
            this.subjectsCheckedlist.TabIndex = 1;
            // 
            // addClasses_yearlabel
            // 
            this.addClasses_yearlabel.AutoSize = true;
            this.addClasses_yearlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addClasses_yearlabel.Location = new System.Drawing.Point(14, 17);
            this.addClasses_yearlabel.Name = "addClasses_yearlabel";
            this.addClasses_yearlabel.Size = new System.Drawing.Size(88, 20);
            this.addClasses_yearlabel.TabIndex = 2;
            this.addClasses_yearlabel.Text = "Year Level:";
            // 
            // addClasses_subjectlabel
            // 
            this.addClasses_subjectlabel.AutoSize = true;
            this.addClasses_subjectlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addClasses_subjectlabel.Location = new System.Drawing.Point(14, 90);
            this.addClasses_subjectlabel.Name = "addClasses_subjectlabel";
            this.addClasses_subjectlabel.Size = new System.Drawing.Size(75, 20);
            this.addClasses_subjectlabel.TabIndex = 3;
            this.addClasses_subjectlabel.Text = "Subjects:";
            // 
            // addClasses_addbutton
            // 
            this.addClasses_addbutton.Location = new System.Drawing.Point(636, 282);
            this.addClasses_addbutton.Name = "addClasses_addbutton";
            this.addClasses_addbutton.Size = new System.Drawing.Size(104, 34);
            this.addClasses_addbutton.TabIndex = 4;
            this.addClasses_addbutton.Text = "Add";
            this.addClasses_addbutton.UseVisualStyleBackColor = true;
            this.addClasses_addbutton.Click += new System.EventHandler(this.addClasses_addbutton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(773, 340);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 337);
            this.Controls.Add(this.addClasses_addbutton);
            this.Controls.Add(this.addClasses_subjectlabel);
            this.Controls.Add(this.addClasses_yearlabel);
            this.Controls.Add(this.subjectsCheckedlist);
            this.Controls.Add(this.yearlevelCheckbox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox yearlevelCheckbox;
        private System.Windows.Forms.CheckedListBox subjectsCheckedlist;
        private System.Windows.Forms.Label addClasses_yearlabel;
        private System.Windows.Forms.Label addClasses_subjectlabel;
        private System.Windows.Forms.Button addClasses_addbutton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}