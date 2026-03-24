namespace Topic_5_assisgnment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //task 1
            int planet;
            string mathOperator1;
            double weight;
            double num1;
            double num2;
            double answer;

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
            else if (planet == 2)
            {
                Console.WriteLine("Your weight on Mars is: " + weight * 0.39 + " pounds");
            }
            else if (planet == 3)
            {
                Console.WriteLine("Your weight on Jupiter is: " + weight * 2.65 + " pounds");
            }
            else if (planet == 4)
            {
                Console.WriteLine("Your weight on Saturn is: " + weight * 1.17 + " pounds");
            }
            else if (planet == 5)
            {
                Console.WriteLine("Your weight on Uranus is: " + weight * 1.05 + " pounds");
            }
            else if (planet == 6)
            {
                Console.WriteLine("Your weight on Neptune is: " + weight * 1.23 + " pounds");
            }
            else 
            {
                Console.WriteLine("Invalid planet. Please retry.");
            }
            Console.WriteLine("Press ENTER to continue.");
            Console.ReadLine();
            Console.Clear();

            //task 2
            Console.WriteLine("Please enter 2 numbers and an operator (+, -, /, *).");
            Console.Write("Enter first number: "); 
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter your operator: ");
            mathOperator1 = Console.ReadLine();
            Console.Write("Enter the second number: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            if (mathOperator1 == "-")
            {
                answer = num1 - num2;
                Console.WriteLine(num1 + " " + mathOperator1 + " " + num2 + " = " + answer);
            }
            else if (mathOperator1 == "+")
            {
                answer = num1 + num2;
                Console.WriteLine(num1 + " " + mathOperator1 + " " + num2 + " = " + answer);
            }
            else if (mathOperator1 == "*")
            {
                answer = num1 * num2;
                Console.WriteLine(num1 + " " + mathOperator1 + " " + num2 + " = " + answer);
            }
            else if (mathOperator1 == "/")
            {
                answer = num1 / num2;
                Console.WriteLine(num1 + " " + mathOperator1 + " " + num2 + " = " + answer);
            }
            Console.WriteLine("Press ENTER to continue.");
            Console.ReadLine();
            Console.Clear();

        }
    }
}
