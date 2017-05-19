using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    class Program
    {
        static bool coprime(int a, int b)
        {
            for (int i = 2; i <= a; ++i)
            {
                if (a % i == 0)
                {
                    if (b % i == 0)
                        return false;
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            DirectoryInfo di = new DirectoryInfo("Task1");
            foreach (var f in di.GetFiles())
            {
                string filename = f.FullName;
                StreamReader sr = new StreamReader(filename);
                String[] s = sr.ReadLine().Split(' ');
                int a = int.Parse(s[0]);
                int b = int.Parse(s[1]);
                string result = "no";
                if (coprime(a, b))
                {
                    result = "yes";
                }
                Console.WriteLine(f.Name + ": " + result);
            }
            Console.ReadKey();
            // StreamReader sr = new StreamReader("Task1");
        }
    }
}
