using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class DebitCard : BankAccount, IBankCard
    {
        private double anualTax;
        private double transactionFee;
        private double deposit;
        private double cashbackServices;
        

        public DebitCard(string accountNo, string accountName, string personID, double cardBalance, int transactionsNo) 
            : base(accountNo, accountName, personID, cardBalance)
        {
            
        }

        public void addAnualTax()
        {
            double tax = getCardBalance() * anualTax / 100;
            this.cardWithdraw(tax);
        }

        public void addTransactionFee()
        {
            Transaction amount = new Transaction();
            double fee = amount.getAmount() * transactionFee / 100;
            this.cardWithdraw(fee);
        }

        public void addDeposit()
        {
            double amount = getCardBalance() * deposit / 100;
            cardCashIn(amount);
        }

        public void addCashBack()
        {
            Transaction amount = new Transaction();
            double cashback = amount.getAmount()  * cashbackServices / 100;
            cardCashIn(cashback);
        }




    }
}
