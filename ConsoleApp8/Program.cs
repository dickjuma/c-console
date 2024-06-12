namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to check of its odd or even");
            int a;
            a = int.Parse(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("the number is even");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("The number is odd");
            }
        }
    }
}
