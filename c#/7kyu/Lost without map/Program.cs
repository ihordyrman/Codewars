using System.Linq;

namespace Lost_without_map
{
    internal static class Program
    {
        private static void Main()
        {
            Maps(new[] {1, 2, 3});
        }

        private static int[] Maps(int[] x)
        {
            return x.Select(z => z * 2).ToArray();
        }
    }
}
