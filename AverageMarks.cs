using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] arr = { 11, 33, 55, 77, 99 };
            double maxNumber = 0;
            for(int i=0;i<arr.Length;i++)
            {
                if(arr[i]>maxNumber)
                {
                    maxNumber = arr[i];
                }    
            }
            Console.WriteLine("Maximum marks are: ", +maxNumber);
            Console.ReadLine();
        }
    }
}
