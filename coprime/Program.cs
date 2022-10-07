using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coprime
{
  
    public  class Program
    {
        public  void  isCoprime(int a, int b)
        {
            int c = 0;
            for (int i = 1; i <= a && i <= b; i++)
            {
                if (a % i == 0 && b % i == 0)
                    c++;
            }

            if (c == 1)
            {
                Console.WriteLine("Coprime");
            }
            else
            {
                Console.WriteLine("not coprime");
            }
        }

       
        

            static void Main(string[] args)
        {
            Program p = new Program();
            p.isCoprime(8,15);
        }
    }
}
