using System;
using System.Collections.Generic;
using System.Text;

namespace BankQuestionv4
{
    public abstract class BankAccount : ITransaction
    {
        public string Name { get; set; }
        public int Account_Number { get; set; }
        public double Balance { get; set; }
        public List<Transaction> Transactions1;
        public Dictionary<string, List<Transaction>> TransactionTypes { get; set; }

        public BankAccount(string name, int account_number, double balance)
        {
            Name = name;
            Account_Number = account_number;
            Balance = balance;
            Transactions1 = new List<Transaction>();
            Transaction transfer = new Transaction($"Amount {balance} Added as initial balance");
            Transactions1.Add(transfer);
            TransactionTypes = new Dictionary<string, List<Transaction>>();

            TransactionTypes.Add("Deposit", Transactions1);

        }
        public virtual void Deposit(double amountd) { }
        public virtual void Withdraw(double amountw) { }
        public virtual void ExecuteTransaction(double amount) { }
        public virtual void PrintTransaction() { }
        public void Transaction_History()
        {
            foreach (Transaction i in Transactions1)
            {
                //Console.WriteLine(i);
                i.view();
            }
        }
        public virtual void TakeLoan(double amountl) { }
        public virtual void CalculateInterest(double amountr) { }

        public abstract void DisplayAccountInfo();
    }
}
