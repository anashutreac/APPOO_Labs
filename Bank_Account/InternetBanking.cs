using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class InternetBanking: BankAccount
    {
        private String userName;
        private String password;
     

        public InternetBanking(string accountNo, string personName, string personID, double cardBalance, String userName, String password) 
            : base(accountNo, personName, personID, cardBalance)
        {
            this.userName = userName;
            this.password = password;

        }

        

    }
}
