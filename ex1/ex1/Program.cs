using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    class Program
    {
        static void Main()
        {
            int sum = 0;
            string numbers = string.Empty;
            

            Console.WriteLine("Введите число");
           
            int a = Convert.ToInt32(Console.ReadLine());
            
            do
            {
                
                if ((a % 2 != 0) && (a > 0))
                {
                    numbers = numbers + a +",";
                    sum += a;

                }

                Console.WriteLine("Введите число");
                a = Convert.ToInt32(Console.ReadLine());
                


            } while (a != 0);
            Console.WriteLine(sum);
            Console.WriteLine(numbers);

        }

        
    }
}
