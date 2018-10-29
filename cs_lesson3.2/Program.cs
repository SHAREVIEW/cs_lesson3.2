using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_lesson3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //if语句,比较两个数值大小
            string comparison;
            Console.WriteLine("Enter a number:");
            double var1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter another number:");
            double var2 = Convert.ToDouble(Console.ReadLine());
            if (var1 < var2)
                comparison = "less than";
            else
            {
                if (var1 > var2)
                    comparison = "greater than";
                else
                    comparison = "equal to";

            }
            Console.WriteLine("The first number is {0} the second number.", comparison );
            Console.ReadKey();
                                 
        }
    }
}
