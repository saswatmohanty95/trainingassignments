using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProductSelection
{
    

    class CustomerInfo
    {
    public string customer_Name { get; set; }
    public string customer_Id { get; set; }
    public string product_Id { get; set; }
    public string supplier_Id { get; set; }
    public string noofprod { get; set; }
    
    }
   
    class Program
    {

        static double total = 0;
        static double discount;
        static void Main(string[] args)
        {
            int x;
            do
            {
                Console.WriteLine("Select one of the given options to continue: \n\n1.View the table of Products \n2.View the table of Suppliers \n3.Proceed to buying");
                Console.WriteLine("-------------------------------------------------------------");
                Console.Write("Enter option number: ");
                int option = int.Parse(Console.ReadLine());
                Console.WriteLine("\n");
                switch (option)
                {
                    case 1:
                        ProductsList();
                        break;

                    case 2:
                        SuppliersList();
                        break;

                    case 3:
                        CustomerDetails();
                        break;

                    default:
                        Console.WriteLine(" Please enter a valid option");
                        break;
                }
                Console.WriteLine("\n");
                Console.WriteLine("Enter 1 to continue or enter 0 to exit");
                x = int.Parse(Console.ReadLine());
                Console.WriteLine("------------------------------------------------------\n");
            } while (x == 1);
            Console.ReadLine();

        }

        static void ProductsList()
        {
            SqlConnection con = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            con.ConnectionString = "data source=IN5CG9214YPZ; database=ProductSelectionManager; integrated security = true";
            cmd.Connection = con;
            cmd.CommandText = "select * from ProductTable";
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            Console.WriteLine("Product ID \t Product Name");
            Console.WriteLine("--------------------------");
            while (rdr.Read())
            {
                Console.WriteLine($"{rdr[0]} \t\t {rdr[1]}");
            }
            con.Close();
        }


        static void SuppliersList()
        {
            CustomerInfo cust = new CustomerInfo();
            Console.Write("Please enter Product ID:");
            cust.product_Id = Console.ReadLine();
            SqlConnection con = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            con.ConnectionString = "data source=IN5CG9214YPZ; database=ProductSelectionManager; integrated security = true";
            cmd.Parameters.AddWithValue("@productId", cust.product_Id);
            cmd.CommandText = "select * from SupplierTable where product_id=@productId";
            cmd.Connection = con;
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            Console.WriteLine("Supplier Id \t Supplier Name \t Supplier Location \t Price");
            Console.WriteLine("------------------------------------------------------------------------");
            while (rdr.Read())
            {
                Console.WriteLine($"{rdr[0]} \t\t {rdr[1]} \t\t {rdr[3]} \t\t {rdr[4]}");
            }
            con.Close();
        }

        static void CustomerDetails()
        {

            CustomerInfo customer = new CustomerInfo();
            Console.Write("Please enter the Product Id:");
            customer.product_Id = Console.ReadLine();

            Console.Write("Please enter the Supplier Id:");
            customer.supplier_Id = Console.ReadLine();

            Console.Write("Please enter your Name: ");
            customer.customer_Name = Console.ReadLine();

            Console.Write("Please enter product quantity(nos): ");
            customer.noofprod = Console.ReadLine();

            SqlConnection con = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            con.ConnectionString = "data source=IN5CG9214YPZ; database=ProductSelectionManager; integrated security = true";
            cmd.Parameters.AddWithValue("@productId", customer.product_Id);
            cmd.Parameters.AddWithValue("@supplierId", customer.supplier_Id);
            cmd.Parameters.AddWithValue("@customername", customer.customer_Name);
            cmd.Parameters.AddWithValue("@noofprod", customer.noofprod);
            cmd.CommandText = "insert into CustomerTable(customer_name,product_id,supplier_id,no_ofproducts) values(@customername,@productId,@supplierId,@noofprod)";
            cmd.Connection = con;
            con.Open();

            int rowcount = cmd.ExecuteNonQuery();
            if (rowcount > 0)
            {
                Console.WriteLine("Added Successfully!!!");
            }
            cmd.CommandText = "select product_price from SupplierTable where supplier_id=@supplierId";
            object price = cmd.ExecuteScalar();
            double price1 = Convert.ToDouble(price);
            cmd.CommandText = "select no_ofproducts from CustomerTable where customer_name=@customername";
            object qty = (cmd.ExecuteScalar());
            double qty1 = Convert.ToDouble(qty);
            
                total = total + (price1 * qty1); 
            
      
            GenerateBill();
            con.Close();
        }



            static void GenerateBill() 
        {
                Console.WriteLine("Do you have a coupon code?");
                Console.Write("Enter Coupon Code: ");
                string coupon = Console.ReadLine();
               
                if (coupon == "newcust")
                {
                    discount = 7 / 100 * total;
                }
                else
                {
                    discount = 0;
                }
                Console.WriteLine("-------------------------------------\n");
                double subtotal = total - discount;
                Console.WriteLine($"Total before Discount: \t{total}");
                Console.WriteLine($"Discount offered: \t{discount}");
                Console.WriteLine($"Grand Total: \t{subtotal}");
            }
     }
 }

       

      
            //Customer customer2 = new Customer();
            //Console.WriteLine("Please Enter the selected Supplier Id");
            //Console.Write("SUPPLIER ID: ");
            //customer2.supplierId = Console.ReadLine();

            //SqlConnection con = new SqlConnection();
            //con.ConnectionString = "data source=IN5CG9214Y3R; database=Product_Management; integrated security = true";
            //SqlCommand cmd = new SqlCommand();
            //cmd.Parameters.AddWithValue("@supplierId", customer2.supplierId);
            //cmd.CommandText = "select price from tblSupplier where supplier_id=@supplierId";
            //cmd.Connection = con;
            //con.Open();
            //object price = cmd.ExecuteScalar();
            //total= total+(int)price;
            //Console.WriteLine("PRODUCT ID \t Price");
            //Console.WriteLine("--------------------------");

            //    Console.WriteLine(total);

            //con.Close();
        
 

