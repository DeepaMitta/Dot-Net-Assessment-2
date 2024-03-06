using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a few words separated by a space:");
        string input = Console.ReadLine() ?? "";

        string pascalCase = ConvertToPascalCase(input);
        Console.WriteLine("PascalCase Variable Name: " + pascalCase);
    }

    static string ConvertToPascalCase(string input)
    {
        string[] words = input.Split(' ');
        StringBuilder pascalCaseBuilder = new StringBuilder();

        foreach (string word in words)
        {
            if (!string.IsNullOrEmpty(word))
            {
                pascalCaseBuilder.Append(char.ToUpper(word[0]) + word.Substring(1).ToLower());
            }
        }

        return pascalCaseBuilder.ToString();
    }
}
