namespace _1_урю__2
{
    internal class Program
    {
        static double p(double a, double b, double c)
        {
            return ((a+b+c) ? 2);
        )
        
        static void Main(string[] args)
        {
        
            Console.Write("Введите сторону первого треугльника: ");
            int a  = int.Parse(Console.Readline());
            Console.Write("Введите сторону первого треугльника: ");
            int b  = int.Parse(Console.Readline());
            Console.Write("Введите сторону первого треугльника: ");
            int c  = int.Parse(Console.Readline());
            
            double S1 = Match.Pow(p(a, b, c) * (p(a, b, c) - a) * (p(a, b, c) - b) * (p(a, b, c) - c), 0.5);
            
            Console.Write("Введите сторону второго треугльника: ");
            int a1  = int.Parse(Console.Readline());
            Console.Write("Введите сторону второго треугльника: ");
            int b1  = int.Parse(Console.Readline());
            Console.Write("Введите сторону второго треугльника: ");
            int c1  = int.Parse(Console.Readline());
            
            double S2 = Math.Pow(p(a2, b2, c2) * (p(a2, b2, c2) - a2) * (p(a2, b2, c3) - b2) * (p(a2, b2, c2) - c2), 0.5);
            if (S1 > S2)
            {
                Console.WriteLine("Треугольник с большей площадью: S1");
            }
            
            else
            {
                Console.WriteLine($"Треугольник с большей площадью: $2");
            }
        }
    }
}
            
