using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Module_17
{
    public class Calculator
    {
        // Метод для расчета процентной ставки
        public static void Calculate(ICalculate calc, Account account)
        {
            calc.Calculate(account);
        }
    }
}
