using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars4Kyu_
{
    public static class DirectionsReduction
    {
        public static string[] dirReduc(String[] arr)
        {
            Dictionary<string, string> Directions = new Dictionary<string, string>()
            {
                ["NORTH"] = "SOUTH",
                ["EAST"] = "WEST",
                ["SOUTH"] = "NORTH",
                ["WEST"] = "EAST"
            };
            List<string> dir = new List<string>();
            Stack<string> stack = new Stack<string>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (stack.Count != 0 && stack.Pop() == arr[i])
                {
                    dir.Remove(Directions[arr[i]]);
                    continue;
                }
                switch (arr[i])
                {
                    case "NORTH":
                        dir.Add(arr[i]);
                        stack.Push(Directions[arr[i]]);
                        
                        break;
                    case "SOUTH":
                        dir.Add(arr[i]);
                        stack.Push(Directions[arr[i]]);
                        break;

                    case "EAST":
                        dir.Add(arr[i]);
                        stack.Push(Directions[arr[i]]);
                        break;

                    case "WEST":
                        dir.Add(arr[i]);
                        stack.Push(Directions[arr[i]]);
                        break;
                }
            }
            return dir.ToArray();
        }
    }
}
