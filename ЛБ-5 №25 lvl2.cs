1.	namespace _2_ур.__25
2.	{
3.	    internal class Program
4.	    {
5.	        static int kol(int n, int m, int[,] a)
6.	        {
7.	            int k, imax = 0, maxx = 0;
8.	            for (int i = 0; i < n; i++)
9.	            {
10.	                k = 0;
11.	                for (int j = 0; j < m; j++)
12.	                {
13.	                    if (a[i, j] < 0)
14.	                    {
15.	                        k = k + 1;
16.	                    }
17.	                }
18.	 
19.	                if (k > maxx)
20.	                {
21.	                    maxx = k;
22.	                    imax = i;
23.	                }
24.	            }
25.	            return imax;
26.	        }
27.	 
28.	        static void Main(string[] args)
29.	        {
30.	            Console.WriteLine("Введите кол-во строк: ");
31.	            int n = int.Parse(Console.ReadLine());
32.	            Console.WriteLine("Введите кол-во столбцов: ");
33.	            int m = int.Parse(Console.ReadLine());
34.	            Console.WriteLine("Введите кол-во строк: ");
35.	            int u = int.Parse(Console.ReadLine());
36.	            Console.WriteLine("Введите кол-во столбцов: ");
37.	            int y = int.Parse(Console.ReadLine());
38.	            int[,] a = new int[n, m];
39.	            int[,] b = new int[u, y];
40.	            Random r = new Random();
41.	            for (int i = 0; i < n; i++)
42.	            {
43.	                for (int j = 0; j < m; j++)
44.	                {
45.	                    a[i, j] = r.Next(-20, 20);
46.	                    Console.Write(a[i, j] + "\t");
47.	                }
48.	                Console.WriteLine();
49.	            }
50.	 
51.	            Console.WriteLine();
52.	 
53.	            for (int i = 0; i < u; i++)
54.	            {
55.	                for (int j = 0; j < y; j++)
56.	                {
57.	                    b[i, j] = r.Next(-20, 20);
58.	                    Console.Write(b[i, j] + "\t");
59.	                }
60.	                Console.WriteLine();
61.	            }
62.	 
63.	            Console.WriteLine();
64.	 
65.	            int imax1 = kol(n, m, a);
66.	            int imax2 = kol(u, y, b);
67.	 
68.	            Console.WriteLine($"Строка с максималным кол-ом отрицательных элементов" +
69.	                $"первой матрицы {imax1}");
70.	            Console.WriteLine();
71.	            Console.WriteLine($"Строка с максималным кол-ом отрицательных элементов" +
72.	                $"второй матрицы {imax2}");
73.	        }
74.	    }
75.	}
