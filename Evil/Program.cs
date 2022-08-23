using System.Diagnostics;
using System.Text.RegularExpressions;

namespace Evil
{
    internal class Program
    {
        private static Regex rgx = new(@"^(a+)+&");

        private static Stopwatch sw = new Stopwatch();

        static void Main(string[] args)
        {
            var input = "aaaaX";
            sw.Start();
            Console.WriteLine($"Input: {input}\nSuccess: {rgx.Match(input).Success}\nTime: {sw.Elapsed.TotalMilliseconds}ms");

            input = "aaaaaaaaaaaaaaaaX";
            sw.Restart();
            Console.WriteLine($"\nInput: {input}\nSuccess: {rgx.Match(input).Success}\nTime: {sw.Elapsed.TotalMilliseconds}ms");

            input = "aaaaaaaaaaaaaaaaaaaaX";
            sw.Restart();
            Console.WriteLine($"\nInput: {input}\nSuccess: {rgx.Match(input).Success}\nTime: {sw.Elapsed.TotalMilliseconds}ms");

            input = "aaaaaaaaaaaaaaaaaaaaaaX";
            sw.Restart();
            Console.WriteLine($"\nInput: {input}\nSuccess: {rgx.Match(input).Success}\nTime: {sw.Elapsed.TotalMilliseconds}ms");
        }
    }
}