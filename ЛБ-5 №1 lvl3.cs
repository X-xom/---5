1. namespace _3_ур.__1
2.	{
3.	    internal class Program
4.	    {
5.	        delegate double h(double a, double b, double h, double x);
6.	 
7.	        static double fac(double i)
8.	        {
9.	            if(i == 0)
10.	            {
11.	                return 1;
12.	            }
13.	 
14.	            else
15.	            {
16.	                return i * fac(i - 1);
17.	            }
18.	        }
19.	 
20.	        static double sum1(double a, double b, double h, double x)
21.	        {
22.	            double i = 0, n, s = 0;
23.	            for(n = a; n <= b; n = h + n)
24.	            {
25.	                i++;
26.	                s = s + (Math.Cos(i * x) / fac(i));
27.	            }
28.	            return (s + 1);
29.	        }
30.	 
31.	        static double u1(double x)
32.	        {
33.	            double n = Math.Cos(x);
34.	            double u = Math.Exp(n) * Math.Cos(Math.Sin(x));
35.	            return u;
36.	        }
37.	 
38.	        static double sum2(double a, double b, double h, double x)
39.	        {
40.	            double i = 0, n, s = 0;
41.	            for (n = a; n <= b; n = h + n)
42.	            {
43.	                i++;
44.	                s = s + (Math.Pow(-1, i) * (Math.Cos(i * x) / Math.Pow(i, 2)));
45.	            }
46.	            return s;
47.	        }
48.	 
49.	        static double u2(double x, double pi)
50.	        {
51.	            double u = (Math.Pow(x, 2) - (Math.Pow(pi, 2) / 3)) / 4;
52.	            return u;
53.	        }
54.	 
55.	        static void Main(string[] args)
56.	        {
57.	            Console.WriteLine("Введите значение x: ");
58.	            int x = int.Parse(Console.ReadLine());
59.	            double s1, a1 = 0.1, b1 = 1, h1 = 0.1, y1;
60.	            const double pi = 3.14;
61.	            double a2 = pi / 5, b2 = pi, h2 = pi / 25, s2, y2;
62.	 
63.	            h su1 = sum1;
64.	            h su2 = sum2;
65.	            s1 = su1(a1, b1, h1, x);
66.	            s2 = su2(a2, b2, h2, x);
67.	            y1 = u1(x);
68.	            y2 = u2(x, pi);
69.	            Console.WriteLine($"Первая сумма равна: {s1}");
70.	            Console.WriteLine($"Вторая сумма равна: {s2}");
71.	            Console.WriteLine($"y1 = {y1}");
72.	            Console.WriteLine($"y2 = {y2}");
73.	        }
74.	    }
75.	}
