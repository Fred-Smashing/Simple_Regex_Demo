using System.Text.RegularExpressions;

namespace Groups
{
    public static class Groups
    {
        private static Regex rgx = new(@"^urn:(?<groupId>[a-zA-Z0-9\\\-_.~]{0,31}):(?<subId>[a-zA-Z0-9()+,\\\-.:=@;$_!*'%/?#]+)",
            RegexOptions.Compiled | RegexOptions.Multiline);

        private static readonly string input;
        static Groups()
        {
            input = DataFileLoader.LoadAll();
        }

        public static void Group()
        {
            GroupCollection groups = rgx.Match(input).Groups;

            Console.WriteLine($"Groups:");
            foreach (var key in groups.Keys)
            {
                var group = groups[key];
                Console.WriteLine($"\tKey: {key}" +
                    $"\n\t\tSuccess: {group.Success}" +
                    $"\n\t\tValue: {group.Value}" +
                    $"\n\t\tStart Index: {group.Index}" +
                    $"\n\t\tLength: {group.Length}");
            }
        }
    }
}
