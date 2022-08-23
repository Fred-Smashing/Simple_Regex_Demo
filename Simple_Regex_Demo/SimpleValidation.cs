using System.Configuration;

namespace SimpleValidation
{
    public static class Validator
    {
        private static readonly RegexStringValidator simpleValidator = new(@"^urn:[a-zA-Z0-9\\\-_.~]{0,31}:[a-zA-Z0-9()+,\\\-.:=@;$_!*'%/?#]+$");

        public static void Validate()
        {
            var input = DataFileLoader.LoadLine();

            if (!simpleValidator.CanValidate(input.GetType()))
            {
                Console.WriteLine($"Validator cannot validate type of {input.GetType()}");
                return;
            }

            try
            {
                simpleValidator.Validate(input);
                Console.WriteLine($"Input {input} is valid");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Input {input} was not valid\n");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
