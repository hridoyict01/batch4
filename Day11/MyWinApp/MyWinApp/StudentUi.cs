using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyWinApp.BLL;
using MyWinApp.Models;

namespace MyWinApp
{
    public partial class StudentUi : Form
    {
        StudentManager _studentManager = new StudentManager();
        private Student student;
        private int ID = 0;
        public StudentUi()
        {
            InitializeComponent();
            student = new Student();
        }

        private void StudentUi_Load(object sender, EventArgs e)
        {
            districtComboBox.DataSource = _studentManager.LoadDistrict();
            displayDataGridView.DataSource = _studentManager.ShowStudents();
            districtComboBox.Text = "Select a DistricT";
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            student.RollNo = rollNoTextBox.Text;
            student.Name = nameTextBox.Text;
            student.Age = Convert.ToInt32(ageTextBox.Text);
            student.Address = addressTextBox.Text;
            student.DistrictID = Convert.ToInt32(districtComboBox.SelectedValue);
//
            if(ID==0)
            {
                int result = _studentManager.InsertStudent(student);
                if (result > 0)
                {
                    MessageBox.Show("New Student Saved");
                    nameTextBox.Clear();
                    rollNoTextBox.Clear();
                    ageTextBox.Clear();
                    addressTextBox.Clear();
                }
                else
                {
                    MessageBox.Show("Failed");
                }
            }
            else
            {
                int result = _studentManager.EditStudent(student, ID);
                if (result > 0)
                {
                    MessageBox.Show("Updated Successfully");
                    nameTextBox.Clear();
                    rollNoTextBox.Clear();
                    ageTextBox.Clear();
                    addressTextBox.Clear();
                    SaveButton.Text = "Save";
                }
                else
                {
                    MessageBox.Show("Failed to update");
                }
            }
           
            displayDataGridView.DataSource = _studentManager.ShowStudents();
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            displayDataGridView.DataSource = _studentManager.ShowStudents();
        }

        private void displayDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.displayDataGridView.Rows[e.RowIndex].Cells["Sl"].Value = (e.RowIndex + 1).ToString();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int result = _studentManager.DeleteStudent(ID);
            if (result > 0)
            {
                MessageBox.Show("Deleted one record");
            }
            else
            {
                MessageBox.Show("Failed to delete");
            }
            displayDataGridView.DataSource = _studentManager.ShowStudents();
        }

        private void displayDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt16(displayDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString());
            rollNoTextBox.Text = (displayDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString());
            nameTextBox.Text = (displayDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString());
            ageTextBox.Text = (displayDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString());
            addressTextBox.Text = (displayDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString());
            //districtComboBox.SelectedValue = Convert.ToInt16(displayDataGridView.Rows[e.RowIndex].Cells[6].Value.ToString());
            //districtComboBox.Text = (displayDataGridView.Rows[e.RowIndex].Cells[7].Value.ToString());
            SaveButton.Text = "Update";
        }

        private void displayDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt16(displayDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString());
            rollNoTextBox.Text = (displayDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString());
            nameTextBox.Text = (displayDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString());
            ageTextBox.Text = (displayDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString());
            addressTextBox.Text = (displayDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString());
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            
            SaveButton.Text = "Update";
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            displayDataGridView.DataSource = _studentManager.SearchStudent(name);
        }

        private void displayDataGridView_CellConten   tDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt16(displayDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString());
            rollNoTextBox.Text = (displayDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString());
            nameTextBox.Text = (displayDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString());
            ageTextBox.Text = (displayDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString());
            addressTextBox.Text = (displayDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString());
            SaveButton.Text = "Update";
        }
    }
}
