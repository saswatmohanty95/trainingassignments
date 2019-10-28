using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCRUD
{
    class Employee
    {
        private int id;
        private string name, designation;
        private int salary;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Designation { get => designation; set => designation = value; }
        public int Salary { get => salary; set => salary = value; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> EmployeeList = new List<Employee>();
            EmployeeList.Add(new Employee { Id = 1, Name = "Parthiv", Designation = "Systems Engineer", Salary = 23000 });
            EmployeeList.Add(new Employee { Id = 2, Name = "Sharman", Designation = "Front End Developer", Salary = 34000 });
            EmployeeList.Add(new Employee { Id = 3, Name = "Aarushi", Designation = "Python Freelancer", Salary = 25000 });
            EmployeeList.Add(new Employee { Id = 4, Name = "Jasprit", Designation = "UI/UX developer", Salary = 29000 });
            EmployeeList.Add(new Employee { Id = 5, Name = "Abhinav", Designation = "Azure Architect", Salary = 40000 });


            int selection, a;
            do
            {
                Console.WriteLine("What action would you like to perform? Please Select:");
                Console.WriteLine("1.View List Of Employees\n2.Add an Employee\n3.Delete an Employee\n4.Update an Employee Record");
                selection = int.Parse(Console.ReadLine());
                switch (selection)
                {
                    case 1:
                        Console.WriteLine("Emp ID \t\t Name \t\t Designation \t\t Salary");
                        Console.WriteLine("---------------------------------------------------------------------------------");
                        foreach (Employee empl in EmployeeList)
                        {
                            Console.WriteLine($"{empl.Id} \t\t {empl.Name}\t\t {empl.Designation} \t\t {empl.Salary}");
                            Console.WriteLine("---------------------------------------------------------------------------------");
                        }
                        break;

                    case 2:
                        Console.WriteLine("Fill in the following details to add a record:");
                        Console.Write("Enter Id: ");
                        int id = int.Parse(Console.ReadLine());
                        Console.Write("Enter Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter Designation: ");
                        string designation = Console.ReadLine();
                        Console.Write("Enter Salary:");
                        int salary = int.Parse(Console.ReadLine());
                        EmployeeList.Add(new Employee { Id = id, Name = name, Designation = designation, Salary = salary });
                        Console.WriteLine("\nEmployee data has been added successfully!!!");
                        break;

                    case 3:
                        try
                        {
                            Console.WriteLine("Select the Id of the Employee to be deleted");
                            int iD = int.Parse(Console.ReadLine());
                            foreach (Employee item in EmployeeList)
                            {
                                if (iD == item.Id)
                                {
                                    EmployeeList.Remove(item);

                                }
                            }
                        }

                        catch (Exception)
                        {
                       
                        }
                        
                        Console.WriteLine("The Employee data has been deleted successfully!!!");
                        break;

                    case 4:
                        UpdateEmployeeList(EmployeeList);
                        break;

                    default:
                        Console.WriteLine("Please enter a valid choice!!!");
                        break;
                }
                Console.WriteLine("Press 1 to Continue or Press 0 to Exit ");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("_______________________________________________________________");
            } while (a == 1);
        }

        private static void UpdateEmployeeList(List<Employee> Emplist)        {
            try
            {
                Console.WriteLine("Enter details for record Updation.Select Id:");
                int Id = int.Parse(Console.ReadLine());
                int indexpostion = Emplist.FindIndex(x => x.Id == Id);
                foreach (Employee item in Emplist)
                {
                    if (Id == item.Id)
                    {

                        Emplist.Remove(item);
                        Console.WriteLine("Enter the new details");
                        Console.Write("Enter new Id: ");
                        int uid = int.Parse(Console.ReadLine());
                        Console.Write("Enter new Name: ");
                        string uname = Console.ReadLine();
                        Console.Write("Enter new Designation: ");
                        string udesignation = Console.ReadLine();
                        Console.Write("Enter new Salary: ");
                        int usalary = int.Parse(Console.ReadLine());

                        Emplist.Insert(indexpostion, new Employee { Id = uid, Name = uname, Designation = udesignation, Salary = usalary });
                        Console.WriteLine("The Employee data has been updated successfully!!!");

                    }
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
