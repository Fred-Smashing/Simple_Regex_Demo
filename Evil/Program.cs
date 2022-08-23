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
            sw.Start();
            Console.WriteLine($"Input: aaaaX\nSuccess: {rgx.Match("aaaaX").Success}\nTime: {sw.Elapsed.TotalMilliseconds}ms");

            sw.Restart();
            Console.WriteLine($"\nInput: aaaaaaaaaaaaaaaaX\nSuccess{rgx.Match("aaaaaaaaaaaaaaaaX ").Success}\nTime: {sw.Elapsed.TotalMilliseconds}ms");
        }
    }
}