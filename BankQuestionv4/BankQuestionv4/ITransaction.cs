using System;
using System.Collections.Generic;
using System.Text;

namespace BankQuestionv4
{
    public interface ITransaction
    {
        void ExecuteTransaction(double amount);
        void PrintTransaction();
    }
}
