using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicStatsCommandLine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers:");
            string input=Console.ReadLine();
            string[] numberString=input.Split(' ');

            int count = numberString.Length; 
            int sum = 0;
            int max = int.MinValue;
            int min = int.MaxValue;

            foreach (string numberStrings in numberString)
            {
                if (int.TryParse(numberStrings, out int num))
                {
                    sum += num;
                    if (num > max)
                    {
                        max = num;
                    }
                    if (num < min)
                    {
                        min = num;
                    }
                }
            }
                int avg=sum / count;
                Console.WriteLine("The count of numbers: "+count);
                Console.WriteLine("The sum of numbers: "+sum);
                Console.WriteLine("The maximum number is: "+max);
                Console.WriteLine("The minimum number is: "+min);
                Console.WriteLine("The average of numbers is: "+avg);
        }
    }
}
