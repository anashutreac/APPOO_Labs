using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class WithdrawATM: BankATM {

        //private int atmID;
        //private String accountNo;
        //private String address;
        //BankAccount data;
        //Transaction transaction;
        //private int pinCode;

        public WithdrawATM(int atmID, String accountNo, String address, BankAccount data, Transaction transaction, int pinCode) : base(atmID, accountNo, address, data, transaction, pinCode)
        {

        }

        
    }
}
