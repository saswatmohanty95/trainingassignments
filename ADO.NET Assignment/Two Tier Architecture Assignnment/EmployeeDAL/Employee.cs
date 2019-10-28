using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace EmployeeDAL
{
    public class Employee
    {
        private int id, salary;
        private string name, gender, location;
       
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        string connstr = "data source=IN5CG9214YPZ; database=AdoDemos; integrated security=true";

        public int Id { get => id; set => id = value; }
        public int Salary { get => salary; set => salary = value; }
        public string Name { get => name; set => name = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Location { get => location; set => location = value; }

        public int InsertNewEmployee(Employee employee)
        {
           
            con.ConnectionString = connstr;
            cmd.Connection = con;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_InsertNewEmployee";
            cmd.Parameters.AddWithValue("name ", employee.Name);
            cmd.Parameters.AddWithValue("gender ", employee.Gender);
            cmd.Parameters.AddWithValue("location ", employee.Location);
            cmd.Parameters.AddWithValue("salary ",employee.Salary);
            con.Open();
            int rowcount = cmd.ExecuteNonQuery();
            con.Close();
            return rowcount;
        }
      
        public int UpdateEmployee(Employee employee2)
        {
            con.ConnectionString = connstr;
            cmd.Connection = con;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_RetrieveEmployeeById";
            cmd.Parameters.AddWithValue("id", employee2.Id);
            con.Open();
            object rowcount = cmd.ExecuteScalar();
            int updateid = (int)rowcount;
            if (updateid > 0)
            {                 
                cmd.Parameters.AddWithValue("name", employee2.Name);
                cmd.Parameters.AddWithValue("gender", employee2.Gender);
                cmd.Parameters.AddWithValue("location", employee2.Location);
                cmd.Parameters.AddWithValue("salary", employee2.Salary);
                cmd.CommandText = "sp_UpdateEmployee";
                int updatedrowcount = cmd.ExecuteNonQuery();
                if (updatedrowcount > 0)
                    Console.WriteLine("Record updated successfully");
            }
            con.Close();
            return updateid;

        }


        public int DeleteEmployee(Employee employee3)
        {
            con.ConnectionString = connstr;
            cmd.Connection = con;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.AddWithValue("id", employee3.Id);
            cmd.CommandText = "select * from tblEmployee where id=@id";
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Console.WriteLine($"{rdr[0]} \t{rdr[1]} \t{rdr[2]} \t{rdr[3]} \t{rdr[4]}");
            }
            rdr.Close();
            Console.WriteLine("Press YES to continue........");
            string confirmation = Console.ReadLine();
            int rowcount = 0;
            if (confirmation.ToLower()=="yes")
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "sp_DeleteEmployeeById";

                rowcount = cmd.ExecuteNonQuery();
                if (rowcount > 0)
                {
                    Console.WriteLine("Record Deleted successfully");
                }
               
            }
            con.Close();

            return rowcount;
            
        }


        public  void ViewEmployee()
        {
            con.ConnectionString = connstr;
            cmd.Connection = con;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_RetrieveAllEmployee";
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            Console.WriteLine("Id \tName \tGender \tCity \tSalary \t");
            Console.WriteLine("--------------------------------------------------------------------------");
            while (rdr.Read())
            {
             
                Console.WriteLine($" {rdr[0]} \t{rdr[1]} \t{rdr[2]} \t{rdr[3]} \t {rdr[4]}");
            }
            con.Close();
        }
    }
}
