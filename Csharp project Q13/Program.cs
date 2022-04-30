using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_project_Q13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("please insert a number: ");
            int n = int.Parse(Console.ReadLine());
            bool prime = true;
            
                for(int i = 2; i<= Math.Sqrt(n); i++)
                {
                    if(n%i==0)
                    {
                        prime = false;
                        
                    }
                   
                }

                if(prime)
                {
                    Console.WriteLine("its a prime number");
                }
                else
                {
                    Console.WriteLine("its not a prime number");
            }
            
        }
    }
}
