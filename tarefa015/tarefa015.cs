using System.Text.RegularExpressions;

namespace ExSenha
{
public static class Program
{
static void Main(string[] args)
{
Regex reLogin = new("^(?=.*[A-z])(?=.*[0-9])(?=.*[@!#$%^&*.~()\\])[@!#$%^&*.~()\\a-zA-Z0-9]{5,30}$", RegexOptions.Compiled);
Regex rePassw = new("^(?=.*[A-Z])(?=.*[0-9])(?=.*[@!#$%^&*.~()\\])[@!#$%^&*.~()\\a-zA-Z0-9]{8,12}$", RegexOptions.Compiled);

string? login = Console.ReadLine();
string? senha = Console.ReadLine();
}
}
}