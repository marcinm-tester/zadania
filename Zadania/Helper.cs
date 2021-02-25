using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie1
{
    class Helper
    {
        string stringNumber;
        public int FirstPrompt()
        {
            Console.WriteLine("Podaj liczbę od 1 do 10");
            Console.Write("> ");
            stringNumber = Console.ReadLine();
            
            try{

               return Int32.Parse(stringNumber);
            }
            catch (Exception exp){
                Console.WriteLine("Niepoprawna liczba. Spróbuj jeszcze raz!");
                return 0;
            }
            
        }

        public int SqureOfNumber(int number)
        {
            return number * number;
        }

        public void ShowResult(int number)
        {
            Console.WriteLine($"Wynik {stringNumber}^2 wynosi {SqureOfNumber(number)}");
        }
    }
}
