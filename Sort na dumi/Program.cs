namespace Sort_na_dumi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vavedi tekst:");
            string input = Console.ReadLine();
            
            char[] separator = new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' };
            
            var result = input
                .ToLower()
                .Split(separator)
                .Where(word => word.Length < 5)
                .Distinct()
                .OrderBy(word => word)
                .ToList();

            
            Console.WriteLine("Dumite po azbuchen red sa:");
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
