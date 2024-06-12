namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            Console.WriteLine("enter the first number to compare");
            a=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter The second number to compare");
            b=int.Parse(Console.ReadLine());
            if(a == b)
            {
                Console.WriteLine("the number are equal");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("They are ot equal");
                Console.ReadKey();
            }

        }
    }
}
