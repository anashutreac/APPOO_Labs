using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class BankATM: BankAccount
    {
        private int atmID;
        private String address;

        public BankATM(string accountNo, string personName, string personID, double cardBalance, int atmID, String address) 
            : base(accountNo, personName, personID, cardBalance)
        {
            this.atmID = atmID;
            this.address = address;
        }

        public void printCardBalance()
        {
            Console.WriteLine("Card balance is: {0}", getCardBalance());

        }

        public void atmWithdraw(double amount)
        {
            setCardBalance(getCardBalance() - amount);
            Console.WriteLine(" Your current card balance is: {0}", getCardBalance());
            Console.WriteLine(" Your withdraw amount is: {0}", amount);
        }

        public void atmCashIn(double amount)
        {
            setCardBalance(getCardBalance() + amount);
            printCardBalance();
        }
    }
}
