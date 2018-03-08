namespace Proj1_phase2
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.studentName = new System.Windows.Forms.TextBox();
            this.hogsmeadeForm = new System.Windows.Forms.ComboBox();
            this.house = new System.Windows.Forms.ComboBox();
            this.dateofBirthbox = new System.Windows.Forms.DateTimePicker();
            this.dateofGradbox = new System.Windows.Forms.DateTimePicker();
            this.yearLvl = new System.Windows.Forms.ComboBox();
            this.newStudentName = new System.Windows.Forms.Label();
            this.DOB = new System.Windows.Forms.Label();
            this.doGrad = new System.Windows.Forms.Label();
            this.houseLabel = new System.Windows.Forms.Label();
            this.yrLevellabel = new System.Windows.Forms.Label();
            this.hogsmeadeLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.classesBox = new System.Windows.Forms.ListBox();
            this.detentionBox = new System.Windows.Forms.ListBox();
            this.yearforClass = new System.Windows.Forms.ComboBox();
            this.addtoClassButton = new System.Windows.Forms.Button();
            this.deleteClassButton = new System.Windows.Forms.Button();
            this.AddDetentionButton = new System.Windows.Forms.Button();
            this.deleteDetentionButton = new System.Windows.Forms.Button();
            this.dateofGrad_check = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // studentName
            // 
            this.studentName.Location = new System.Drawing.Point(38, 60);
            this.studentName.Name = "studentName";
            this.studentName.Size = new System.Drawing.Size(249, 20);
            this.studentName.TabIndex = 0;
            this.studentName.TextChanged += new System.EventHandler(this.studentName_TextChanged);
            // 
            // hogsmeadeForm
            // 
            this.hogsmeadeForm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hogsmeadeForm.FormattingEnabled = true;
            this.hogsmeadeForm.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.hogsmeadeForm.Location = new System.Drawing.Point(38, 357);
            this.hogsmeadeForm.Name = "hogsmeadeForm";
            this.hogsmeadeForm.Size = new System.Drawing.Size(165, 21);
            this.hogsmeadeForm.TabIndex = 5;
            this.hogsmeadeForm.SelectedIndexChanged += new System.EventHandler(this.hogsmeadeForm_SelectedIndexChanged);
            // 
            // house
            // 
            this.house.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.house.FormattingEnabled = true;
            this.house.Items.AddRange(new object[] {
            "Gryffindor",
            "Hufflepuff",
            "Ravenclaw",
            "Slytherin"});
            this.house.Location = new System.Drawing.Point(38, 237);
            this.house.Name = "house";
            this.house.Size = new System.Drawing.Size(131, 21);
            this.house.TabIndex = 6;
            this.house.SelectedIndexChanged += new System.EventHandler(this.house_SelectedIndexChanged);
            // 
            // dateofBirthbox
            // 
            this.dateofBirthbox.Location = new System.Drawing.Point(38, 110);
            this.dateofBirthbox.Name = "dateofBirthbox";
            this.dateofBirthbox.Size = new System.Drawing.Size(249, 20);
            this.dateofBirthbox.TabIndex = 7;
            this.dateofBirthbox.ValueChanged += new System.EventHandler(this.dateofBirthbox_ValueChanged);
            // 
            // dateofGradbox
            // 
            this.dateofGradbox.Location = new System.Drawing.Point(38, 166);
            this.dateofGradbox.Name = "dateofGradbox";
            this.dateofGradbox.Size = new System.Drawing.Size(249, 20);
            this.dateofGradbox.TabIndex = 8;
            this.dateofGradbox.ValueChanged += new System.EventHandler(this.dateofGradbox_ValueChanged);
            // 
            // yearLvl
            // 
            this.yearLvl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yearLvl.FormattingEnabled = true;
            this.yearLvl.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.yearLvl.Location = new System.Drawing.Point(38, 297);
            this.yearLvl.Name = "yearLvl";
            this.yearLvl.Size = new System.Drawing.Size(97, 21);
            this.yearLvl.TabIndex = 9;
            this.yearLvl.SelectedIndexChanged += new System.EventHandler(this.yearLvl_SelectedIndexChanged);
            // 
            // newStudentName
            // 
            this.newStudentName.AutoSize = true;
            this.newStudentName.Location = new System.Drawing.Point(35, 44);
            this.newStudentName.Name = "newStudentName";
            this.newStudentName.Size = new System.Drawing.Size(38, 13);
            this.newStudentName.TabIndex = 10;
            this.newStudentName.Text = "Name:";
            // 
            // DOB
            // 
            this.DOB.AutoSize = true;
            this.DOB.Location = new System.Drawing.Point(35, 91);
            this.DOB.Name = "DOB";
            this.DOB.Size = new System.Drawing.Size(69, 13);
            this.DOB.TabIndex = 11;
            this.DOB.Text = "Date of Birth:";
            // 
            // doGrad
            // 
            this.doGrad.AutoSize = true;
            this.doGrad.Location = new System.Drawing.Point(35, 150);
            this.doGrad.Name = "doGrad";
            this.doGrad.Size = new System.Drawing.Size(100, 13);
            this.doGrad.TabIndex = 12;
            this.doGrad.Text = "Date of Graduation:";
            // 
            // houseLabel
            // 
            this.houseLabel.AutoSize = true;
            this.houseLabel.Location = new System.Drawing.Point(35, 221);
            this.houseLabel.Name = "houseLabel";
            this.houseLabel.Size = new System.Drawing.Size(41, 13);
            this.houseLabel.TabIndex = 13;
            this.houseLabel.Text = "House:";
            // 
            // yrLevellabel
            // 
            this.yrLevellabel.AutoSize = true;
            this.yrLevellabel.Location = new System.Drawing.Point(35, 281);
            this.yrLevellabel.Name = "yrLevellabel";
            this.yrLevellabel.Size = new System.Drawing.Size(57, 13);
            this.yrLevellabel.TabIndex = 14;
            this.yrLevellabel.Text = "Year level:";
            // 
            // hogsmeadeLabel
            // 
            this.hogsmeadeLabel.AutoSize = true;
            this.hogsmeadeLabel.Location = new System.Drawing.Point(35, 341);
            this.hogsmeadeLabel.Name = "hogsmeadeLabel";
            this.hogsmeadeLabel.Size = new System.Drawing.Size(146, 13);
            this.hogsmeadeLabel.TabIndex = 15;
            this.hogsmeadeLabel.Text = "Hogsmeade Permission Form:";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(38, 478);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(140, 42);
            this.submitButton.TabIndex = 16;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // classesBox
            // 
            this.classesBox.FormattingEnabled = true;
            this.classesBox.Location = new System.Drawing.Point(331, 111);
            this.classesBox.Name = "classesBox";
            this.classesBox.Size = new System.Drawing.Size(235, 303);
            this.classesBox.TabIndex = 17;
            // 
            // detentionBox
            // 
            this.detentionBox.FormattingEnabled = true;
            this.detentionBox.Location = new System.Drawing.Point(583, 110);
            this.detentionBox.Name = "detentionBox";
            this.detentionBox.Size = new System.Drawing.Size(253, 303);
            this.detentionBox.TabIndex = 18;
            // 
            // yearforClass
            // 
            this.yearforClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yearforClass.FormattingEnabled = true;
            this.yearforClass.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.yearforClass.Location = new System.Drawing.Point(331, 73);
            this.yearforClass.Name = "yearforClass";
            this.yearforClass.Size = new System.Drawing.Size(121, 21);
            this.yearforClass.TabIndex = 19;
            this.yearforClass.SelectedIndexChanged += new System.EventHandler(this.yearforClass_SelectedIndexChanged);
            // 
            // addtoClassButton
            // 
            this.addtoClassButton.Location = new System.Drawing.Point(332, 432);
            this.addtoClassButton.Name = "addtoClassButton";
            this.addtoClassButton.Size = new System.Drawing.Size(75, 23);
            this.addtoClassButton.TabIndex = 23;
            this.addtoClassButton.Text = "Add";
            this.addtoClassButton.UseVisualStyleBackColor = true;
            this.addtoClassButton.Click += new System.EventHandler(this.addtoClassButton_Click);
            // 
            // deleteClassButton
            // 
            this.deleteClassButton.Location = new System.Drawing.Point(423, 432);
            this.deleteClassButton.Name = "deleteClassButton";
            this.deleteClassButton.Size = new System.Drawing.Size(75, 23);
            this.deleteClassButton.TabIndex = 24;
            this.deleteClassButton.Text = "Delete";
            this.deleteClassButton.UseVisualStyleBackColor = true;
            // 
            // AddDetentionButton
            // 
            this.AddDetentionButton.Location = new System.Drawing.Point(584, 432);
            this.AddDetentionButton.Name = "AddDetentionButton";
            this.AddDetentionButton.Size = new System.Drawing.Size(75, 23);
            this.AddDetentionButton.TabIndex = 25;
            this.AddDetentionButton.Text = "Add";
            this.AddDetentionButton.UseVisualStyleBackColor = true;
            // 
            // deleteDetentionButton
            // 
            this.deleteDetentionButton.Location = new System.Drawing.Point(676, 432);
            this.deleteDetentionButton.Name = "deleteDetentionButton";
            this.deleteDetentionButton.Size = new System.Drawing.Size(75, 23);
            this.deleteDetentionButton.TabIndex = 26;
            this.deleteDetentionButton.Text = "Delete";
            this.deleteDetentionButton.UseVisualStyleBackColor = true;
            // 
            // dateofGrad_check
            // 
            this.dateofGrad_check.Location = new System.Drawing.Point(38, 192);
            this.dateofGrad_check.Name = "dateofGrad_check";
            this.dateofGrad_check.ReadOnly = true;
            this.dateofGrad_check.Size = new System.Drawing.Size(153, 20);
            this.dateofGrad_check.TabIndex = 27;
            this.dateofGrad_check.Text = "Still in school...";
            this.dateofGrad_check.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(867, 567);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(762, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(105, 101);
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 566);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dateofGrad_check);
            this.Controls.Add(this.deleteDetentionButton);
            this.Controls.Add(this.AddDetentionButton);
            this.Controls.Add(this.deleteClassButton);
            this.Controls.Add(this.addtoClassButton);
            this.Controls.Add(this.yearforClass);
            this.Controls.Add(this.detentionBox);
            this.Controls.Add(this.classesBox);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.hogsmeadeLabel);
            this.Controls.Add(this.yrLevellabel);
            this.Controls.Add(this.houseLabel);
            this.Controls.Add(this.doGrad);
            this.Controls.Add(this.DOB);
            this.Controls.Add(this.newStudentName);
            this.Controls.Add(this.yearLvl);
            this.Controls.Add(this.dateofGradbox);
            this.Controls.Add(this.dateofBirthbox);
            this.Controls.Add(this.house);
            this.Controls.Add(this.hogsmeadeForm);
            this.Controls.Add(this.studentName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox studentName;
        private System.Windows.Forms.ComboBox hogsmeadeForm;
        private System.Windows.Forms.ComboBox house;
        private System.Windows.Forms.DateTimePicker dateofBirthbox;
        private System.Windows.Forms.DateTimePicker dateofGradbox;
        private System.Windows.Forms.ComboBox yearLvl;
        private System.Windows.Forms.Label newStudentName;
        private System.Windows.Forms.Label DOB;
        private System.Windows.Forms.Label doGrad;
        private System.Windows.Forms.Label houseLabel;
        private System.Windows.Forms.Label yrLevellabel;
        private System.Windows.Forms.Label hogsmeadeLabel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.ListBox classesBox;
        private System.Windows.Forms.ListBox detentionBox;
        private System.Windows.Forms.ComboBox yearforClass;
        private System.Windows.Forms.Button addtoClassButton;
        private System.Windows.Forms.Button deleteClassButton;
        private System.Windows.Forms.Button AddDetentionButton;
        private System.Windows.Forms.Button deleteDetentionButton;
        private System.Windows.Forms.TextBox dateofGrad_check;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}