namespace Two_Sum
{
    class Program
    {
        //https://www.codewars.com/kata/52c31f8e6605bcc646000082/train/csharp

        //Write a function that takes an array of numbers (integers for the tests) and a target number. It should find two different items in the array that, when added together, give the target value. The indices of these items should then be returned in a tuple like so: (index1, index2).

        //For the purposes of this kata, some tests may have multiple answers; any valid solutions will be accepted.

        //The input will always be valid (numbers will be an array of length 2 or greater, and all of the items will be numbers; target will always be the sum of two different items from that array).

        //Based on: http://oj.leetcode.com/problems/two-sum/

        static void Main(string[] args)
        {
            var a = TwoSum(new[] { 1, 2, 3 }, 4);
            var b = TwoSum(new[] { 1234, 5678, 9012 }, 14690);
            var c = TwoSum(new[] { 598, 9, 537, 446, 195, 587, 405, 716, 104, 332 }, 778);
            var y = TwoSum(new[] { 655, 415, 715, 378, 326, 15, 289, 751, 517, 960 }, 304);
            var x = TwoSum(new[] { 0, 3 }, 6);
        }
        
        public static int[] TwoSum(int[] numbers, int target)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int x = 1; x < numbers.Length; x++)
                {
                    if (numbers[i] == 0 && numbers[x] + numbers[x] == target)
                    {
                        return new int[] { numbers[i], numbers[x] };
                    }

                    if (numbers[i] + numbers[x] == target)
                    {
                        return new int[] { i, x };
                    }
                }
            }

            return null;
        }
    }
}