using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            string stroka = Console.ReadLine();
            string[] stringArray = stroka.Split();
            string max ="";
            int N = 1;
            foreach (string a in stringArray)
            {
                if (a.Length > N)
                {
                    N = a.Length;
                    max = a;
                }
            }
            Console.WriteLine(max);
            Console.ReadKey();
        }
        
    }
}
