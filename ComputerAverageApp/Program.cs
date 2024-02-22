namespace ComputerAverageApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 5 grades separated by new line: ");
            double grade1 = Convert.ToDouble(Console.ReadLine());
            double grade2 = Convert.ToDouble(Console.ReadLine());
            double grade3 = Convert.ToDouble(Console.ReadLine());
            double grade4 = Convert.ToDouble(Console.ReadLine());
            double grade5 = Convert.ToDouble(Console.ReadLine());

            double sum = grade1 + grade2 + grade3 + grade4 + grade5;
            double totalgrades = sum / 5;
            double average = Math.Round(totalgrades);
            Console.WriteLine("The average is " + totalgrades + " and round off to " + average);


        }
    }
}