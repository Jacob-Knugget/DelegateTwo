namespace Assignment8ex2
{
    public class MathSolutions
    {

        public delegate double Product(double x, double y);

        public double GetSum(double x, double y)
        {
            return x + y;
        }
        public double GetProduct(double a, double b)
        {
            return a * b;
        }
        public void GetSmaller(double a, double b)
        {
            if (a < b)
                Console.WriteLine($" {a} is smaller than {b}");
            else if (b < a)
                Console.WriteLine($" {b} is smaller than {a}");
            else
                Console.WriteLine($" {b} is equal to {a}");
        }
        static void Main(string[] args)
        {
            // create a class object
            MathSolutions answer = new MathSolutions();
            // custom delegate
            Product p = new Product(answer.GetProduct);
            Random r = new Random();
            double num1 = Math.Round(r.NextDouble() * 100);
            double num2 = Math.Round(r.NextDouble() * 100);
            // function delegate
            Func<double, double, double> addition = answer.GetSum;
            Console.WriteLine($" {num1} + {num2} = {addition(num1, num2)}");
            // custom delegate
            Console.WriteLine($" {num1} * {num2} = {p(num1, num2)}");
            // action delegate
            Action<double, double> findSmall = answer.GetSmaller;
            findSmall(num1, num2);
        }
    }
}