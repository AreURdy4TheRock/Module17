using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Module17.Profiles
{
    public class OrdinaryAccount : ICalculateInterest
    {

        public void Execute(Account account)
        {
            if (account.Balance < 1000)
                account.Interest -= account.Balance * 0.2;

            if (account.Balance >= 1000)
                account.Interest -= account.Balance * 0.4; 
        }
    }
}
