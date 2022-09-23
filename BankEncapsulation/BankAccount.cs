using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class BankAccount
    {
        private static double balance = 0;
        public static double Deposit(double deposit)
        {
            return balance += deposit;
        }
        public static double Withdraw(double withdraw)
        {
            
                return balance -= withdraw;

        }


        public static void GetBalance()
        {
            
            
            Console.WriteLine(balance);
        }



    }
}
