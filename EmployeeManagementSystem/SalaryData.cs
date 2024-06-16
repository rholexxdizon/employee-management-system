using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;

namespace EmployeeManagementSystem
{

    class SalaryData
    {

        public string EmployeeId {  get; set; } //0
        public string FullName { get; set; } //1
        public string Position { get; set; } //2
        public int Salary {  get; set; } //3


        SqlConnection connect = new SqlConnection(@"Data Source=RHOLEX-PC\SQLEXPRESS;Initial Catalog=EmployeeManagementSystem;Integrated Security=True;Connect Timeout=30");

        public List<SalaryData> salaryListData()
    {
        List<SalaryData> listdata = new List<SalaryData>();

        if (connect.State != ConnectionState.Open)
        {
            try
            {
                connect.Open();

                string selectData = "SELECT * FROM employees WHERE status = 'Active' " +
                        "AND delete_date IS NULL";
                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        SalaryData employeedata = new SalaryData();
                        employeedata.EmployeeId = reader["employee_id"].ToString();
                        employeedata.FullName = reader["full_name"].ToString();
                        employeedata.Position = reader["position"].ToString();
                        employeedata.Salary = (int)reader["salary"];

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
