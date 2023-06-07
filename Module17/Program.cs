using Module17.Profiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module17
{
   public class Program
    {
        static void Main(string[] args)
        {
            var calculator1 = new Calculator();
            calculator1.CalculateInterest(new OrdinaryAccount());

            var calculator2 = new Calculator();
            calculator2.CalculateInterest(new SalaryAccount());

            Console.ReadKey();

        }
    }
}
