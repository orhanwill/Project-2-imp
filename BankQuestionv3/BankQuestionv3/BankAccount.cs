using System;
using System.Collections.Generic;
using System.Text;

namespace BankQuestionv3
{
    public abstract class BankAccount :  ITransaction
    {
        public string Name { get; set; }
        public int Account_Number { get; set; }
        public double Balance { get; set; }
        public BankAccount(string name, int account_number, double balance)
        {
            Name = name;
            Account_Number = account_number;
            Balance = balance;

        }
        public virtual void Deposit(double amountd) { }
        public virtual void Withdraw(double amountw) { }
        public virtual void ExecuteTransaction(double amount) { }
        public virtual void PrintTransaction() { }
        public virtual void TakeLoan(double amountl) { }
        public virtual void CalculateInterest(double amountr) { }
        public abstract void DisplayAccountInfo();

    }
}