using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    public interface ITransactions
    {
        void showTransactions();
        double getAmount();
        double getTotalTransactions();
    }

    public class Transaction : ITransactions
    {
        private String transactionID;
        private String date;
        private double amount;
        private String status;
        private double totalTransactions;

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

        public void showTransactions()
        {
            Console.WriteLine("Transaction: {0}", transactionID);
            Console.WriteLine("Date: {0}", date);
            Console.WriteLine("Amount: {0}", amount);
            Console.WriteLine("Status: {0}", getAmount());

        }

    }
}
