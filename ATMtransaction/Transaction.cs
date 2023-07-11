using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMtransaction
{
    public class Transaction
    {
        public void Money()
        {
            int cash = 5000, deposite, balance;
            while (true)
            {
                Console.WriteLine("Enter the option");
                Console.WriteLine("1-Money Deposition");
                Console.WriteLine("2-Money WithDraw");
                Console.WriteLine("3-Check balance");
                Console.WriteLine("4-Exit");
                Console.WriteLine("*****************");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter the amount that want to deposite");
                        deposite = Convert.ToInt32(Console.ReadLine());
                        cash = deposite + cash;
                        Console.WriteLine("The Remaining balance is " + cash);
                        Console.WriteLine("*****************");
                        break;
                    case 2:
                        Console.WriteLine("Enter the amount that want to withdraw");
                        int amount = Convert.ToInt32(Console.ReadLine());
                        if (amount % 100 != 0)
                        {
                            Console.WriteLine("Withdraw amount should be multiple of 100");
                        }
                        else if (cash < amount)
                        {
                            Console.WriteLine("The account has a insufficient amount");
                        }
                        else if (cash <= amount)
                        {
                            Console.WriteLine("The account should have a minimum balance");
                        }

                        else
                        {
                            cash = cash - amount;
                            Console.WriteLine("The Money Withdrawal successfully");
                            Console.WriteLine("The Remaining balance is " + cash);

                        }
                        Console.WriteLine("*****************");
                        break;
                    case 3:
                        Console.WriteLine("The total balance is " + cash);
                        Console.WriteLine("*****************");
                        break;
                    case 4:
                        Console.WriteLine("Thank You Visit Again");
                        Console.WriteLine("*****************");
                        break;
                }
            }
        }
    }
}
