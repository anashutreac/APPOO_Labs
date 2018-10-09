using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account {
    class WithdrawATM : BankATM, ValidationCard
    { 

        private int atmID;
        private String accountNo;
        private String address;
        BankAccount data;
        Transaction transaction;
        private int pinCode;

        public WithdrawATM(int atmID, string accountNo, string address, BankAccount data, Transaction transaction, int pinCode) : base(atmID, accountNo, address, data, transaction, pinCode)
        {
        }

        public Boolean cashOutBalance(double ammount)
        {
            if (ammount < transaction.getAmount())
            {
                transaction.cashOutBalance(ammount);
                return true;
            }
            else
            {
                return false;
            }
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

