using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class PremiumCard : BankAccount, IBankCard
    { 
        private double anualTax;
        private double transactionFee;
        private double interestRate;
        private double creditLimit;
        private double cashbackServices;

        public PremiumCard(string accountNo, string personName, string personID, double cardBalance, double interestRate, double creditLimit, double transactionFee, double anualTax, double cashbackServices) : base(accountNo, personName, personID, cardBalance)
        {
            this.interestRate = interestRate;
            this.creditLimit = creditLimit;
            this.transactionFee = transactionFee;
            this.anualTax = anualTax;
            this.cashbackServices = cashbackServices;
        }

        public void addInterest()
        {
            double interest = getCardBalance() * interestRate / 100;
            this.cardWithdraw(interest);
        }

        public void addTransactionFee()
        {
            Transaction amount = new Transaction();
            double fee = amount.getAmount() * transactionFee / 100;
            this.cardWithdraw(fee);
        }

        public void addAnualTax()
        {
            double tax = getCardBalance() * anualTax / 100;
            this.cardWithdraw(tax);

        }

        public void addCashBack()
        {
            Transaction amount = new Transaction();
            double cashback = amount.getAmount() * cashbackServices / 100;
            cardCashIn(cashback);
        }
        public void limitTax()
        {
            Transaction totalTrans = new Transaction();
            if (totalTrans.getTotalTransactions() > creditLimit)
            {
                Console.WriteLine("Your credit limit is crossed!");
                double fine = getCardBalance() * 9 / 100;
                cardWithdraw(fine);
            }
        }
    }

    
}

