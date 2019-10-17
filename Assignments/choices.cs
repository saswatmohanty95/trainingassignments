using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class choices
    {
        double sum;
        public choices()
        {

        }
        public void total1()
        {
            int b;
            Console.WriteLine("Total Bill: " + sum);
            Console.WriteLine("\nDo you want to select more?\n1-Yes\n2-No");
            b = int.Parse(Console.ReadLine());
            if (b == 1)
            {
                choice();
            }
            else
            {
                Console.WriteLine("Your final bill amount is: " + sum);
                Console.WriteLine("Have a Good Day!!");
            }

        }
        public void choice()
        {
            int i;
            Console.WriteLine("Select your Product:\n1-Redmi K20 Pro:Rs.29000\n2-Oneplus 7T:Rs.37000\n3-RealMe X2 Pro:Rs.28900\n4-Galaxy A70:Rs.26700\n5-Vivo Nex 3:Rs.41000\n");

            i = int.Parse(Console.ReadLine());
            switch (i)
            {
                case 1:
                    int price = 29000;
                    int qty;
                    double total;
                    Console.WriteLine("You have selected Redmi K20 Pro\n");
                    Console.WriteLine("Enter the quantity\n");
                    qty = int.Parse(Console.ReadLine());
                    total = qty * price;
                    sum = sum + total;
                    total1();
                    break;
                case 2:
                    price = 37000;
                    Console.WriteLine("You have selected One Plus 7T\n");
                    Console.WriteLine("Enter the quantity\n");
                    qty = int.Parse(Console.ReadLine());
                    total = qty * price;
                    sum = sum + total;
                    total1();
                    break;
                case 3:
                    price = 28900;
                    Console.WriteLine("You have selected RealMe X2 Pro\n");
                    Console.WriteLine("Enter the quantity\n");
                    qty = int.Parse(Console.ReadLine());
                    total = qty * price;
                    sum = sum + total;
                    total1();
                    break;
                case 4:
                    price = 26700;
                    Console.WriteLine("You have selected Galaxy A70\n");
                    Console.WriteLine("Enter the quantity\n");
                    qty = int.Parse(Console.ReadLine());
                    total = qty * price;
                    sum = sum + total;
                    total1();
                    break;
                case 5:
                    price = 41000;
                    Console.WriteLine("You have selected Vivo Nex 3\n");
                    Console.WriteLine("Enter the quantity\n");
                    qty = int.Parse(Console.ReadLine());
                    total = qty * price;
                    sum = sum + total;
                    total1();
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
        static void Main(string[] args)
        {
            choices ch = new choices();
            ch.choice();





        }
    }
}
