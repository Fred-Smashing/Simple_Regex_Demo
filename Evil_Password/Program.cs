using System.Diagnostics;
using System.Text.RegularExpressions;

namespace Evil_Password
{
    internal class Program
    {
        private static readonly string evilPattern = @"^(([a-z])+.)+[A-Z]([a-z])+$";
        private static readonly string evilPassword = @"aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa!";

        private static Stopwatch sw = new Stopwatch();

        static void Main(string[] args)
        {
            Console.WriteLine("Enter Username:");
            var userName = Console.ReadLine();

            if (userName is null or "")
            {
                userName = evilPattern;
            }

            Console.WriteLine("Enter Password:");
            var password = Console.ReadLine();

            if (password is null or "")
            {
                password = evilPassword;
            }

            sw.Start();

            Regex testPassword = new Regex(userName);
            Match match = testPassword.Match(password);

            Console.WriteLine($"Username: {userName}\nPassword: {password}\nPasword contains Username: {match.Success}\nTime: {sw.Elapsed}");
        }
    }
}