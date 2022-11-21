using CountryAPI;

Console.WriteLine("Welcome!");

string? code;

Console.Write("\nEnter the country ISO code (2 or 3 characters): ");

code = Console.ReadLine();

var message = Validation.Validate(code);

while (message != "Success")
{
    Console.WriteLine(message);
    Console.Write("Enter again: ");
    code = Console.ReadLine();
    message = Validation.Validate(code);
}

var country = await Client.GetCountryAsync(code);

if (country != null)
    country.ShowInfo();
else
    Console.WriteLine("\nCode doesn't exist");



