namespace Topic_5_assisgnment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //task 1
            int planet;
            double weight;

            Console.Write("Enter your current weight: ");
            weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("I have information on the following planets: ");
            Console.WriteLine("1. Venus");
            Console.WriteLine("2. Mars");
            Console.WriteLine("3. Jupiter");
            Console.WriteLine("4. Saturn");
            Console.WriteLine("5. Uranus");
            Console.WriteLine("6. Neptune");
            Console.Write("Enter the number of the planet you'll be visiting: ");
            planet = Convert.ToInt32(Console.ReadLine());
            if (planet == 1)
            {
                Console.WriteLine("Your weight on Venus is: " + weight*0.78 + " pounds");
            }
            if (planet == 2)
            {
                Console.WriteLine("Your weight on Mars is: " + weight * 0.39 + " pounds");
            }
            if (planet == 3)
            {
                Console.WriteLine("Your weight on Jupiter is: " + weight * 2.65 + " pounds");
            }
            if (planet == 4)
            {
                Console.WriteLine("Your weight on Saturn is: " + weight * 1.17 + " pounds");
            }
            if (planet == 5)
            {
                Console.WriteLine("Your weight on Uranus is: " + weight * 1.05 + " pounds");
            }
            if (planet == 6)
            {
                Console.WriteLine("Your weight on Neptune is: " + weight * 1.23 + " pounds");
            }
            else if (planet > 6)
            {
                Console.WriteLine("Invalid planet. Please retry.");
            }
            else if (planet < 1)
            {
                Console.WriteLine("Invalid planet. Please retry.");
            }

            //task 2

            Console.WriteLine();
        }
    }
}
