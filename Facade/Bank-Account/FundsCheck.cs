using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    internal class FundsCheck
    {
        public string CurrencySymbol { get; private set; }
        public double Amount { get; private set; }
        public FundsCheck(double initialAmount)
        {
            Amount = initialAmount;
            CurrencySymbol = "£";
        }

        public bool WithdrawMoney(double amount)
        {
            if (Amount < amount)
            {
                Console.WriteLine($"Error: You don't have enough money.");
                SayBalance();
                return false;
            }

            DecreaseFunds(amount);

            Console.WriteLine($"Withdrawl complete!");
            SayBalance();
            return true;
        }

        public void MakeDeposit(double amount)
        {
            IncreaseFunds(amount);
            Console.WriteLine($"Deposit complete!");
            SayBalance();
        }

        private void DecreaseFunds(double amount)
        {
            Amount -= amount;
        }

        private void IncreaseFunds(double amount)
        {
            Amount += amount;
        }

        private void SayBalance()
        {
            Console.WriteLine($"Current Balance: {CurrencySymbol}{Amount}");
        }
    }
}
