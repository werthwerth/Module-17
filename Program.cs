using System.Reflection.Metadata;
using System.Text;

namespace Module_17
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            ICalculate calc = new CalculateInterest();
            Account account = new Account(12.3);
            calc.Calculate(account);
        }
    }
}