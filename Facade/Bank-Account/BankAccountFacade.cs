using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    internal class BankAccountFacade
    {
        private WelcomeToBank welcomeTool;
        private FundsCheck fundCheckTool;
        private SecurityCodeCheck securityCodeCheckTool;
        private AccountNumberCheck accountNumberCheckTool;

        private int _checkingAccountNum;
        private int _securityPin;

        public BankAccountFacade(int checkingAccount, int securityPin)
        {
            welcomeTool = new WelcomeToBank();
            fundCheckTool = new FundsCheck(1000.00);
            securityCodeCheckTool = new SecurityCodeCheck(1234);
            accountNumberCheckTool = new AccountNumberCheck(12345678);

            _checkingAccountNum = checkingAccount;
            _securityPin = securityPin;

            welcomeTool.WelcomeUser();
        }

        private bool CheckValidSession()
        {
            if (!accountNumberCheckTool.ValidAccountNumber(_checkingAccountNum))
            {
                return false;
            }

            if (!securityCodeCheckTool.ValidSecurityCode(_securityPin))
            {
                return false;
            }

            return true;
        }

        public void WithdrawCash(double amount)
        {
            if (CheckValidSession() && fundCheckTool.WithdrawMoney(amount))
            {
                Console.WriteLine($"Transaction complete!");
            }
            else
            {
                Console.WriteLine($"Transaction failed.");
            }
        }

        public void DepositCash(double amount)
        {
            if (CheckValidSession())
            {
                fundCheckTool.MakeDeposit(amount);
                Console.WriteLine($"Transaction complete!");
            }
            else
            {
                Console.WriteLine($"Transaction failed.");
            }
        }
    }
}
