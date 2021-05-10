using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementRD
{
    public partial class frmAddNewCourse : Form
    {
        Student studentCourse = new Student();
        Course editCourses = new Course();
        Grades grades = new Grades();
        bool courseIDExists;
        bool studentIDExists;
        public frmAddNewCourse()
        {
            InitializeComponent();
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            if (txtCourseID.Text.Length >= 5 && txtCourseID.Text.Length <= 9 && txtCourseName.Text.Length >= 1)
            {
                courseIDExists = editCourses.CheckCourseID(txtCourseID.Text);

                if (courseIDExists == false)
                {
                    editCourses.AddNewCourse(txtCourseID.Text, txtCourseName.Text);
                    MessageBox.Show("Course successfully added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Course ID already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please make sure the course information is in the correct format. \n\nExample: CourseID - IT100",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateCourseInfo_Click(object sender, EventArgs e)
        {
            if (txtCourseID.Text.Length >= 5 && txtCourseID.Text.Length <= 9 && txtCourseName.Text.Length >= 1)
            {
                courseIDExists = editCourses.CheckCourseID(txtCourseID.Text);

                var confirmResult = MessageBox.Show("Are you sure you want to update this course?", "Confirm Clear", MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    if (courseIDExists == true)
                    {
                        
                            editCourses.UpdateCourseInfo(txtCourseID.Text, txtCourseName.Text);
                            MessageBox.Show("Course successfully updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                              
                    }
                    else
                    {
                        MessageBox.Show("Course ID doesn't exist in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please make sure the course information is in the correct format. \n\nExample: CourseID - IT100",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnSchedule_Click(object sender, EventArgs e)
        {
            if (txtCourseID.Text.Length >= 5 && txtCourseID.Text.Length <= 9 && txtStudentID.Text.Length >= 3 && txtStudentID.Text.Length <= 6
                        && txtTerm.Text.Length == 10)
            {
                if (txtGrade.Text.Length > 0)
                {
                    MessageBox.Show("Add a grade for the course with the Update Student Course button.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                courseIDExists = editCourses.CheckCourseID(txtCourseID.Text);
                studentIDExists = studentCourse.CheckStudentID(txtStudentID.Text);

                if (studentIDExists == true)
                {
                    if (courseIDExists == true)
                    {
                        grades.ScheduleNewCourse(txtCourseID.Text, txtStudentID.Text, txtTerm.Text);
                        MessageBox.Show("Course successfully scheduled.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Course ID doesn't exist in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Student ID doesn't exist in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please make sure the course and student information are in the correct format. \n\nExample: CourseID - IT100, StudentID - DL1, Term - 2021-SPR-E",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtCourseID.Text.Length >= 5 && txtCourseID.Text.Length <= 9 && txtStudentID.Text.Length >= 3 && txtStudentID.Text.Length <= 6
                 && txtTerm.Text.Length == 10 && txtGrade.Text.Length > 0 && txtGrade.Text.Length <= 2)
            {

                var confirmResult = MessageBox.Show("Are you sure you want to update this student's course?", "Confirm Clear", MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    courseIDExists = editCourses.CheckCourseID(txtCourseID.Text);
                    studentIDExists = studentCourse.CheckStudentID(txtStudentID.Text);

                    if (studentIDExists == true)
                    {
                        if (courseIDExists == true)
                        {
                            grades.UpdateCourseWithGrade(txtCourseID.Text, txtGrade.Text, txtStudentID.Text, txtTerm.Text);
                            MessageBox.Show("Course successfully updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Course ID doesn't exist in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Student ID doesn't exist in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please make sure the course and student information are in the correct format. \n\nExample: CourseID - IT100, StudentID - DL1, Term - 2021-SPR-E, (Optional)Grade - A or A-",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (txtCourseID.Text.Length >= 5 && txtCourseID.Text.Length <= 9 && txtStudentID.Text.Length >= 3 && txtStudentID.Text.Length <= 6
                    && txtTerm.Text.Length == 10)
            {
                var confirmResult = MessageBox.Show("Are you sure you want to update this student's course?", "Confirm Clear", MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    courseIDExists = editCourses.CheckCourseID(txtCourseID.Text);
                    studentIDExists = studentCourse.CheckStudentID(txtStudentID.Text);

                    if (studentIDExists == true)
                    {
                        if (courseIDExists == true)
                        {
                            grades.UpdateCourseWithoutGrade(txtCourseID.Text, txtStudentID.Text, txtTerm.Text);
                            MessageBox.Show("Course successfully updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Course ID doesn't exist in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Student ID doesn't exist in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please make sure the course and student information are in the correct format. \n\nExample: CourseID - IT100, StudentID - DL1, Term - 2021-SPR-E, (Optional)Grade - A or A-",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteStudentCourse_Click(object sender, EventArgs e)
        {
            if (txtCourseID.Text.Length >= 5 && txtCourseID.Text.Length <= 9 && txtStudentID.Text.Length >= 3 && txtStudentID.Text.Length <= 6)
            {
                var confirmResult = MessageBox.Show("Are you sure you want to delete this student's course?", "Confirm Clear", MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    courseIDExists = editCourses.CheckCourseID(txtCourseID.Text);
                    studentIDExists = studentCourse.CheckStudentID(txtStudentID.Text);

                    if (studentIDExists == true)
                    {
                        if (courseIDExists == true)
                        {
                            grades.DeleteStudentCourse(txtCourseID.Text, txtStudentID.Text);
                            MessageBox.Show("Student's course deleted.", "Delete success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Course ID doesn't exist in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Student ID doesn't exist in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please make sure the course and student information are in the correct format. \n\nExample: CourseID - IT100, StudentID - DL1",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnDeleteCourse_Click(object sender, EventArgs e)
        {

            if (txtCourseID.Text.Length >= 5 && txtCourseID.Text.Length <= 9)
            {

                var confirmResult = MessageBox.Show("Are you sure you want to delete this course?", "Confirm Clear", MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    courseIDExists = editCourses.CheckCourseID(txtCourseID.Text);

                    if (courseIDExists == true)
                    {
                        editCourses.DeleteCourse(txtCourseID.Text);
                        MessageBox.Show("Course deleted.", "Delete success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Course ID doesn't exist in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }                
            }
            else
            {
                MessageBox.Show("Please make sure the course ID is in the correct format. \n\nExample: CourseID - IT100", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCourseID.Text = "";
            txtCourseName.Text = "";
            txtStudentID.Text = "";
            txtTerm.Text = "";
            txtGrade.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to exit this form?", "Confirm Exit", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}

