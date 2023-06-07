using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module17.Profiles
{
    public class SalaryAccount : ICalculateInterest
    {
        public void Execute(Account account)
        {
            account.Interest = account.Balance * 0.5;
        }
    }
}
