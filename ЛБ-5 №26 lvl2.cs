1.	namespace _2_ур.__26
2.	{
3.	    internal class Program
4.	    {
5.	        static void men(int[,] a, int[,] b, int imax1, int imax2)
6.	        {
7.	            int c;
8.	            for (int j = 0; j < a.GetLength(0); j++)
9.	            {
10.	                c = a[imax1, j];
11.	                a[imax1, j] = b[imax2, j];
12.	                b[imax2, j] = c;
13.	            }
14.	        }
15.	 
16.	        static int maxx(int[,] a)
17.	        {
18.	            int k, imax = 0, maxx = 0;
19.	            for (int i = 0; i < a.GetLength(0); i++)
20.	            {
21.	                k = 0;
22.	                for(int j = 0; j < a.GetLength(1); j++)
23.	                {
24.	                    if (a[i,j] < 0)
25.	                    {
26.	                        k++;
27.	                    }
28.	                }
29.	 
30.	                if(k > maxx)
31.	                {
32.	                    maxx = k;
33.	                    imax = i;
34.	                }
35.	            }
36.	 
37.	            return imax;
38.	        }
39.	 
40.	 
41.	        static void Main(string[] args)
42.	        {
43.	            Console.WriteLine("Введите кол-во строк: ");
44.	            int n = int.Parse(Console.ReadLine());
45.	            Console.WriteLine("Введите кол-во столбцов: ");
46.	            int m = int.Parse(Console.ReadLine());
47.	            Console.WriteLine("Введите кол-во строк: ");
48.	            int u = int.Parse(Console.ReadLine());
49.	            Console.WriteLine("Введите кол-во столбцов: ");
50.	            int y = int.Parse(Console.ReadLine());
51.	            int[,] a = new int[n, m];
52.	            int[,] b = new int[u, y];
53.	            Random r = new Random();
54.	            Console.WriteLine("Исходная матрица: ");
55.	            for (int i = 0; i < n; i++)
56.	            {
57.	                for (int j = 0; j < m; j++)
58.	                {
59.	                    a[i, j] = r.Next(-20, 20);
60.	                    Console.Write(a[i, j] + "\t");
61.	                }
62.	                Console.WriteLine();
63.	            }
64.	 
65.	            Console.WriteLine();
66.	 
67.	            Console.WriteLine("Исходная матрица: ");
68.	            for (int i = 0; i < u; i++)
69.	            {
70.	                for (int j = 0; j < y; j++)
71.	                {
72.	                    b[i, j] = r.Next(-20, 20);
73.	                    Console.Write(b[i, j] + "\t");
74.	                }
75.	                Console.WriteLine();
76.	            }
77.	 
78.	            Console.WriteLine();
79.	            int imax1 = maxx(a);
80.	            int imax2 = maxx(b);
81.	            men(a, b, imax1, imax2);
82.	            Console.WriteLine();
83.	            Console.WriteLine("Полученная матрица: ");
84.	            for (int i = 0; i < n; i++)
85.	            {
86.	                for (int j = 0; j < m; j++)
87.	                {
88.	                    Console.Write(a[i, j] + "\t");
89.	                }
90.	                Console.WriteLine();
91.	            }
92.	 
93.	            Console.WriteLine();
94.	            Console.WriteLine("Полученная матрица: ");
95.	            for (int i = 0; i < u; i++)
96.	            {
97.	                for (int j = 0; j < y; j++)
98.	                {
99.	                    Console.Write(b[i, j] + "\t");
100.	                }
101.	                Console.WriteLine();
102.	            }
103.	        }
104.	    }
105.	}
