using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums1 = Console.ReadLine().
                Split().
                Select(int.Parse).
                ToList();
            List<int> nums2 = Console.ReadLine().
                Split().
                Select(int.Parse).
                ToList();

            List<int> resultNums = new List<int>();
            int minLength = Math.Min(nums1.Count, nums2.Count);

            if (nums1.Count == nums2.Count)
            {
                for (int i = 0; i < minLength; i++)
                {
                    resultNums.Add(nums1[i]);
                    resultNums.Add(nums2[i]);
                }
            }


            else if (nums1.Count < nums2.Count)
            {
                var temp = nums2.Skip(minLength).ToList();

                for (int i = 0; i < minLength; i++)
                {
                    resultNums.Add(nums1[i]);
                    resultNums.Add(nums2[i]);
                }
                resultNums.AddRange(temp);
            }            
            else
            {
                var temp = nums1.Skip(minLength).ToList();
                for (int j = 0; j < minLength; j++)
                {
                    resultNums.Add(nums1[j]);
                    resultNums.Add(nums2[j]);
                }
                resultNums.AddRange(temp);
            }


            Console.WriteLine(string.Join(" ", resultNums));
        }
    }
}
