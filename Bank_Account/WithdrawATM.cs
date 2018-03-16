using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class WithdrawATM: IBankATM, ICashOut { 

        private int atmID;
        private String accountNo;
        private String address;
        BankAccount data;
        Transaction transaction;


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
