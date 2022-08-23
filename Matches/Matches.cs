using System.Text.RegularExpressions;

namespace Matches
{
    public static class Matches
    {
        private static Regex rgx = new(@"^urn:[a-zA-Z0-9\\\-_.~]{0,31}:[a-zA-Z0-9()+,\\\-.:=@;$_!*'%/?#]+",
            RegexOptions.Compiled | RegexOptions.Multiline);

        private static readonly string input;
        static Matches()
        {
            input = DataFileLoader.LoadAll();
        }

        public static void IsMatch()
        {
            var singleLine = DataFileLoader.LoadLine();
            Console.WriteLine("Single Match:");
            Console.WriteLine($"\t{singleLine} Is Match: {rgx.IsMatch(singleLine)}");
        }

        public static void MatchCollection()
        {
            var matches = rgx.Matches(input);

            Console.WriteLine("\nMatch Collection:");
            foreach (Match match in matches)
            {
                Console.WriteLine($"\t{match.Value} Is Match: {match.Success}");
            }
        }

        public static void MatchArray()
        {
            var currentMatch = rgx.Match(input);

            List<Match> matchList = new List<Match>();
            while (currentMatch.Success)
            {
                matchList.Add(currentMatch);
                currentMatch = currentMatch.NextMatch();
            }

            var matchArray = matchList.ToArray();

            Console.WriteLine("\nGetting Matches as an Array:");
            foreach (var match in matchArray)
            {
                Console.WriteLine($"\t{match.Value} Is Match: {match.Success}");
            }
        }

        public static void MatchInformation()
        {
            var match = rgx.Match(input);

            Console.WriteLine("\nMatch Informaton");

            Console.WriteLine($"\tCapture Collection: {match.Captures}");
            Console.WriteLine($"\tGroup Collection: {match.Groups}");
            Console.WriteLine($"\tStart Index: {match.Index}");
            Console.WriteLine($"\tLength: {match.Length}");
            Console.WriteLine($"\tName: {match.Name}");
            Console.WriteLine($"\tValue: {match.Value}");
            Console.WriteLine($"\tValue Span: {match.ValueSpan}");
        }
    }
}
