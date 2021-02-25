using System;

namespace Zadanie1
{
    class Program
    {
        static void Main(string[] args)
        {
            int liczba = 0;
            Console.WriteLine("Hello World!");
            Helper helper = new Helper();
            while (liczba < 1 || liczba > 10) { 
                liczba = helper.FirstPrompt();
            }
            helper.ShowResult(liczba);


        }

        
    }
}
