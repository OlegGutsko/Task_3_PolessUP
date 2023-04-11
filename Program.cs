using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_PolessUP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 3. Учитывая отсортированный массив различных целых чисел и целевое значение, 
               вернуть индекс, если цель найдена. Если нет, верните индекс туда, где он был бы,
               если бы он был вставлен по порядку. 
            */

            int[] nums = new int[4] { 1, 3, 5, 6 };

            int target = 5;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                    Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
