using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie4
{
    class Alfabet
    {
        private IDictionary<int, string> myCryptoDict = new Dictionary<int, string>();


        public Alfabet() 
        {
            myCryptoDict.Add(0, "a");
            myCryptoDict.Add(1, "b");
            myCryptoDict.Add(2, "c");
            myCryptoDict.Add(3, "d");
            myCryptoDict.Add(4, "e");
            myCryptoDict.Add(5, "f");
            myCryptoDict.Add(6, "g");
            myCryptoDict.Add(7, "h");
            myCryptoDict.Add(8, "i");
            myCryptoDict.Add(9, "j");
            myCryptoDict.Add(10, "k");
            myCryptoDict.Add(11, "l");
            myCryptoDict.Add(12, "m");
            myCryptoDict.Add(13, "n");
            myCryptoDict.Add(14, "o");
            myCryptoDict.Add(15, "p");
            myCryptoDict.Add(16, "r");
            myCryptoDict.Add(17, "s");
            myCryptoDict.Add(18, "t");
            myCryptoDict.Add(19, "u");
            myCryptoDict.Add(20, "w");
            myCryptoDict.Add(21, "x");
            myCryptoDict.Add(22, "y");
            myCryptoDict.Add(23, "z");
        }

          public void CryptDictionary(string message, int movement = 7)
          {

            StringBuilder cryptoMessage = new StringBuilder();

            
            foreach (char c in message.ToLower())
            {
                if (c.ToString() == " ")
                {
                    cryptoMessage.Append(" ");
                    continue;

                }
                    

                for (int i =0; i< myCryptoDict.Count; i++)
                {
                    if (myCryptoDict[i] == c.ToString())
                    {
                        cryptoMessage.Append(myCryptoDict[(i + movement) % myCryptoDict.Count]);
                    }        
                }
                
            }
            Console.WriteLine("Szyfr Cezara");
            Console.WriteLine($"Klucz: {movement}");
            Console.WriteLine($"Wiadomość: {message}");
            Console.WriteLine($"Zaszyfrowana: {cryptoMessage}\n");
        }



    }
}
