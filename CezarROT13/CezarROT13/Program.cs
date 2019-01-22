using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CezarROT13
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("propozitia inainte de criptare:");
            string text = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            

            Console.WriteLine("propozitia dupa criptare folosind Cezar:");
            Engine.Encrypt(text,n);
            Console.WriteLine(Engine.s4);

            Console.WriteLine("propozitia dupa decriptare:");
            Engine.Decrypt(Engine.s4, n);
            Console.WriteLine(Engine.s5);

            Engine.Reset();

            Console.WriteLine("propozitia dupa criptare folosind ROT13:");
            ROT13.Encrypt(text);
            Console.WriteLine(ROT13.s4,13);

            Console.WriteLine("propozitia dupa decriptare:");
            ROT13.Decrypt(ROT13.s4,13);
            Console.WriteLine(ROT13.s5);

            ROT13.Reset();
        }

    }
}
