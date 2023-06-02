using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    internal class SecurityCodeCheck
    {
        private int _securityCode;
        public SecurityCodeCheck(int securityPin)
        {
            _securityCode = securityPin;
        }

        public bool ValidSecurityCode(int accountNumber)
        {
            return _securityCode == accountNumber;
        }
    }
}
