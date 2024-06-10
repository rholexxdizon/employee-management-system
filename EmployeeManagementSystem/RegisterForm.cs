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

namespace EmployeeManagementSystem
{
    public partial class RegisterForm : Form
    {
        SqlConnection connect 
            = new SqlConnection(@"Data Source=RHOLEX-PC\SQLEXPRESS;Initial Catalog=EmployeeManagementSystem;Integrated Security=True;Connect Timeout=30");
        public RegisterForm()
        {
            InitializeComponent();
        }

        private Point _mouseloc;
        private void registerSignInButton_Click(object sender, EventArgs e)
        {
            LoginForm Check = new LoginForm();
            Check.Show();
            Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void registerSignUpButton_Click(object sender, EventArgs e)
        {
            if (registerUsername.Text == "" || registerPassword.Text == "")
            {
                MessageBox.Show("Please fill all the blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();
                        //Check if the user is existing already
                        string selectUsername = "SELECT COUNT(id) FROM Employees WHERE username = @user";

                        using (SqlCommand checkUser = new SqlCommand(selectUsername, connect))
                        {

                            checkUser.Parameters.AddWithValue("@user", registerUsername.Text.Trim());
                            int count = (int)checkUser.ExecuteScalar();

                            if (count >= 1)
                            {
                                MessageBox.Show(registerUsername.Text.Trim() + " is already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                DateTime today = DateTime.Today;

                                string insertData = "INSERT INTO Employees " + "(username, password, date_register) " + "VALUES(@username, @password, @dateReg)";

                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@username", registerUsername.Text.Trim());
                                    cmd.Parameters.AddWithValue("@password", registerPassword.Text.Trim());
                                    cmd.Parameters.AddWithValue("@dateReg", today);

                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Registered successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    LoginForm loginform = new LoginForm();
                                    loginform.Show();
                                    this.Hide();
                                }
                            }
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
                
            }

        }

        private void registerShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            registerPassword.PasswordChar = registerShowPassword.Checked ? '\0' : '*';
        }

        private void RegisterForm_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseloc = e.Location;
        }

        private void RegisterForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.Location.X - _mouseloc.X;
                int dy = e.Location.Y - _mouseloc.Y;
                this.Location = new Point(this.Location.X + dx, this.Location.Y + dy);
            }
        }
    }
}
