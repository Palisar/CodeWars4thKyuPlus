using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars4Kyu_
{
    public static class MoveZerosToEnd
    {
        public static int[] MoveZeroes(int[] arr)
        {
            List<int> output = new();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    output.Add(arr[i]);
                }
            }
            int zerosToAdd = arr.Length - output.Count;
            for (int i = 0; i < zerosToAdd ; i++)
            {
                output.Add(0);
            }
            return output.ToArray();
        }
    }
}
