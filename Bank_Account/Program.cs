using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class BankAccount
    {
        private String accountNo;
        private String personName;
        private String personID;
        private double cardBalance;

        public BankAccount(String accountNo, String personName, String personID, double cardBalance)
        {
            this.accountNo = accountNo;
            this.personName = personName;
            this.personID = personID;
            this.cardBalance = cardBalance;
        }

        public String getAccountName()
        {
            return personName;
        }

        public String getAccountNo()
        {
            return accountNo;
        }

        public String getPersonID()
        {
            return personID;
        }

        public double getCardBalance()
        {
            return cardBalance;
        }

        public void setCardBalance(double amount)
        {
            cardBalance = amount;
        }

        public Boolean cardCashIn(double amount)
        {
            if(amount > 0)
            {
                cardBalance = cardBalance + amount;
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean cardWithdraw(double amount)
        {
            if(amount > cardBalance)
            {
                return false;
            }
            else
            {
                cardBalance = cardBalance - amount;
                return true;
            }
        }

    }

}
