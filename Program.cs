using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of array");
            int arrsize  = Convert.ToInt32(Console.ReadLine());
            int[] ary = new int[arrsize];
            Console.WriteLine("Enter the elements");
            for (int i=0;i<arrsize;i++)
            {
                ary[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Array before sorting: \n" + string.Join("\t", ary));
            Bubble_sorting(ref ary, arrsize);
            Console.WriteLine("Array after sorting: \n" + string.Join("\t", ary));

        }

        private static void Bubble_sorting(ref int[] num,int ary_size)
        {
            for (int i = 0; i < ary_size-1 ; i++)
            {
                for (int j = 0; j < ary_size-1 ; j++)
                {
                    
                    if (num[j] > num[j+1])
                    {
                        int temp = num[j];
                        num[j] = num[j + 1];
                        num[j + 1] = temp;
                    }
                }
            }
        }
    }
}
