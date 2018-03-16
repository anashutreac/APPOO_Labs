using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    interface ITransaction
    {
        Boolean cashOutBalance(double ammount);

        Boolean cashInBalance(double ammount);
    }
}
