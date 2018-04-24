using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class BankATM
    {
        private int atmID;
        private String accountNo;
        private String address;
        private BankAccount data;
        private Transaction transaction;
        private int pinCode;

        public BankATM(int atmID, String accountNo, String address, BankAccount data, Transaction transaction, int pinCode)
        {

        }

        public bool checkCardData()
        {
            if (this.accountNo == data.getAccountNo())
                return true;
            else
                return false;

        }

        public double getCardBalance()
        {
            double balance = data.getCardBalance();
            return balance;

        }

        public bool withdrawCashFromBalance(double amount)
        {
            double newBalance;
            newBalance = data.getCardBalance() - amount;
            transaction.cashOutBalance(newBalance);
            return true;
        }
    }
}
