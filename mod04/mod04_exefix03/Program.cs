using System;

namespace mod04_exefix03
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m, op;
            int[,] matriz;
            string[] input;

            input = Console.ReadLine().Split(' ');
            n = int.Parse(input[0]);
            m = int.Parse(input[1]);
            matriz = new int[n, m];
            for(int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split(' ');
                for(int j = 0; j < m; j++)
                {
                    matriz[i, j] = int.Parse(input[j]);
                }
            }
            op = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    if(op == matriz[i,j])
                    {
                        if (!(j - 1 < 0))
                        {
                            Console.WriteLine("Esquerda: " + matriz[i, j - 1]);
                        }
                        if (!(i - 1 < 0))
                        {
                            Console.WriteLine("Acima: " + matriz[i - 1, j]);
                        }
                        if(!(j + 1 >= m))
                        {
                            Console.WriteLine("Direita: " + matriz[i, j + 1]);
                        }
                        if(!(i + 1 >= n))
                        {
                            Console.WriteLine("Abaixo: " + matriz[i + 1, j]);
                        }
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
