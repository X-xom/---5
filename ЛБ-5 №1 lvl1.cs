namespace _1_урю__1
{
    internal class Program
    {
        static int fact(int n)
        {
            int f = 1;
            for (int i= 1; i <= n; i++)
            {
                f *= i;
            {
            return f;
        }
    
        static int C(int n, int k)
        {
            return (fact(n) / (fact(k) * fact(n-k)));
        }

        static void Main(string[] args)
        {
            Console.WriteLine($"8 кандидатов: {C(8, 5)}");
            Console.WriteLine($"10 кандидатов: {C(10, 5)}");
            Console.WriteLine($"11 кандидатов: {C(11, 5)}");
        }
    }
}
