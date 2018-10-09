using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class CashInATM : BankATM, ValidationCard
    {
        BankAccount data;
        Transaction transaction;
        private int pinCode;

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

        public bool validateCard(string accountNo, string personID, string pin)
        {
            throw new NotImplementedException();
        }

        public bool validateCard(string accountNo, string personID, int pin)
        {
            if ((accountNo == accountNo) && (personID == data.getAccountNo()) && (pin == pinCode))
            {
                return true;
            }
            else return false;
        }

    }
}
