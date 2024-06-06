namespace Suma_Min_Max
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vavedi elementi: ");
            int n = int.Parse(Console.ReadLine());

            
            int[] nums = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Vavedi element {i + 1}: ");
                nums[i] = int.Parse(Console.ReadLine());
            }
           
            int sum = nums.Sum();
            int min = nums.Min();
            int max = nums.Max();
            double average = nums.Average();
          
            Console.WriteLine($"Suma: {sum}");
            Console.WriteLine($"Min: {min}");
            Console.WriteLine($"Max: {max}");
            Console.WriteLine($"Average: {average:F2}");
        }
    }
}
