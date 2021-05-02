using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ILoanManager needLoanManager = new NeedLoanManager();
            ILoanManager vehicleLoanManager = new VehicleLoanManager();
            ILoanManager mortgageLoanManager = new MortgageLoanManager();
            ILoanManager esnafLoanManager = new EsnafLoanManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.ToApply(esnafLoanManager,smsLoggerService);
            //applicationManager.ToApply(needLoanManager);

            List<ILoanManager> loans = new List<ILoanManager>() {needLoanManager,vehicleLoanManager };

            //applicationManager.LoanInformation(loans);




        }
    }
}
