using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Runtime.Remoting.Contexts;

namespace EmployeeManagementSystem
{
    public partial class Salary : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=RHOLEX-PC\SQLEXPRESS;Initial Catalog=EmployeeManagementSystem;Integrated Security=True;Connect Timeout=30");
        public Salary()
        {
            InitializeComponent();

            salaryListData();
            disableFields();     
        }

        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }

            salaryListData();
        }

        public void ClearGridSelection()
        {
            dataGridView1.ClearSelection();
        }

        public void disableFields()
        {
            salary_employeeId.Enabled = false;
            salary_fullName.Enabled = false;
            salary_Position.Enabled = false;
        }
        public void salaryListData()
        {
            SalaryData salaryData = new SalaryData();
            List <SalaryData> listdata = salaryData.salaryListData();

            dataGridView1.DataSource = listdata;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            salary_employeeId.Text = "";
            salary_fullName.Text = "";
            salary_Position.SelectedIndex = -1;
            salary_salary.Text = "";

        }

        private void clearFields()
        {
            salary_employeeId.Text = "";
            salary_fullName.Text = "";
            salary_Position.SelectedIndex = -1;
            salary_salary.Text = "";
        }
        private void salary_updateBtn_Click(object sender, EventArgs e)
        {

            
            if (salary_employeeId.Text == ""
                || salary_fullName.Text == ""
                || salary_Position.Text == ""
                || salary_Position.Text == "")
            {
                MessageBox.Show("Please fill all the blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to UPDATE? " + "Employee ID: " + salary_employeeId.Text.Trim() + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (check == DialogResult.Yes)
                {
                    if(connect.State == ConnectionState.Closed)
                    {

                    
                    try
                    {
                        connect.Open();
                        DateTime today = DateTime.Today;

                        string updateData = "UPDATE employees SET salary = @salary" +
                            ", update_date = @updateDate WHERE employee_id = @employeeID";

                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@salary", salary_salary.Text.Trim());
                            cmd.Parameters.AddWithValue("@updateDate", today);
                            cmd.Parameters.AddWithValue("@employeeId", salary_employeeId.Text.Trim());


                            cmd.ExecuteNonQuery();

                            

                            MessageBox.Show("Updated successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            salaryListData();
                            clearFields();

                            



                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Cancelled.", "Infomartion Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                salary_employeeId.Text = row.Cells[0].Value.ToString();
                salary_fullName.Text = row.Cells[1].Value.ToString();
                salary_Position.Text = row.Cells[2].Value.ToString();
                salary_salary.Text = row.Cells[3].Value.ToString();

            }
        }
    }
}
