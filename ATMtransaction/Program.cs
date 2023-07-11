using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMtransaction
{
    public  class Program
    {
        static void Main(string[] args)
        {
            Transactions transactions = new Transactions();
            Console.WriteLine("Welcome To the AXIS ATM");
            Console.WriteLine("Enter the ATM 4 Digit Pin");
            string pin = Console.ReadLine();
            //string pin_one = "3456";
            string pattern = "^[1-9]{1}[0-9]{3,5}$";
            if (Regex.IsMatch(pin, pattern))
            //if(pin ==pin_one)
            {
                while (true)
                {
                    Console.WriteLine("Enter the option");
                    Console.WriteLine("1-Money Deposition");
                    Console.WriteLine("2-Money WithDraw");
                    Console.WriteLine("3-Check Balance");
                    Console.WriteLine("4-ATM Transactions");
                    Console.WriteLine("*****************");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            transactions.Desposit();
                            Console.WriteLine("*******************");
                            break;
                        case 2:
                            transactions.Withdrawal();
                            Console.WriteLine("********************");
                            break;
                        case 3:
                            transactions.CheckBalance();
                            Console.WriteLine("********************");
                            break;
                        case 4:
                            Transation transation = new Transation();
                            transation.Money();
                            break;
                        default:
                            Console.WriteLine("Invalid option");
                            break;

                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid ATM pin");
                Console.ReadLine();
            }
        }
    }
}
