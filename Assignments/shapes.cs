using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class shapes
    {
        public shapes()
        {

        }
        public shapes(int side)
        {
            int area;
            area = side * side;
            Console.WriteLine("Area of the given Square is:" + "" + area);
        }
        public shapes(int l, int b)
        {
            int area = l * b;
            Console.WriteLine("Area of the given Rectangle is: " + "" + area);
        }
        public void square()
        {


        }
        public void rect()
        {


        }
        public void cir()
        {
            int r;
            double area;
            Console.WriteLine("Enter the radius of circle");
            r = int.Parse(Console.ReadLine());
            area = (3.14) * r * r;
            Console.WriteLine("Area of the given Circle is: " + "" + area);
        }
        public void tri()
        {
            int b, h;
            double area;
            Console.WriteLine("Enter height of triangle");
            h = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter base of traingle");
            b = int.Parse(Console.ReadLine());
            area = 0.5 * b * h;
            Console.WriteLine("Area of the given Triangle is: " + "" + area);
        }

        static void Main(string[] args)
        {
            shapes s = new shapes();
            int shape;
            Console.WriteLine("Please Choose required Shape:\n 1-Square\n 2-Rectangle\n 3-Circle\n 4-Triangle");
            shape = int.Parse(Console.ReadLine());

            switch (shape)
            {
                case 1:
                    Console.WriteLine("You have selected Square\n");
                    Console.WriteLine("Enter the side of the square");
                    int side;
                    side = int.Parse(Console.ReadLine());
                    shapes sqa = new shapes(side);
                    break;
                case 2:
                    Console.WriteLine("You have selected Rectangle\n");
                    int l, b;
                    Console.WriteLine("Enter the length of Rectangle");
                    l = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the breadth of Rectangle");
                    b = int.Parse(Console.ReadLine());

                    shapes rec = new shapes(l, b);


                    break;
                case 3:
                    Console.WriteLine("You have selected Circle\n");
                    s.cir();
                    break;
                case 4:
                    Console.WriteLine("You have selected Triangle\n");
                    s.tri();
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}


