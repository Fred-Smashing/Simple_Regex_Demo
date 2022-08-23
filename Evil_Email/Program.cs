using System.Diagnostics;
using System.Text.RegularExpressions;

namespace Evil_Email
{
    internal class Program
    {
        // Pattern taken from https://regexlib.com/REDetails.aspx?regexp_id=1757
        private static Regex rgx = new(@"^([a-zA-Z0-9])(([\-.]|[_]+)?([a-zA-Z0-9]+))*(@){1}[a-z0-9]+[.]{1}(([a-z]{2,3})|([a-z]{2,3}[.]{1}[a-z]{2,3}))$");

        private static Stopwatch sw = new Stopwatch();

        static void Main(string[] args)
        {
            var input = "aaaaaaaaaaaaaaaaaaaaaaaaaaaa!";

            sw.Start();
            Console.WriteLine($"Input: {input}\n {rgx.Match(input)}\nTime: {sw.Elapsed}");
        }
    }
}