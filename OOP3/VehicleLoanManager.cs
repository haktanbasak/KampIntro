using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class VehicleLoanManager : ILoanManager
    {
        public void Calculate()
        {
            Console.WriteLine("Taşıt kredisi hesaplanmıştır.");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
