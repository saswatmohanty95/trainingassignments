using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banksystem
{
    //class Record
    //{
    //    public void records()
    //    {



    //    }
    //}
    class banks
    {
        public int acno;
        public string acname;
        public int atm_pin;
        public double opening_balance;
        public double deposit_amount;
        public double withdrawl_amount;
        public double balance;
        public int choice;
        public void select(banks[] bk, int i)
        {
            Console.WriteLine("Please select required service>>>\n 1-Check balance\n 2-Deposit Services\n 3-Withdrawal Services\n");
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("You have selected to check balance");
                    Console.WriteLine("Your current account balance is: " + bk[i].balance + "\n");
                    Console.WriteLine("Thank you for using our ATM services. Have anice day!");
                    break;
                case 2:
                    Console.WriteLine("You have selected to deposit an amount\n");
                    Console.WriteLine("Please enter amount to be deposited\n");
                    bk[i].deposit_amount = int.Parse(Console.ReadLine());
                    Console.WriteLine("Your deposit of Rs." + bk[i].deposit_amount + "is successful\n");
                    bk[i].balance = (bk[i].balance + bk[i].deposit_amount) - bk[i].withdrawl_amount;
                    Console.WriteLine("Your new account balance is: " + bk[i].balance + "\n");
                    Console.WriteLine("Thank you for using our ATM services. Have a nice Day!");
                    break;
                case 3:
                    Console.WriteLine("You have selected money withdrawal option\n");
                    Console.WriteLine("Please enter withdrawal amount");
                    bk[i].withdrawl_amount = int.Parse(Console.ReadLine());
                    if (bk[i].withdrawl_amount > bk[i].balance)
                    {
                        Console.WriteLine("Account balance insufficient. Sorry!\n");
                        Console.WriteLine("Your current account balance is : " + bk[i].balance);
                    }
                    else
                    {
                        bk[i].balance = bk[i].balance - bk[i].withdrawl_amount;
                        Console.WriteLine("Your new account balance is: " + bk[i].balance + "\n");
                        Console.WriteLine("Thank you for using the ATM service");

                    }
                    break;

            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int y = 0;
            banks[] bank = new banks[10];
            banks bnk = new banks();
            bank[0] = new banks { acno = 45101011, acname = "Rahul Sharma", atm_pin = 1001, opening_balance = 500, deposit_amount = 0, withdrawl_amount = 0, balance = 500 };
            bank[1] = new banks { acno = 45101012, acname = "Shwetank Adhikary", atm_pin = 1002, opening_balance = 500, deposit_amount = 0, withdrawl_amount = 0, balance = 500 };
            bank[2] = new banks { acno = 45101013, acname = "Tulsi Ram Behera", atm_pin = 1003, opening_balance = 500, deposit_amount = 0, withdrawl_amount = 0, balance = 500 };
            bank[3] = new banks { acno = 45101014, acname = "Cristopher Bersa", atm_pin = 1004, opening_balance = 500, deposit_amount = 0, withdrawl_amount = 0, balance = 500 };
            bank[4] = new banks { acno = 45101015, acname = "Daisy Shah", atm_pin = 1005, opening_balance = 500, deposit_amount = 0, withdrawl_amount = 0, balance = 500 };
            bank[5] = new banks { acno = 45101016, acname = "Amrita Dhawan", atm_pin = 1006, opening_balance = 500, deposit_amount = 0, withdrawl_amount = 0, balance = 500 };
            bank[6] = new banks { acno = 45101017, acname = "Tushaar Kapoor", atm_pin = 1007, opening_balance = 500, deposit_amount = 0, withdrawl_amount = 0, balance = 500 };
            bank[7] = new banks { acno = 45101018, acname = "Sutlej Parmar", atm_pin = 1008, opening_balance = 500, deposit_amount = 0, withdrawl_amount = 0, balance = 500 };
            bank[8] = new banks { acno = 45101019, acname = "Javed Sheheri", atm_pin = 1009, opening_balance = 500, deposit_amount = 0, withdrawl_amount = 0, balance = 500 };
            bank[9] = new banks { acno = 45101010, acname = "Avinash Mallick", atm_pin = 1010, opening_balance = 500, deposit_amount = 0, withdrawl_amount = 0, balance = 500 };

            
            do
            {
                Console.WriteLine("Enter ATM pin");
                int a = int.Parse(Console.ReadLine());
                int i = (a % 100) - 1;
                if (a > 1000 && a < 1011)
                {


                    Console.WriteLine("\nAccount number: \n" + bank[i].acno + "\nAccount Holder Name is: \n" + bank[i].acname + "\nAccount Balance: \n" + bank[i].balance);
                    bnk.select(bank, i);
                    break;

                }
                else
                {

                    Console.WriteLine("Wrong ATM pin. \n Please remove ATM card and try again\n");
                    y++;

                }
            } while (y < 3);
            
        }

    }
}
