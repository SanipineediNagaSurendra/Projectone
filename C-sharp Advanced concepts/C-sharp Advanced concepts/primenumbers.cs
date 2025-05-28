using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_Advanced_concepts
{
    public class primenumbers
    {
        static void Main()
        {
            //for(int i =1; i<=100; i++)
            //{
            //    if(i%2==0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            Console.WriteLine("Enter a no : ");
            int no = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for(int i =1; i<=no; i++)
            {
                if(no%i == 0)
                {
                    count++;
                 
                }
                
            }
            if (count == 2)
            {
                Console.WriteLine("prime");
            }
            else
            {
                Console.WriteLine("not prime");
            }
        }
    }
}
