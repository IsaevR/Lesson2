using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            
            while (true)
            {
                
                var s = Console.ReadLine();
                var datestart = DateTime.Now;              // Сохраняям текущее время в переменной 
                Console.WriteLine(Parse(s));
                Console.WriteLine(DateTime.Now-datestart); // Отображает время за прериод вычислений 
               
            }
            
        }
        static int Parse(string s)
        {
            int index = 0;
            int num = Num(s, ref index);
            while (index < s.Length)
            {
                switch (Priority(s[index]))
                {
                    case 2:
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
                            break;
                        
                     case 3:
                            if (s[index] == '*')
                            {
                                index++;
                                int b = Num(s, ref index);
                                num *= b;
                            }
                            else if(s[index] == '/')
                            {
                                index++;
                                int b = Num(s, ref index);
                                num /= b;
                            }
                            break;
                    default:
                             Console.WriteLine("Error");
                             return 0;
                 } 
            }

            return num;
        }
        static int Collect(int i)
        {
            
            int result = 0;
            return result;
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

        static int Priority(char action)
        {
            switch (action)
            {
                case '*': 
                case '/': return 3;
                case '+': 
                case '-': return 2;
            }
            return 0;
        }

    }

}
