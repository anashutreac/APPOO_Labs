using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account 
{
    class CurrencyATM : BankATM
    {
        private double euroCurrency;
        private double dolarCurrency;

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
    }
}
