
namespace StudentManagementRD
{
    partial class frmStudentCourses
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
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grdAllCourses = new System.Windows.Forms.DataGridView();
            this.btnFindCourses = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.btnAddNewCourse = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnViewAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdAllCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID:";
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(84, 5);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(55, 23);
            this.txtStudentID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Last Name:";
            // 
            // grdAllCourses
            // 
            this.grdAllCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAllCourses.Location = new System.Drawing.Point(13, 103);
            this.grdAllCourses.Name = "grdAllCourses";
            this.grdAllCourses.RowTemplate.Height = 25;
            this.grdAllCourses.Size = new System.Drawing.Size(584, 272);
            this.grdAllCourses.TabIndex = 6;
            // 
            // btnFindCourses
            // 
            this.btnFindCourses.Location = new System.Drawing.Point(359, 10);
            this.btnFindCourses.Name = "btnFindCourses";
            this.btnFindCourses.Size = new System.Drawing.Size(116, 23);
            this.btnFindCourses.TabIndex = 7;
            this.btnFindCourses.Text = "Find Courses";
            this.btnFindCourses.UseVisualStyleBackColor = true;
            this.btnFindCourses.Click += new System.EventHandler(this.btnSearchForCourses_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(481, 39);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(116, 23);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(84, 43);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(0, 15);
            this.lblFirstName.TabIndex = 9;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(84, 71);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(0, 15);
            this.lblLastName.TabIndex = 10;
            // 
            // btnAddNewCourse
            // 
            this.btnAddNewCourse.Location = new System.Drawing.Point(359, 39);
            this.btnAddNewCourse.Name = "btnAddNewCourse";
            this.btnAddNewCourse.Size = new System.Drawing.Size(116, 23);
            this.btnAddNewCourse.TabIndex = 11;
            this.btnAddNewCourse.Text = "Add New Course";
            this.btnAddNewCourse.UseVisualStyleBackColor = true;
            this.btnAddNewCourse.Click += new System.EventHandler(this.btnAddNewCourse_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(482, 67);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(115, 23);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnViewAll
            // 
            this.btnViewAll.Location = new System.Drawing.Point(359, 67);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(116, 23);
            this.btnViewAll.TabIndex = 13;
            this.btnViewAll.Text = "View All Courses";
            this.btnViewAll.UseVisualStyleBackColor = true;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // frmStudentCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 393);
            this.Controls.Add(this.btnViewAll);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddNewCourse);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnFindCourses);
            this.Controls.Add(this.grdAllCourses);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.label1);
            this.Name = "frmStudentCourses";
            this.Text = "All Student\'s Courses";
            ((System.ComponentModel.ISupportInitialize)(this.grdAllCourses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView grdAllCourses;
        private System.Windows.Forms.Button btnFindCourses;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Button btnAddNewCourse;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnViewAll;
    }
}