using System;

namespace N00bify
{
    class Program
    {
        /*
         https://www.codewars.com/kata/552ec968fcd1975e8100005a/

         * The internet is a very confounding place for some adults.
         * Tom has just joined an online forum and is trying to fit in with all the teens and tweens.
         * It seems like they're speaking in another language!
         * Help Tom fit in by translating his well-formatted English into n00b language.

           The following rules should be observed:

           "to" and "too" should be replaced by the number 2,
           even if they are only part of a word (E.g. today = 2day)
           Likewise, "for" and "fore" should be replaced by the number 4
           Any remaining double o's should be replaced with zeros (E.g. noob = n00b)
           "be", "are", "you", "please", "people", "really", "have",
           and "know" should be changed to "b", "r", "u", "plz", "ppl", "rly", "haz",
           and "no" respectively (even if they are only part of the word)
           When replacing words, always maintain case of the first letter
           unless another rule forces the word to all caps.
           The letter "s" should always be replaced by a "z", maintaining case
           "LOL" must be added to the beginning of any input string starting with a "w" or "W"
           "OMG" must be added to the beginning (after LOL, if applicable,) of a string 32 characters1 or longer
           All evenly numbered words2 must be in ALL CAPS (Example: Cake is very delicious. becomes Cake IZ very DELICIOUZ)
           If the input string starts with "h" or "H", the entire output string should be in ALL CAPS
           Periods ( . ), commas ( , ), and apostrophes ( ' ) are to be removed
           3A question mark ( ? ) should have more question marks added to it,
           equal to the number of words2 in the sentence (Example: Are you a foo? has 4 words,
           so it would be converted to r U a F00????)
           3Similarly, exclamation points ( ! ) should be replaced by a series of alternating
           exclamation points and the number 1, equal to the number of words2 in the sentence
           (Example: You are a foo! becomes u R a F00!1!1)
           1 Characters should be counted After: any word conversions,
           adding additional words, and removing punctuation.
           Excluding: All punctuation and any 1's added after exclamation marks ( ! ).
           Character count includes spaces.

           2 For the sake of this kata, "words" are simply a space-delimited substring,
           regardless of its characters. Since the output may have a different number
           of words than the input, words should be counted based on the output string.

           Example: whoa, you are my 123 <3 becomes LOL WHOA u R my 123 <3 = 7 words

           3The incoming string will be punctuated properly, so punctuation does not need to be validated.
         */
        static void Main(string[] args)
        {
            Console.WriteLine(n00bify("Hi, how are you today?")); // "HI HOW R U 2DAY?????"
            Console.WriteLine(n00bify("I think it would be nice if we could all get along.")); // "OMG I think IT would B nice IF we COULD all GET along"
            Console.WriteLine(n00bify("Let's eat, Grandma!")); // "Letz EAT Grandma!1!"
            Console.WriteLine(n00bify("After conversions this should be!")); // "OMG AFTER converzionz THIZ zhould B!1!1!1"
        }

        public static string n00bify(string text)
        {
            var words = text.Split(' ');

            for (var i = 0; i < words.Length; i++)
            {
                if (words[i].Contains("!"))
                {
                    var result = "";

                    for (var j = 0; j < words.Length; j++)
                        result += j % 2 != 0 ? "1" : "!";

                    words[i] = words[i].Replace("!", result);

                    if (string.Join(" ", words).Length > 31)
                        words[i] += words[i].EndsWith("!") ? "1" : "!";

                    if (string.Join(" ", words).StartsWith("w", StringComparison.CurrentCultureIgnoreCase))
                        words[i] += words[i].EndsWith("!") ? "1" : "!";
                };

                words[i] = words[i].Replace("too", "2", StringComparison.CurrentCultureIgnoreCase)
                    .Replace("to", "2", StringComparison.CurrentCultureIgnoreCase)
                    .Replace("oo", "00", StringComparison.CurrentCultureIgnoreCase)
                    .Replace("fore", "4", StringComparison.CurrentCultureIgnoreCase)
                    .Replace("for", "4", StringComparison.CurrentCultureIgnoreCase)
                    .Replace("be", "b", StringComparison.CurrentCultureIgnoreCase)
                    .Replace("are", "r", StringComparison.CurrentCultureIgnoreCase)
                    .Replace("you", "u", StringComparison.CurrentCultureIgnoreCase)
                    .Replace("please", "plz", StringComparison.CurrentCultureIgnoreCase)
                    .Replace("people", "ppl", StringComparison.CurrentCultureIgnoreCase)
                    .Replace("really", "rly", StringComparison.CurrentCultureIgnoreCase)
                    .Replace("have", "haz", StringComparison.CurrentCultureIgnoreCase)
                    .Replace("know", "no", StringComparison.CurrentCultureIgnoreCase)
                    .Replace("s", "z").Replace("S", "Z")
                    .Replace(",", "").Replace(".", "")
                    .Replace("'", "");
            }

            if (text.StartsWith("h", StringComparison.CurrentCultureIgnoreCase))
                for (var i = 0; i < words.Length; i++)
                    words[i] = words[i].ToUpper();

            if (words[0].StartsWith("w", StringComparison.CurrentCultureIgnoreCase))
                words[0] = "LOL " + words[0];

            if (string.Join(" ", words).Length >= 32)
                words[0] = words[0].StartsWith("LOL ")
                    ? words[0].Replace("LOL ", "LOL OMG ")
                    : "OMG " + words[0];

            var newText = string.Join(" ", words)
                .Replace("?", new string('?', words.Length));
            words = newText.Split(" ");

            for (int i = 0; i < words.Length; i++)
                if (i % 2 != 0)
                    words[i] = words[i].ToUpper();

            return string.Join(" ", words);
        }
    }
}