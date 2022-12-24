namespace _2_ур.__3
{

    internal class Program
    {
    
        static void Main(string[] args)
        {
            double s(double v, double a, double t)
            {
                return ((V* t) + (a* Math.Pow(t, 2) / 2));
            }

            IF (S(10,1,1) > S(9, 1.6, 1))
            {
                Console.Writeline('a) большее расстояние за 1 час преодолеет " + "первый велосипед");
            }
            else
            {
                Console.Writeline('a) большее расстояние за 1 час преодолеет " + "второй велосипед");
            }

            if (s(10, 1, 4) > s(9, 1.6, 4))
            {
                Console.WriteLine('большее расстояние за 4 часа преодолеет преодолеет " + "первый велосепедист");
            }

            for (double i = 1; i< 10; i += 0.0001)
            {
                if (s(10, 1, i) < s(9, 1.6, i))
                {
                    Console.WriteLine($"6) второй велосипедсит догонит первого через {i} ");
                    break;
                }
            }
        }
    }
}

        
            
