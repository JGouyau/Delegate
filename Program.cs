using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Delegate
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            ShowMoney test = ShowMoneyEuro;
            Console.WriteLine(test(25));
            test = ShowMoneyDollar;
            Console.WriteLine("\n"+test(25));

            Console.Read();
        }


        public delegate string ShowMoney(int money);

        public static string ShowMoneyEuro(int money)
        {
            return money + " €";
        }

        public static string ShowMoneyDollar(int money)
        {
            return "$"+0.86*money;
        }
    }
}
