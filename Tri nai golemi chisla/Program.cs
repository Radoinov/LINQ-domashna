namespace Tri_nai_golemi_chisla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vavedi chisla:");
            List<double> nums = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            
            var topThree = nums.OrderByDescending(x => x).Take(3).ToList();

            
            Console.WriteLine("Trite naj golemi chisla:");
            foreach (var num in topThree)
            {
                Console.WriteLine(num);
            }
        }
    }
}
