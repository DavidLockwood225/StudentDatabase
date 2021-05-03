
namespace StudentManagementRD
{
    partial class frmBasicStudentInfo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBasicFirstName = new System.Windows.Forms.TextBox();
            this.txtBasicStudentID = new System.Windows.Forms.TextBox();
            this.btnFindStudent = new System.Windows.Forms.Button();
            this.grdCurrentClasses = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDegree = new System.Windows.Forms.Label();
            this.txtBasicLastName_ = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTerm = new System.Windows.Forms.Label();
            this.btnDetailedStudentInfo = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAddNewStudent = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lblDegree_ = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdCurrentClasses)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBasicFirstName
            // 
            this.txtBasicFirstName.Location = new System.Drawing.Point(118, 21);
            this.txtBasicFirstName.Name = "txtBasicFirstName";
            this.txtBasicFirstName.Size = new System.Drawing.Size(142, 23);
            this.txtBasicFirstName.TabIndex = 0;
            // 
            // txtBasicStudentID
            // 
            this.txtBasicStudentID.Location = new System.Drawing.Point(118, 79);
            this.txtBasicStudentID.Name = "txtBasicStudentID";
            this.txtBasicStudentID.Size = new System.Drawing.Size(34, 23);
            this.txtBasicStudentID.TabIndex = 2;
            // 
            // btnFindStudent
            // 
            this.btnFindStudent.Location = new System.Drawing.Point(15, 139);
            this.btnFindStudent.Name = "btnFindStudent";
            this.btnFindStudent.Size = new System.Drawing.Size(127, 23);
            this.btnFindStudent.TabIndex = 3;
            this.btnFindStudent.Text = "Find Student";
            this.btnFindStudent.UseVisualStyleBackColor = true;
            this.btnFindStudent.Click += new System.EventHandler(this.btnFindStudent_Click);
            // 
            // grdCurrentClasses
            // 
            this.grdCurrentClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCurrentClasses.Location = new System.Drawing.Point(295, 50);
            this.grdCurrentClasses.Name = "grdCurrentClasses";
            this.grdCurrentClasses.RowTemplate.Height = 25;
            this.grdCurrentClasses.Size = new System.Drawing.Size(440, 122);
            this.grdCurrentClasses.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Student ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(295, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Degree:";
            // 
            // lblDegree
            // 
            this.lblDegree.AutoSize = true;
            this.lblDegree.Location = new System.Drawing.Point(529, -69);
            this.lblDegree.Name = "lblDegree";
            this.lblDegree.Size = new System.Drawing.Size(29, 15);
            this.lblDegree.TabIndex = 9;
            this.lblDegree.Text = "asdf";
            // 
            // txtBasicLastName_
            // 
            this.txtBasicLastName_.Location = new System.Drawing.Point(118, 50);
            this.txtBasicLastName_.Name = "txtBasicLastName_";
            this.txtBasicLastName_.Size = new System.Drawing.Size(142, 23);
            this.txtBasicLastName_.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(640, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Term:";
            // 
            // lblTerm
            // 
            this.lblTerm.AutoSize = true;
            this.lblTerm.Location = new System.Drawing.Point(682, 24);
            this.lblTerm.Name = "lblTerm";
            this.lblTerm.Size = new System.Drawing.Size(0, 15);
            this.lblTerm.TabIndex = 12;
            // 
            // btnDetailedStudentInfo
            // 
            this.btnDetailedStudentInfo.Location = new System.Drawing.Point(148, 139);
            this.btnDetailedStudentInfo.Name = "btnDetailedStudentInfo";
            this.btnDetailedStudentInfo.Size = new System.Drawing.Size(127, 23);
            this.btnDetailedStudentInfo.TabIndex = 13;
            this.btnDetailedStudentInfo.Text = "Student Profile";
            this.btnDetailedStudentInfo.UseVisualStyleBackColor = true;
            this.btnDetailedStudentInfo.Click += new System.EventHandler(this.btnDetailedStudentInfo_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(150, 168);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Student Courses";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnAddNewStudent
            // 
            this.btnAddNewStudent.Location = new System.Drawing.Point(15, 168);
            this.btnAddNewStudent.Name = "btnAddNewStudent";
            this.btnAddNewStudent.Size = new System.Drawing.Size(127, 23);
            this.btnAddNewStudent.TabIndex = 15;
            this.btnAddNewStudent.Text = "Add New Student";
            this.btnAddNewStudent.UseVisualStyleBackColor = true;
            this.btnAddNewStudent.Click += new System.EventHandler(this.btnAddNewStudent_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(150, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Progress Report";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(15, 197);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "Student Body Report";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(654, 197);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 18;
            this.button4.Text = "Exit";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // lblDegree_
            // 
            this.lblDegree_.AutoSize = true;
            this.lblDegree_.Location = new System.Drawing.Point(348, 24);
            this.lblDegree_.Name = "lblDegree_";
            this.lblDegree_.Size = new System.Drawing.Size(0, 15);
            this.lblDegree_.TabIndex = 19;
            // 
            // frmBasicStudentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 234);
            this.Controls.Add(this.lblDegree_);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAddNewStudent);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnDetailedStudentInfo);
            this.Controls.Add(this.lblTerm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBasicLastName_);
            this.Controls.Add(this.lblDegree);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdCurrentClasses);
            this.Controls.Add(this.btnFindStudent);
            this.Controls.Add(this.txtBasicStudentID);
            this.Controls.Add(this.txtBasicFirstName);
            this.Name = "frmBasicStudentInfo";
            this.Text = "Basic Student Info";
            ((System.ComponentModel.ISupportInitialize)(this.grdCurrentClasses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBasicFirstName;
        private System.Windows.Forms.TextBox txtBasicStudentID;
        private System.Windows.Forms.Button btnFindStudent;
        private System.Windows.Forms.DataGridView grdCurrentClasses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDegree;
        private System.Windows.Forms.TextBox txtBasicLastName_;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTerm;
        private System.Windows.Forms.Button btnDetailedStudentInfo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAddNewStudent;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lblDegree_;
    }
}

