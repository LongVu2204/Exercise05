using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Print_a_2_z();
            Print_z_2_a();
            Print_A_2_Z();
            Print_ASCII_CODE('c');
            Print_ASCII_CODE_V2('x');
            Check('x');



        }
        static void Print_a_2_z()
        {
            for (char x = 'a'; x <= 'z'; x++)
            {
                Console.Write(x + " ");
            }
        }
        static void Print_z_2_a()
        {
            for (char x = 'z'; x >= 'a'; x--)
            {
                Console.Write(x + " ");
            }
        }
        static void Print_A_2_Z()
        {
            for (char x = 'A'; x <= 'Z'; x++)
            {
                Console.Write(x + " ");
            }
        }
        static void Print_ASCII_CODE(char x)
        {
            Console.WriteLine((int)x);
        }
        static void Print_ASCII_CODE_V2(char x)
        {
            for (int i = 65; i <= 122; i++)
            {
                if ((int)x == i)
                {
                    Console.Write(i);
                }
            }
       }
        static void Check(char x)
        {
            for (int i = 65; i <= 90; i++)
            {
                if ((int)x == i)
                {
                    Console.Write(i);
                } 
            }
        }
    }
}