using System;
using System.Collections.Generic;

namespace mod04_exefix05
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, cod;
            Curso A = new Curso("A");
            Curso B = new Curso("B");
            Curso C = new Curso("C");
            Console.Write("O curso " + A.nome_curso + " possui quantos alunos? ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do Curso " + A.nome_curso + ": ");
            for (int i = 0; i < n; i++)
            { 
                A.cods.Add(int.Parse(Console.ReadLine()));
            }
            Console.Write("O curso " + B.nome_curso + " possui quantos alunos? ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do Curso " + B.nome_curso + ": ");
            for (int i = 0; i < n; i++)
            {
                B.cods.Add(int.Parse(Console.ReadLine()));
            }
            Console.Write("O curso " + C.nome_curso + " possui quantos alunos? ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do Curso " + C.nome_curso + ": ");
            for (int i = 0; i < n; i++)
            {
                C.cods.Add(int.Parse(Console.ReadLine()));
            }
            HashSet<int> count = new HashSet<int>();
            count.UnionWith(A.cods);
            count.UnionWith(B.cods);
            count.UnionWith(C.cods);

            Console.WriteLine("Total de alunos: " + count.Count);
            Console.ReadLine();
        }
    }
}
