using Module17.Profiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module17
{
    class Calculator
    {
        // Метод для расчета процентной ставки
        public void CalculateInterest(ICalculateInterest calculateInterest)
        {
            calculateInterest.Execute(new Account());
        }

    }
}
