﻿using System;

namespace Parser
{
    class Program
    {
        static void Main(string[] args)
        {
            
            while (true)
            {
                
                var s = Console.ReadLine();      // записывает строку в переменной "s"
                var datestart = DateTime.Now;    // сохраняет текущее время в переменной "datestart" 
                Console.WriteLine(Parse(s));     
                Console.WriteLine(DateTime.Now-datestart); // вычитает время старта программы от времени 
                                                           // его завершения 
               
            }
            
        }
        /// <summary>
        /// метод Parse выполняет сложение и вычитание
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        static int Parse(string s)
        {
            int index = 0;
            int num = Num(s, ref index);
            while (index < s.Length)
            {
                if (s[index] == '+')
                {
                    index++;
                    int b = Num(s, ref index);
                    num += b;
                }
                else if (s[index] == '-')
                {
                    index++;
                    int b = Num(s, ref index);
                    num -= b;
                }
                else
                {
                    Console.WriteLine("Error");
                    return 0;
                }
            }
            return num;
        }
        /// <summary>
        /// Метод MultDiv выполняет умножение и деление
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        static int MultDiv(string s)
        {
            int index = 0;
            int num = Num(s, ref index);
            while (index < s.Length)
            {
                if (s[index] == '*')
                {
                    index++;
                    int b = Num(s, ref index);
                    num *= b;
                }
                else if (s[index] == '/')
                {
                    index++;
                    int b = Num(s, ref index);
                    num /= b;
                }
                else
                {
                    Console.WriteLine("Error");
                    return 0;
                }
            }

            return num;
        }

        static int Num(string s, ref int i)
        {
            string buff = "0"; 
            for (; i < s.Length && char.IsDigit(s[i]); i++)
            {
                buff += s[i];
            }

            return int.Parse(buff);//01
        }

    }

}
