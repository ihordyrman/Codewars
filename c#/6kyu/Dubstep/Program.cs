using System;
using System.Linq;

namespace Dubstep
{
    class Program
    {
        static void Main(string[] args)
        {
            SongDecoder("WUBWEWUBAREWUBWUBTHEWUBCHAMPIONSWUBMYWUBFRIENDWUB");
        }

        public static string SongDecoder(string input)
        { 
           return input.Replace("WUB", " ").Trim().Replace("   ", " ").Replace("  ", " ");
        }
    }
}
