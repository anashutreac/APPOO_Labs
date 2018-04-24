using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class CashInATM : BankATM
    {
        BankAccount data;
        Transaction transaction;

        public CashInATM(int atmID, String accountNo, String address, BankAccount data, Transaction transaction, int pinCode) : base(atmID, accountNo, address, data, transaction, pinCode)
        {
            
        }

        public bool addCashToBalance(double amount)
        {
            double newBalance;
            newBalance = data.getCardBalance() - amount;
            transaction.cashOutBalance(newBalance);
            return true;
        }

        
    }
}
