using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayrollService
{
    public class EmployeeRepo
    {
        public static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;
                                         Initial Catalog=payroll_service1;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        
       
        public bool GetAllEmployee()
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
             //   SqlConnection connection = new SqlConnection(connectionString);
                EmployeeModel employeeModel = new EmployeeModel();
                using (connection)
                {
                    string query = @"Select * from employee_payroll1";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            //employeeModel.EmployeeID = dr.GetInt32(0);
                            employeeModel.EmployeeID = dr.GetInt32(0);
                            employeeModel.EmployeeName = dr.GetString(1);
                            employeeModel.PhoneNumber = dr.GetString(2);
                            employeeModel.Address = dr.GetString(3);
                            employeeModel.BasicPay = dr.GetDecimal(6);
                            employeeModel.StartDate = dr.GetDateTime(11);
                            employeeModel.Gender = Convert.ToChar(dr.GetString(5));
                            // employeeModel.PhoneNumber = dr.GetString(4);

                            employeeModel.Department = dr.GetString(4);
                            employeeModel.Deductions = dr.GetDecimal(7);
                            employeeModel.TaxablePay = dr.GetDecimal(8);
                            employeeModel.Tax = dr.GetDecimal(9);
                            employeeModel.NetPay = dr.GetDecimal(10);
                            //employeeModel.City = dr.GetString(12);
                            //employeeModel.Country = dr.GetString(13);
                            System.Console.WriteLine(employeeModel.EmployeeName+" "+employeeModel.BasicPay+ " "+employeeModel.StartDate +" "+ employeeModel.Gender+" "+ employeeModel.PhoneNumber+" "+employeeModel.Address+" "+ employeeModel.Department+" "+ employeeModel.Deductions+" "+ employeeModel.TaxablePay+" "+ employeeModel.Tax+" "+ employeeModel.NetPay);
                            System.Console.WriteLine("\n");
                        }
                    }
                    else
                    {
                        System.Console.WriteLine("No data found");
                        return false;
                    }
                    return true;
                }
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
                return false;
            }
        }
        public bool AddEmployee(EmployeeModel model)
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                using (connection)
                {
                    //var qury=values()
                    SqlCommand command = new SqlCommand("SpAddEmployeeDetails1", connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@EmployeeName", model.EmployeeName);
                    command.Parameters.AddWithValue("@PhoneNumber", model.PhoneNumber);
                    command.Parameters.AddWithValue("@Address", model.Address);
                    command.Parameters.AddWithValue("@Department", model.Department);
                    command.Parameters.AddWithValue("@Gender", model.Gender);
                    command.Parameters.AddWithValue("@BasicPay", model.BasicPay);
                    command.Parameters.AddWithValue("@Deductions", model.Deductions);
                    command.Parameters.AddWithValue("@TaxablePay", model.TaxablePay);
                    command.Parameters.AddWithValue("@Tax", model.Tax);
                    command.Parameters.AddWithValue("@NetPay", model.NetPay);
                    command.Parameters.AddWithValue("@StartDate", DateTime.Now);
                    //command.Parameters.AddWithValue("@City", model.City);
                    //command.Parameters.AddWithValue("@Country", model.Country);
                    connection.Open();
                    var result = command.ExecuteNonQuery();
                    connection.Close();
                    if (result != 0)
                    {

                        return true;
                    }
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Close();
            }
            return false;
        }


    }
}
