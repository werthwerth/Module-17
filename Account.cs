using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_17
{
    public class Account
    {
        public Account(double balance = 0, double interest = 0, string type = "Обычный")
        {
            Type = type;
            Balance = balance;
            Interest = interest;
        }
        // тип учетной записи
        public string Type { get; set; }

        // баланс учетной записи
        public double Balance { get; set; }

        // процентная ставка
        public double Interest { get; set; }
    }
}
