1.	namespace _3_ур.__6
2.	{
3.	    class Program
4.	    {
5.	        static void zam(int[,] a, int result1, int result2)
6.	        {
7.	            for (int i = 0; i < a.GetLength(0); i++)
8.	            {
9.	                int c = a[i, result1];
10.	                a[i, result1] = a[i, result2];
11.	                a[i, result2] = c;
12.	            }
13.	        }
14.	 
15.	        delegate int lan(int[,] a, int n);
16.	        delegate int lon(int[,] a, int n);
17.	 
18.	        static int max1(int[,] a, int n)
19.	        {
20.	            int imax = 0, amax = a[0, 0];
21.	            for (int i = 0; i < n; i++)
22.	            {
23.	                if (a[i, i] > amax)
24.	                {
25.	                    amax = a[i, i];
26.	                    imax = i;
27.	                }
28.	            }
29.	 
30.	            return imax;
31.	        }
32.	 
33.	        static int max2(int[,] a, int n)
34.	        {
35.	            int imax = 0, amax = a[0, 0];
36.	            for (int i = 0; i < n; i++)
37.	            {
38.	                if (a[0, i] > amax)
39.	                {
40.	                    amax = a[0, i];
41.	                    imax = i;
42.	                }
43.	            }
44.	            return imax;
45.	        }
46.	 
47.	        static void Main(string[] args)
48.	        {
49.	            Console.WriteLine("Введите кол-во строк и столбцов: ");
50.	            int n = int.Parse(Console.ReadLine());
51.	            int[,] a = new int[n, n];
52.	            Random r = new Random();
53.	            for (int i = 0; i < n; i++)
54.	            {
55.	                for (int j = 0; j < n; j++)
56.	                {
57.	                    a[i, j] = r.Next(1, 30);
58.	                    Console.Write(a[i, j] + "\t");
59.	                }
60.	                Console.WriteLine();
61.	            }
62.	 
63.	            Console.WriteLine();
64.	 
65.	            lan maxx = max1;
66.	            lon maxxx = max2;
67.	            int result1 = maxx(a, n);
68.	            int result2 = maxxx(a, n);
69.	            zam(a, result1, result2);
70.	 
71.	            Console.WriteLine();
72.	 
73.	            for (int i = 0; i < n; i++)
74.	            {
75.	                for (int j = 0; j < n; j++)
76.	                {
77.	                    Console.Write(a[i, j] + "\t");
78.	                }
79.	                Console.WriteLine();
80.	            }
81.	        }
82.	    }
83.	}
