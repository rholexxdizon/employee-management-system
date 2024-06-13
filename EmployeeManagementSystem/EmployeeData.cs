using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace EmployeeManagementSystem
{
    class EmployeeData
    {
        public int ID { set; get; } //0
        public string EmployeeId { set; get; } //1
        public string Name { set; get; } //2
        public string Gender { set; get; } //3
        public string Contact { set; get; } //4
        public string Position { set; get; } //5
        public string Image { set; get; } //6
        public int Salary { set; get; } //7
        public string Status { set; get; } //8

        SqlConnection connect = new SqlConnection(@"Data Source=RHOLEX-PC\SQLEXPRESS;Initial Catalog=EmployeeManagementSystem;Integrated Security=True;Connect Timeout=30");


        public List<EmployeeData> employeeListData()
        {
            List<EmployeeData> listdata = new List<EmployeeData>();

            if(connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM employees WHERE delete_date IS NULL";
                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            EmployeeData employeedata = new EmployeeData();
                            employeedata.ID = (int)reader["id"];
                            employeedata.EmployeeId = reader["employee_id"].ToString();
                            employeedata.Name = reader["full_name"].ToString();
                            employeedata.Gender = reader["gender"].ToString();
                            employeedata.Contact = reader["contact_number"].ToString();
                            employeedata.Position = reader["position"].ToString();
                            employeedata.Image = reader["image"].ToString();
                            employeedata.Salary = (int)reader["salary"];
                            employeedata.Status = reader["status"].ToString();

                            listdata.Add(employeedata);
                        }
                    }
                    

                }

                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex);
                }
                finally
                {
                    connect.Close();
                }
            }
            return listdata;
        }
    }
}
 