using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account 
{
    class CurrencyATM : BankATM, ValidationCard
    {
        private double euroCurrency;
        private double dolarCurrency;
        BankAccount data;
        Transaction transaction;
        private int pinCode;

        public CurrencyATM(double euroCurrency, double dolarCurrency, int atmID, String accountNo, String address, BankAccount data, Transaction transaction, int pinCode) : base(atmID, accountNo, address, data, transaction, pinCode)
        {

        }

        public double changeCurrency(double currency, double amount, String type)
        {
            if (type == "euro")
               amount = currency * amount;
            
            else if (type == "dollar")
               amount = currency * amount;

            return amount;    
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
