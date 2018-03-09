using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    interface IBankATM
    {
        Boolean checkCardData();
        double getCardBalance();

        
    }
}
