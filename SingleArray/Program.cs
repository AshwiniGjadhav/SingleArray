using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num=new int[4] {4,6,7,8};
            String[] s1 = { "vish", "mona", "rama", "seema" };
                int[] number = new int[5];
                string[] str = new string[5];

            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine($"num[i] = {num[i]}");
            }

            Console.WriteLine("--------------");

            for(int i = 0; i < s1.Length; i++)
            {
                Console.WriteLine($"s1[i] = {s1[i]}");
            }

            Console.WriteLine("-------------");
           Console.WriteLine("enter 5 numbers");

                for (int i = 0; i < number.Length; i++)
                {
                    number[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.Write("----------------");

                for (int i = 0; i < number.Length; i++)
                {
                    Console.WriteLine($"number{i}={number[i]}");
                }

            Console.WriteLine("----------");
            Console.WriteLine("enter 5 name");
                  for (int i = 0; i < str.Length; i++)
                     {
                         str[i] = Console.ReadLine();
                     }
                     Console.WriteLine("----------------");

                     for (int i = 0; i < str.Length;i++)
                     {
                         Console.WriteLine($"str{i} ={str[i]}");
                     }
        }
    }
}
