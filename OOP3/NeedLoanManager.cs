using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class NeedLoanManager : ILoanManager
    {
        public void Calculate()
        {
            Console.WriteLine("İhtiyaç kredisi hesaplanmıştır.");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
