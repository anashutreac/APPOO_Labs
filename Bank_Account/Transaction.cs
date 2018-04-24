using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    public class Transaction: ITransaction
    {
        private String transactionID;
        private String date;
        private double amount;
        private String status;
        private double totalTransactions;
        private double cardBalance;

        public Transaction()
        {

        }
        public Transaction(String transactionID, String date, double amount, String status)
        {
            this.transactionID = transactionID;
            this.date = date;
            this.amount = amount;
            this.status = status;
            this.totalTransactions = this.totalTransactions + amount;
        }

        public double getAmount()
        {
            return amount;
        }
        public double getTotalTransactions()
        {
            return totalTransactions;
        }

        public Boolean cashOutBalance(double ammount)
        {
            if (amount > cardBalance)
            {
                return false;
            }
            else
            {
                cardBalance = cardBalance - amount;
                return true;
            }
        }

        public Boolean cashInBalance(double ammount)
        {
            if (amount > 0)
            {
                cardBalance = cardBalance + amount;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
