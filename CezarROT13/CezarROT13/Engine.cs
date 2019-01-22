using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CezarROT13
{
    class Engine
    {


        static string letters = "abcdefghijklmnopqrstuvwxyz";
        static public string s2 = "";
        static public string s4 = "";
        static public string s5 = "";

         static int k;

        public static void Shuffle(int k1 = 13)
        {
            k = k1;

            k = k % letters.Length;

            for (int i = 0; i < letters.Length; i++)
            {
                if (k >= 1 && k != letters.Length)
                {
                    s2 += letters[k];
                    k++;
                }
                else
                {
                    k = 0;
                    s2 += letters[k];
                    k++;
                }
            }
        }

        public static void Encrypt(string s, int n = 13)
        {
            Shuffle(n);
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                {
                    s4 += ' ';
                }
                for (int j = 0; j < letters.Length; j++)
                {
                    if (s[i] == letters[j])
                    {
                        s4 += s2[j];
                    }
                }
            }

        }

        public static void Decrypt(string s, int n = 13)
        {
            //Shuffle(n);
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                {
                    s5 += ' ';
                }
                for (int j = 0; j < letters.Length; j++)
                {
                    if (s[i] == s2[j])
                    {
                        s5 += letters[j];
                    }
                }

            }
        }

        public static void Reset()
        {
            s4 = "";
            s5 = "";
        }
    }
}
