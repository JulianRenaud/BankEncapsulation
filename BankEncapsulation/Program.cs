using BankEncapsulation;
using System.Security.Cryptography.X509Certificates;

Console.WriteLine("Hello new customer, how much money would you like to deposit? ");
double depositt = Convert.ToDouble(Console.ReadLine());
BankAccount.Deposit(depositt);

Console.WriteLine("----------------------------------------");


Console.WriteLine("How much money do you need? ");
double withdraww = Convert.ToDouble(Console.ReadLine());

if (withdraww > depositt)
{
    Console.WriteLine($"");
}
else
{
    BankAccount.Withdraw(withdraww);
}






Console.WriteLine("----------------------------------------");





if (withdraww > depositt)
{
    Console.WriteLine("You Owe");
    Console.WriteLine($" {withdraww - depositt}");
    Console.WriteLine("");
}
else
{
    Console.Write("You have ");
    BankAccount.GetBalance();
    Console.WriteLine("Dollars");
}














