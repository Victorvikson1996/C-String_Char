// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Chars 
{
    class Progam {
        static void Main(string[] args) {

            string textAge = "-23";
            int age = Convert.ToInt32(textAge);
            Console.WriteLine(age);
    
            string name = "Aba";
            char letter = 'a';
            string textBigNumber = "-900000000000";
            long bigNumber = Convert.ToInt64(textBigNumber);
            Console.WriteLine(bigNumber);

            string textPrecision = "5.00001";
            float precision = Convert.ToSingle(textPrecision);
            Console.WriteLine(precision);

            string textMoney = "14.99";
            decimal money = Convert.ToDecimal(textMoney);
            Console.WriteLine(money);

            Console.WriteLine("Your name is ");
            Console.WriteLine(name);


            Console.ReadLine();
        }
    }
}
