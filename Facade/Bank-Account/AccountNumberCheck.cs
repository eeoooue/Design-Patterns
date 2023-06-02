using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    internal class AccountNumberCheck
    {
        private int _accountNumber;
        public AccountNumberCheck(int number)
        {
            _accountNumber = number;
        }  

        public bool ValidAccountNumber(int accountNumber)
        {
            return _accountNumber == accountNumber;
        }
    }
}
