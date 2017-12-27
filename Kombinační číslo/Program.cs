using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kombinační_číslo
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            int x = 1;
            while (x != 0)
            {
                int n = 1;
                int k = 0;
                while (n <= 1 && k <= 0 && k < n || n >= 11 )
                {
                    Console.WriteLine("Zadejte počet čísel z kterých chtete vybírat");
                    int.TryParse(Console.ReadLine(), out n);

                    Console.WriteLine("Kolik čísel chcete vybírat");
                    int.TryParse(Console.ReadLine(), out k);
                }
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine(program.Vypocti(n,k));
                Console.WriteLine("-------------------------------------------");


            }
        }
        public int Vypocti(int n, int k)
        {
           
            int nF = 1;
            int kF = 1;
            int nkF = 1;
            for (int p = n; p > 0; p--) { nF = nF * p; }
            for (int p = k; p > 0; p--) { kF = kF * p; }
            for (int p = n - k; p > 0; p--) { nkF = nkF * p; }
            int v = nF / (kF * nkF); 
            return v;
        }
    }
}
