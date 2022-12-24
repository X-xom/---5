1.	namespace _2_ур.__24
2.	{
3.	    internal class Program
4.	    {
5.	        static void men(int[,] a, int jmax)
6.	        {
7.	            int c;
8.	            for (int i = 0; i < a.GetLength(0); i++)
9.	            {
10.	                c = a[i, i];
11.	                a[i, i] = a[i, jmax];
12.	                a[i, jmax] = c;
13.	            }
14.	        }
15.	 
16.	        static int maxx(int[,] a)
17.	        {
18.	            int amax = a[0, 0], jmax = 0;
19.	            for (int i = 0; i < a.GetLength(0); i++)
20.	                for (int j = 0; j < a.GetLength(1); j++)
21.	                {
22.	                    if (a[i, j] > amax)
23.	                    {
24.	                        amax = a[i, j];
25.	                        jmax = j;
26.	                    }
27.	                }
28.	            return jmax;
29.	        }
30.	 
31.	        static void Main(string[] args)
32.	        {
33.	            Console.WriteLine("Введите кол-во строк и столбцов: ");
34.	            int n = int.Parse(Console.ReadLine());
35.	            Console.WriteLine("Введите кол-во строк и столбцов: ");
36.	            int m = int.Parse(Console.ReadLine());
37.	            int[,] a = new int[n, n];
38.	            int[,] b = new int[m, m];
39.	            Random r = new Random();
40.	 
41.	            Console.WriteLine("Изначальная матрица a:");
42.	            for (int i = 0; i < n; i++)
43.	            {
44.	                for (int j = 0; j < n; j++)
45.	                {
46.	                    a[i, j] = r.Next(1, 30);
47.	                    Console.Write(a[i, j] + "\t");
48.	                }
49.	                Console.WriteLine();
50.	            }
51.	            Console.WriteLine("\nИзначальная матрица b:");
52.	            for (int i = 0; i < m; i++)
53.	            {
54.	                for (int j = 0; j < m; j++)
55.	                {
56.	                    b[i, j] = r.Next(1, 30);
57.	                    Console.Write(b[i, j] + "\t");
58.	                }
59.	                Console.WriteLine();
60.	            }
61.	 
62.	            int jmax = maxx(a);
63.	            int jmax1 = maxx(b);
64.	 
65.	            men(a, jmax);
66.	            men(b, jmax1);
67.	 
68.	            Console.WriteLine();
69.	            Console.WriteLine("\nПолученная матрица a:");
70.	            for (int i = 0; i < n; i++)
71.	            {
72.	                for (int j = 0; j < n; j++)
73.	                {
74.	                    Console.Write(a[i, j] + "\t");
75.	                }
76.	                Console.WriteLine();
77.	            }
78.	 
79.	            Console.WriteLine();
80.	            Console.WriteLine("\nПолученная матрица b:");
81.	            for (int i = 0; i < m; i++)
82.	            {
83.	                for (int j = 0; j < m; j++)
84.	                {
85.	                    Console.Write(b[i, j] + "\t");
86.	                }
87.	                Console.WriteLine();
88.	            }
89.	 
90.	        }
91.	 
92.	    }
93.	}
