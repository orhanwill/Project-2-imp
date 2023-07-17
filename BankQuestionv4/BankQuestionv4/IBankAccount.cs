using System;
using System.Collections.Generic;
using System.Text;

namespace BankQuestionv4
{
    public interface IBankAccount
    {
        void Deposit(double amount);
        void Withdraw(double amount);
    }
}
