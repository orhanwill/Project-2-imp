using System;
using System.Collections.Generic;
using System.Text;

namespace BankQuestionv4
{
    public class Bank
    {

        public List<BankAccount> BankAccounts { get; set; }

        public Dictionary<string, BankAccount> Dict_BankAccounts { get; set; }
        public Bank()
        {
            BankAccounts = new List<BankAccount>();
            Dict_BankAccounts = new Dictionary<string, BankAccount>();
        }
        public void AddBankAccount(BankAccount account)
        {
            Dict_BankAccounts[account.Account_Number] = account;
            BankAccounts.Add(account);
            Console.WriteLine($"Acc No: {account.Name }  with {account.Account_Number} has been added.");
        }
        public void DepositToAccount(BankAccount acc1, double money)
        {
            foreach (BankAccount account in BankAccounts)
            {
                if (account == acc1)
                {
                    acc1.Balance += money;
                    Console.WriteLine($"The total amount deposited is:  {money}");
                    Console.WriteLine($"The total amount we got is:  {acc1.Balance}");
                }
                //if (account != acc1)
                //{
                //    Console.WriteLine(" The account is not found: ");
                //}


            }
        }
        public void WithdrawFromAccount(BankAccount acc1, double money)
        {
            foreach (BankAccount account in BankAccounts)
            {
                if (account == acc1)
                {
                    acc1.Balance -= money;
                    Console.WriteLine($"The total amount withdrawn is:  {money}");
                    Console.WriteLine($"The total amount we got is:  {acc1.Balance}");
                }
                //if (account != acc1)
                //{
                //    Console.WriteLine(" The account is not found: ");
                //}


            }
        }


    }
}
