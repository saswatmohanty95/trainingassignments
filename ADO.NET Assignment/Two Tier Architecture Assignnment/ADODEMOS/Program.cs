using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeDAL;

namespace ADODEMOS
{
    
    class Program
    {
        Employee employee;
        static void Main(string[] args)
        {
            Program program = new Program();
            int x;
            do
            {
                Console.WriteLine("Enter the choice \n1.View\n2.Insert\n3.Update\n4.Delete");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        program.ViewEmployeeDetail();
                        break;

                    case 2:
                        program.InsertEmployeeDetail();
                        break;

                    case 3:
                        program.UpdateEmployeeDetail();
                        break;

                    case 4:
                        program.DeleteEmployeeDetail();
                        break;

                    default:
                        Console.WriteLine("Enter a valid choice");
                        break;
                }
                Console.WriteLine("Enter 1 to continue or 0 to exit");
                x = int.Parse(Console.ReadLine());
                Console.WriteLine("========================================================");
            } while (x == 1);
            Console.ReadLine();
        }
        public void InsertEmployeeDetail()
        {
            Console.WriteLine("enter the name,gender,location & salary");
            employee = new Employee();
            employee.Name = Console.ReadLine();
            employee.Gender = Console.ReadLine();
            employee.Location = Console.ReadLine();
            employee.Salary = int.Parse(Console.ReadLine());
            employee.InsertNewEmployee(employee);

        }

        public void UpdateEmployeeDetail()
        {
            employee = new Employee();
            Console.WriteLine(" Enter the Id ");
            employee.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the name,gender,location & salary");
            employee.Name = Console.ReadLine();
            employee.Gender = Console.ReadLine();
            employee.Location = Console.ReadLine();
            employee.Salary = int.Parse(Console.ReadLine());
            employee.UpdateEmployee(employee);

        }

        public void DeleteEmployeeDetail()
        {
            employee = new Employee();
            Console.WriteLine(" Enter the Id to be deleted: ");
            employee.Id = int.Parse(Console.ReadLine());
            employee.DeleteEmployee(employee);

        }

        public void ViewEmployeeDetail()
        {
            employee = new Employee();
            employee.ViewEmployee();
        }
    }
}
