using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;



namespace EmployeeManagementSystem
{
    public partial class AddEmployee : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=RHOLEX-PC\SQLEXPRESS;Initial Catalog=EmployeeManagementSystem;Integrated Security=True;Connect Timeout=30");

        public AddEmployee()
        {
            InitializeComponent();

            //to display the data from database to the grid view

            displayEmployeeData();
        }

        public void displayEmployeeData()
        {
            EmployeeData employeedata = new EmployeeData();
            List<EmployeeData> listdata = employeedata.employeeListData();

            dataGridView1.DataSource = listdata;
        }
        private void addEmployeeAddBtn_Click(object sender, EventArgs e)
        {
            if (addEmployeeId.Text == ""
                || addEmployeeFullName.Text == ""
                || addEmployeeGender.Text == ""
                || addEmployeePhoneNumber.Text == ""
                || addEmployeePosition.Text == ""
                || addEmployeeStatus.Text == ""
                || addEmployeePicture == null)
            {
                MessageBox.Show("Please fill all the blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);   
            }
            else
            {
                if(connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();
                        string checkEmID = "SELECT COUNT(*) FROM employees WHERE employee_id = @emID";

                        using(SqlCommand checkEm = new SqlCommand (checkEmID, connect))
                        {
                            checkEm.Parameters.AddWithValue("@emID", addEmployeeId.Text.Trim());
                            int count = (int)checkEm.ExecuteScalar();

                            if(count >= 1)
                            {
                                MessageBox.Show(addEmployeeId.Text.Trim() + " is already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                            else
                            {
                                DateTime today = DateTime.Today;
                                string insertData = "INSERT INTO employees " + 
                                    "(employee_id, full_name, gender, contact_number, position, image, salary, insert_date, status)" +
                                    "VALUES(@employeeID, @fullname, @gender, @contactNum, @position, @image, @salary, @insertDate, @status)";

                                string path = Path.Combine(@"E:\Programming Applications\C# Desktop Application Projects\Employee Management System 2024\EmployeeManagementSystem\EmployeeManagementSystem\Directory\"
                                    + addEmployeeId.Text.Trim() + ".jpg");

                                string directoryPath = Path.GetDirectoryName(path);

                                if(!Directory.Exists(directoryPath))
                                {
                                    Directory.CreateDirectory(directoryPath);
                                }

                                File.Copy(addEmployeePicture.ImageLocation, path, true);

                                using(SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@employeeID", addEmployeeId.Text.Trim());
                                    cmd.Parameters.AddWithValue("@fullname", addEmployeeFullName.Text.Trim());
                                    cmd.Parameters.AddWithValue("@gender", addEmployeeGender.Text.Trim());
                                    cmd.Parameters.AddWithValue("@contactNum", addEmployeePhoneNumber.Text.Trim());
                                    cmd.Parameters.AddWithValue("@position", addEmployeePosition.Text.Trim());
                                    cmd.Parameters.AddWithValue("@image", path);
                                    cmd.Parameters.AddWithValue("@salary", 0);
                                    cmd.Parameters.AddWithValue("@insertDate", today);
                                    cmd.Parameters.AddWithValue("@status", addEmployeeStatus.Text.Trim());

                                    cmd.ExecuteNonQuery();
                                    displayEmployeeData();

                                    MessageBox.Show("Added successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error, " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        private void addEmployeeImportBtn_Click(object sender, EventArgs e)
        {

            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files (*.jpg; *.png)|*.jpg;.png";
                string imagePath = "";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = dialog.FileName;
                    addEmployeePicture.ImageLocation = imagePath;
                }
            }

            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void addEmployeeDeleteBtn_Click(object sender, EventArgs e)
        {
            DeleteSelectedRecord();
        }

        private void DeleteSelectedRecord()
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                int recordIdToDelete = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);

                try
                {
                    connect.Open();
                    string deleteQuery = "DELETE FROM employees WHERE id = @employeeID";
                    SqlCommand cmd = new SqlCommand(deleteQuery, connect);
                    cmd.Parameters.AddWithValue("@employeeID", recordIdToDelete);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    displayEmployeeData();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Record deleted successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Record not found or already deleted");
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting record: " + ex.Message);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        private void addEmployeeClearBtn_Click(object sender, EventArgs e)
        {
            addEmployeeId.Text = "";
            addEmployeeFullName.Text = "";
            addEmployeeGender.SelectedIndex = -1;
            addEmployeePhoneNumber.Text = "";
            addEmployeePosition.SelectedIndex = -1;
            addEmployeeStatus.SelectedIndex = -1;
            addEmployeePicture.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                addEmployeeId.Text = row.Cells[1].Value.ToString();
                addEmployeeFullName.Text = row.Cells[2].Value.ToString();
                addEmployeeGender.Text = row.Cells[3].Value.ToString();
                addEmployeePhoneNumber.Text = row.Cells[4].Value.ToString();
                addEmployeePosition.Text = row.Cells[5].Value.ToString();

                string imagePath = row.Cells[6].Value.ToString();
                if(imagePath != null)
                {
                    addEmployeePicture.Image = Image.FromFile(imagePath); 
                }
                else
                {
                    addEmployeePicture.Image = null;
                }

                addEmployeeStatus.Text = row.Cells[8].Value.ToString();

            }
        }
    }
}
