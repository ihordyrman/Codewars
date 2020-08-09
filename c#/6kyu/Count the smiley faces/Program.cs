using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Count_the_smiley_faces
{
    /*
     * Given an array (arr) as an argument complete the function countSmileys that should return the total number of smiling faces.
     * Rules for a smiling face:
     *
     * Each smiley face must contain a valid pair of eyes. Eyes can be marked as : or ;
     * A smiley face can have a nose but it does not have to. Valid characters for a nose are - or ~
     * Every smiling face must have a smiling mouth that should be marked with either ) or D
     * No additional characters are allowed except for those mentioned.
     *
     * Valid smiley face examples: :) :D ;-D :~)
     * Invalid smiley faces: ;( :> :} :]
     */
    class Program
    {
        static void Main()
        {
            Console.WriteLine(CountSmileys(new string[] { ":D", ":~)", ";~D", ":)" })); // 4
            Console.WriteLine(CountSmileys(new string[] { ":)", ":(", ":D", ":O", ":;" })); // 2
            Console.WriteLine(BetterCountSmileys(new string[] { ";]", ":[", ";*", ":$", ";-D" })); // 1
            Console.WriteLine(AnotherCountSmileys(new string[] { ";", ")", ";*", ":$", "8-D" })); // 0
        }

        public static int BetterCountSmileys(string[] smileys)
        {
            return smileys.Count(x => Regex.IsMatch(x, @"[:;][\-~]?[\)D]"));
        }

        public static int CountSmileys(string[] smileys)
        {

            if (smileys == null || smileys.Length == 0)
                return 0;

            int count = 0;

            foreach (var smile in smileys)
            {
                if (smile.Length < 2 || smile.Length > 3) continue;
                if (smile[0] != ':' && smile[0] != ';') continue;

                if (smile.Length == 2 && smile[1] == ')' || smile.Length == 2 && smile[1] == 'D')
                {
                    count++;
                    continue;
                }
                else
                {
                    if (smile.Length != 3) continue;
                    if ((smile[2] == ')' || smile[2] == 'D') && (smile[1] == '-' || smile[1] == '~'))
                        count++;
                }
            }

            return count;
        }

        public static int AnotherCountSmileys(string[] smileys) => 
            smileys.Count(s => new string[] { ":)", ";)", ":D", ";D", ":-)", ":-D", ":~)", ":~D", ";-)", ";~)", ";-D", ";~D" }.Contains(s));
    }
}
