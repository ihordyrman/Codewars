using System;
using System.Collections.Generic;
using System.Linq;

namespace Directions_Reduction
{
    class Program
    {
        static void Main(string[] args)
        {
            dirReduc(new string[] {"NORTH", "SOUTH", "SOUTH", "EAST", "WEST", "NORTH", "WEST"});
        }
        
        public static string[] dirReduc(string[] arr)
        {
            var newstrings = arr.ToList();
            for (var i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == "NORTH" && arr[i + 1] == "SOUTH" 
                    || arr[i] == "SOUTH" && arr[i + 1] == "NORTH" 
                    || arr[i] == "EAST" && arr[i + 1] == "WEST" 
                    || arr[i] == "WEST" && arr[i + 1] == "EAST")
                {
                    newstrings.RemoveRange(i, 2);
                    return dirReduc(newstrings.ToArray());
                }
            }
            return arr;
        }
    }
}
