namespace TASK_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Islam's Carpit Cleaning service");
            Console.WriteLine("Estimate for carpet cleaning service");
            Console.WriteLine("please enter how many small carpit ");
            int smallCarpet = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter how many large carpit ");
            int largeCarpet = Convert.ToInt32(Console.ReadLine());


            double priceAfterTax = ((smallCarpet * 25) + (largeCarpet * 35)) * 1.06;
            Console.WriteLine($"Total estimate is : $ {priceAfterTax:f1}");
            Console.WriteLine($"This estimate is Valid for 30 days");

        }
    }
}
