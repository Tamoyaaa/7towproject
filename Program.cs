using System.Runtime.Intrinsics.Arm;

namespace _7towproject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            {
                Console.WriteLine("Введите число:");
                number = int.Parse(Console.ReadLine());
            }
            int sum = 0;
            int i = 0;

            while (i <= number)
            {
                sum = sum + i;
                i++;
            }
            Console.WriteLine(sum);
        }
    }
}













/*int sum = 0;

            int number = 10;
            int i = 0;
            while (i <= number)
            {
                sum = sum + i;
                i++;
            }
            Console.WriteLine(sum); */