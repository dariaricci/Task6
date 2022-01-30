using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string stroka = Console.ReadLine();
            stroka = stroka.ToLower();
            stroka = stroka.Replace(" ", "");
            int N = stroka.Length;
            int K = 0;
            for (int i = 0; i < N/2; i++)
            {
                if (stroka[i] == stroka[N - 1 - i])
                    K++;
                else
                    break;
            }
            if (K == N/2)
                Console.WriteLine("Является");
            else
                Console.WriteLine("Не является");

            Console.ReadKey();
        }
    }
}
