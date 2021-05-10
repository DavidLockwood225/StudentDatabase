
namespace StudentManagementRD
{
    partial class frmAddNewCourse
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCourseID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTerm = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdateCourseInfo = new System.Windows.Forms.Button();
            this.btnDeleteCourse = new System.Windows.Forms.Button();
            this.btnDeleteStudentCourse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course ID:";
            // 
            // txtCourseID
            // 
            this.txtCourseID.Location = new System.Drawing.Point(109, 5);
            this.txtCourseID.Name = "txtCourseID";
            this.txtCourseID.Size = new System.Drawing.Size(65, 23);
            this.txtCourseID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Course Name:";
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(109, 35);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(136, 23);
            this.txtCourseName.TabIndex = 3;
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Location = new System.Drawing.Point(13, 102);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(161, 23);
            this.btnAddCourse.TabIndex = 4;
            this.btnAddCourse.Text = "Add Course Information";
            this.btnAddCourse.UseVisualStyleBackColor = true;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "StudentID:";
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(382, 5);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(65, 23);
            this.txtStudentID.TabIndex = 6;
            // 
            // btnSchedule
            // 
            this.btnSchedule.Location = new System.Drawing.Point(313, 102);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(169, 23);
            this.btnSchedule.TabIndex = 7;
            this.btnSchedule.Text = "Schedule New Course";
            this.btnSchedule.UseVisualStyleBackColor = true;
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(313, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Term:";
            // 
            // txtTerm
            // 
            this.txtTerm.Location = new System.Drawing.Point(382, 34);
            this.txtTerm.MaxLength = 10;
            this.txtTerm.Name = "txtTerm";
            this.txtTerm.Size = new System.Drawing.Size(100, 23);
            this.txtTerm.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(313, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Grade:";
            // 
            // txtGrade
            // 
            this.txtGrade.Location = new System.Drawing.Point(382, 64);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(40, 23);
            this.txtGrade.TabIndex = 11;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(313, 131);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(169, 23);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update Student\'s Course";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(251, 210);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "Exit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(170, 210);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdateCourseInfo
            // 
            this.btnUpdateCourseInfo.Location = new System.Drawing.Point(13, 131);
            this.btnUpdateCourseInfo.Name = "btnUpdateCourseInfo";
            this.btnUpdateCourseInfo.Size = new System.Drawing.Size(161, 23);
            this.btnUpdateCourseInfo.TabIndex = 15;
            this.btnUpdateCourseInfo.Text = "Update Course Information";
            this.btnUpdateCourseInfo.UseVisualStyleBackColor = true;
            this.btnUpdateCourseInfo.Click += new System.EventHandler(this.btnUpdateCourseInfo_Click);
            // 
            // btnDeleteCourse
            // 
            this.btnDeleteCourse.Location = new System.Drawing.Point(13, 161);
            this.btnDeleteCourse.Name = "btnDeleteCourse";
            this.btnDeleteCourse.Size = new System.Drawing.Size(161, 23);
            this.btnDeleteCourse.TabIndex = 16;
            this.btnDeleteCourse.Text = "Delete Course Information";
            this.btnDeleteCourse.UseVisualStyleBackColor = true;
            this.btnDeleteCourse.Click += new System.EventHandler(this.btnDeleteCourse_Click);
            // 
            // btnDeleteStudentCourse
            // 
            this.btnDeleteStudentCourse.Location = new System.Drawing.Point(313, 161);
            this.btnDeleteStudentCourse.Name = "btnDeleteStudentCourse";
            this.btnDeleteStudentCourse.Size = new System.Drawing.Size(169, 23);
            this.btnDeleteStudentCourse.TabIndex = 17;
            this.btnDeleteStudentCourse.Text = "Delete Student\'s Course";
            this.btnDeleteStudentCourse.UseVisualStyleBackColor = true;
            this.btnDeleteStudentCourse.Click += new System.EventHandler(this.btnDeleteStudentCourse_Click);
            // 
            // frmAddNewCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 254);
            this.Controls.Add(this.btnDeleteStudentCourse);
            this.Controls.Add(this.btnDeleteCourse);
            this.Controls.Add(this.btnUpdateCourseInfo);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTerm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSchedule);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAddCourse);
            this.Controls.Add(this.txtCourseName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCourseID);
            this.Controls.Add(this.label1);
            this.Name = "frmAddNewCourse";
            this.Text = "New Course";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCourseID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.Button btnAddCours;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTerm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdateCourseInfo;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.Button btnDeleteCourse;
        private System.Windows.Forms.Button btnDeleteStudentCourse;
    }
}