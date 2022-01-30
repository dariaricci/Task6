using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string resultString = "";
            int N = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if ((s[i] != '{') && (s[i] != '}'))
                    resultString += s[i];
                else
                    if (s[i] == '{')
                {
                    N++;
                    do
                    {
                        i++;
                        if (s[i] == '{')
                        N++;
                        if (s[i] == '}')
                        N--;
                    }
                    while (N!=0);
                    
                }
            }
            Console.WriteLine(resultString);
            Console.ReadKey();
        }
    }
}
