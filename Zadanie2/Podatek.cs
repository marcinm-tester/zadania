using System;

namespace Zadanie2
{
    class Podatek
    {
        static void Main(string[] args)
        {
            decimal podatek;    
            decimal dochod;
            Console.WriteLine("Hello World!");

            Helper helper = new Helper();
            dochod = helper.FirstPrompt();
            helper.ShowYourTax(dochod);
            helper.ShowYourTax(5000);
            helper.ShowYourTax(15000);
            helper.ShowYourTax(25000);
            helper.ShowYourTax(35000);



        }
    }
}
