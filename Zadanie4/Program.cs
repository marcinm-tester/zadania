using System;

namespace Zadanie4
{
    class Program
    {
        static void Main(string[] args)
        {
            Alfabet alfabet = new Alfabet();
            alfabet.CryptDictionary("kot w butach", 3);
            alfabet.CryptDictionary("Zebra", 1);
            alfabet.CryptDictionary("Zebra", 2);
            alfabet.CryptDictionary("Zebra", 3);
        }
    }
}
