using System.Diagnostics;
using System;

namespace Basics
{
    public class Reference
    {
        public static void Swap(ref int a, ref int b)
        {
            int x = a;
            a = b;
            b = x;

            Console.WriteLine("a = " + a, "b = " + b);
        }

        public static int Trunc(ref float f)
        {
            int i = (int)f;
            f = f % 1;
            return i;
        }

        public static void RotChar(ref char c, int n)
        {
            int c_value = c;

            if (c > 47 && c < 58)
            {
                if (c + n < 48)
                {
                    c_value = c + n + 9;
                }
                else if (c + n > 57)
                {
                    c_value = c + n - 9;
                }
                else
                {
                    c_value = c + n;
                }
                c = (char) c_value;
                Console.WriteLine(c);
 
            }

            else if (c > 64 && c < 91)
            {
                if (c + n < 65)
                {
                    c_value = c + n + 25;
                }
                else if (c + n > 90)
                {
                    c_value = c + n - 25;
                }
                else
                {
                    c_value = c + n;
                }
                c = (char) c_value;
                Console.WriteLine(c);
 
            }

            else if (c > 96 && c < 123)
            {
                if (c + n < 97)
                {
                    c_value = c + n + 25;
                }
                else if (c + n > 122)
                {
                    c_value = c + n - 25;
                }
                else
                {
                    c_value = c + n;
                }
                c = (char) c_value;
                Console.WriteLine(c);
            }
                       
            else
            {
                Console.WriteLine("Error: Invalid char.");
            }
        }      
    }
}