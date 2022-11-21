using Xunit;

namespace CountryAPI.Test
{
    public class ValidationTest
    {
        [Fact]
        public void Validate_ReturnsSuccess()
        {
            string input = "md";
            var result = Validation.Validate(input);
            Xunit.Assert.Equal("Success", result);
        }

        [Fact]
        public void Validate_CodeIsNull()
        {
            string? input = null;
            var result = Validation.Validate(input);
            Xunit.Assert.Equal("Enter code please", result);
        }

        [Fact]
        public void Validate_CodeIsEmpty()
        {
            string input = "";
            var result = Validation.Validate(input);
            Xunit.Assert.Equal("Enter code please", result);
        }

        [Fact]
        public void Validate_CodeIsTooShort()
        {
            string input = "a";
            var result = Validation.Validate(input);
            Xunit.Assert.Equal("Code must contain 2 or 3 characters", result);
        }

        [Fact]
        public void Validate_CodeIsTooLong()
        {
            string input = "abcd";
            var result = Validation.Validate(input);
            Xunit.Assert.Equal("Code must contain 2 or 3 characters", result);
        }

        [Fact]
        public void Validate_CodeContainsInvalidCharacters()
        {
            string input = "a.d";
            var result = Validation.Validate(input);
            Xunit.Assert.Equal("Code must contain only letters and digits", result);
        }

        [Fact]
        public void Validate_CodeContainsOnlyDigits()
        {
            string input = "123";
            var result = Validation.Validate(input);
            Xunit.Assert.Equal("Code can't contain only digits", result);
        }
    }
}
