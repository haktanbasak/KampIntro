using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplicationManager
    {
        //Method Injection
        public void ToApply(ILoanManager loanManager, ILoggerService loggerService)
        {
            //Başvuran bilgilerini değerlendirme
            loanManager.Calculate();
            loggerService.Log();
        }

        public void LoanInformation(List<ILoanManager> loans)
        {
            foreach (var loan in loans)
            {
                loan.Calculate();
            }
        }
    }
}
