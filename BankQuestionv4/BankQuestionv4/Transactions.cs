using System;
using System.Collections.Generic;
using System.Text;

namespace BankQuestionv4
{
    public class Transaction
    {
        public String Transaction1_;
        public Transaction(string transection)
        {
            Transaction1_ = transection;
        }
        public void view()
        {
            Console.WriteLine(Transaction1_);
        }
    }
}
