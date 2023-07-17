using System;
using System.Collections.Generic;
using System.Text;

namespace BankQuestionv3
{
    public class CheckingAccount : BankAccount, ITransaction
    {
        public double InterestRate { get; set; }
        public CheckingAccount(string name, int account_number, double balance, double interestrate) : base(name, account_number, balance)
        { InterestRate = interestrate; }
        public override void Deposit(double amountd)
        {

            Balance += amountd * (1 + InterestRate / 100);
            Console.WriteLine($"The amount now deposited is {amountd}");
            Console.WriteLine($"The total amount after deposit and interest rate is: {Balance}");
        }
        public override void Withdraw(double amountw)
        {

            if (amountw < Balance)
            {
                Console.WriteLine($"You have less amount to withdraw.");
            }
        }
        public override void CalculateInterest(double amountr)
        {
            double a = amountr * (InterestRate / 100);
            Console.WriteLine($"The total amount of interest we got is {a}");
        }
        public override void ExecuteTransaction(double amountt)
        {
            Console.WriteLine($"The transaction amount of {amountt } is executed");
        }
        public override void PrintTransaction()
        {
            Console.WriteLine($"Your Transaction has been done.");
        }
        public override void DisplayAccountInfo()
        {
            Console.WriteLine($"The Account Holder Name:  {Name}");
            Console.WriteLine($"The Account Number:  {Account_Number}");
            Console.WriteLine($"The Account Balance: {Balance}");
            Console.WriteLine("____________________");
        }
    }
}