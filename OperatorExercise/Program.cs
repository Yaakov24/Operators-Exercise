namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        { 
            int a = 17;
            int b = 4;

            var sum = a += b;
            Console.WriteLine(sum);
            var sub = a -= b;
            Console.WriteLine(sub);
            var mult = (a * b);
            Console.WriteLine(mult);
            int quotent = a / b;
            Console.WriteLine(quotent);
            int remainder = a % b;
            Console.WriteLine(remainder);

            Console.WriteLine($"{sum} is the addition of {a} and {b}, \n" +
                $" and {sub} is the subtraction of {a} and {b}, \n"+
                $" and {mult} is the multiplication of {a} and {b}, \n"+
                $" and {quotent} is the division of {a} and {b}, \n" +
                $" and {remainder} is the modulus of {a} and {b}");

            Console.WriteLine("What is the radius of your circle?");
            double radius = double.Parse(Console.ReadLine());
            double answer = AreaOfCircle(radius);
            Console.WriteLine($"The area of circle with radius of {radius} is {answer}");
        }
       public static double AreaOfCircle(double radius)
        {
            double answer = 3.141 * radius * radius;

            return answer;

        }
    }
};
