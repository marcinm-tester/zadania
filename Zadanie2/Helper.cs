using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie2
{
    class Helper
    {
        string stringNumber;
        decimal tax;
        decimal taxRate;
        public decimal FirstPrompt()
        {
            Console.WriteLine("Podaj kwotę:");
            Console.Write("> ");
            stringNumber = Console.ReadLine();
            return Decimal.Parse(stringNumber);
        }
        
        private decimal CountTax(decimal income)
        {
           if (income < 10000)
            {
                taxRate = 0.1M;
            }
           else if (income <= 30000)
            {
                taxRate = 0.15M;
            }
            else { taxRate = 0.2M; }

            tax = taxRate * income;
            return tax;
        }

        public void ShowYourTax(decimal income)
        {
            Console.WriteLine($"Podatek od kwoty {income} wynosi {CountTax(income)} - przy stawce {taxRate}");
        }
    }
}
