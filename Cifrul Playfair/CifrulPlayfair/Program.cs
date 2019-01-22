using System;
using System.Collections.Generic;

namespace CifrulPlayfair
{
    class Program: Playfair
    {

        public static void Init()
        {
            string prop = "The quick brown fox jumps over the lazy dog";
            char[,] theM = new char[5, 5];
            theM = CreateMatrix(prop);

            ShowMatrix(theM);
            Console.WriteLine();

            

            InitMessage();

            ShowInitialMessage();

            ShowEncryptedMessage(theM);

            ShowDecryptedMessage(theM);
        }

        static void Main(string[] args)
        {
            Init();
            Console.ReadKey();
        }
    }
}
