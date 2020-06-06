using System;
using System.Linq;

namespace Domain_name_validator
{
    class Program
    {
        // https://www.codewars.com/kata/5893933e1a88084be10001a3/train/csharp

        // In this kata you have to create a domain name validator mostly compliant with RFC 1035, RFC 1123, and RFC 2181

        //For purposes of this kata, following rules apply:

        // +Domain name may contain subdomains (levels), hierarchically separated by . (period) character
        // +Domain name must not contain more than 127 levels, including top level (TLD)
        // +Domain name must not be longer than 253 characters (RFC specifies 255, but 2 characters are reservedfor trailing dot and null character for root level)
        // +Level names must be composed out of lowercase and uppercase ASCII letters, digits and - (minus sign) character
        // +Level names must not start or end with - (minus sign) character
        // +Level names must not be longer than 63 characters
        // Top level (TLD) must not be fully numerical
        // +Domain name must contain at least one subdomain (level) apart from TLD
        //
        // Top level validation must be naive - ie. TLDs nonexistent in IANA register are still considered valid as long as they adhere to the rules given above.
        // The validation function accepts string with the full domain name and returns boolean value indicating whether the domain name is valid or not.

        // Examples:
        // validate('codewars') == False
        // validate('g.co') == True
        // validate('codewars.com') == True
        // validate('CODEWARS.COM') == True
        // validate('sub.codewars.com') == True
        // validate('codewars.com-') == False
        // validate('.codewars.com') == False
        // validate('example@codewars.com') == False
        // validate('127.0.0.1') == False
        static void Main(string[] args)
        {
            Console.WriteLine(Validate("codewars")); // false
            Console.WriteLine(Validate("g.co")); // true
            Console.WriteLine(Validate("codewars.com")); // true
            Console.WriteLine(Validate("CODEWARS.COM")); // true
            Console.WriteLine(Validate("sub.codewars.com")); // true
            Console.WriteLine(Validate("codewars.com-")); // false
            Console.WriteLine(Validate(".codewars.com")); // false
            Console.WriteLine(Validate("example@codewars.com")); // false
            Console.WriteLine(Validate("127.0.0.1")); // false
        }

        private static bool Validate(string domain)
        {
            var domaints = domain.ToLower().Select(x => (int) x).ToArray();
            var levels = domain.Split('.');
            
            if (domaints.Length > 253) return false;
            if (domaints[0] < 97 || domaints[0] > 122 || domaints[domain.Length - 1] < 97 || domaints[domain.Length - 1] > 122) return false;
            if (!domaints.Contains(46)) return false;
            if (levels.Any(level => level.Length > 63 || level[0] == 45)) return false;
            if (levels.Length > 127) return false;
            if (!domaints.All(t => t == 45 || t == 46 || (t > 96 && t < 123))) return false;
            
            return true;
        }
    }
}