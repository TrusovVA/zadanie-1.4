using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            Console.WriteLine("Ведите первое предложение: ");
            str = Console.ReadLine();
            Console.WriteLine("Введите второе предложение: ");
            str += " " + Console.ReadLine();

            string[] array = str.Split();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == "") continue;
                bool f = true;
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[j] == "" || i == j) continue;
                    if (array[i] == array[j])
                    {
                        array[j] = "";
                        f = false;
                    }
                }
                if (f) Console.WriteLine(array[i]);
                array[i] = "";
            }
            Console.ReadKey();
        }
    }
}
