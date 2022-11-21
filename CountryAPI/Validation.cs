namespace CountryAPI
{
    public class Validation
    {
        public static string Validate(string? input)
        {
            if (string.IsNullOrEmpty(input))
                return "Enter code please";
            if (input.Length < 2 || input.Length > 3)
                return "Code must contain 2 or 3 characters";
            if (!input.All(char.IsLetterOrDigit))
                return "Code must contain only letters and digits";
            if (input.All(char.IsDigit))
                return "Code can't contain only digits";
            return "Success";
        }
    }
}
