using System;
using System.Globalization;
using System.Collections.Generic;

namespace exemplos_produto
{
    class Program
    {
        static void Main(string[] args)
        {
            //Produto p;
            //string nome;
            //double preco;
            //int quantidade;

            //Console.WriteLine("Digite os dados do produto: ");
            //Console.WriteLine("Nome: ");
            //nome = Console.ReadLine();
            //Console.WriteLine("Preço: ");
            //preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Console.WriteLine("Quantidade em estoque: ");
            //quantidade = int.Parse(Console.ReadLine());

            //p = new Produto(nome, preco, quantidade);



            //Console.WriteLine();
            //Console.WriteLine("Dados do produto: " + p);

            //Console.WriteLine();
            //Console.WriteLine("Digite a quantidade de produtos que entraram no estoque: ");
            //p.realizarEntrada(int.Parse(Console.ReadLine()));

            //Console.WriteLine();
            //Console.WriteLine("Dados atualizados: " + p);

            //Console.ReadLine();


            //-----------------------EXEMPLO VETORES


            //int n;
            ////double[] alturas;
            //Produto[] vet;
            //double soma = 0, media = 0;
            //n = int.Parse(Console.ReadLine());
            //vet = new Produto[n];
            //for(int i = 0; i < n; i++)
            //{
            //    vet[i] = new Produto(Console.ReadLine(), double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            //    //alturas[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //    soma += vet[i].preco;
            //}

            //media = soma / n;

            ////Console.WriteLine("ALTURA MÉDIA: " + media.ToString("F2", CultureInfo.InvariantCulture));
            //Console.WriteLine("PREÇO MÉDIO: R$" + media.ToString("F2", CultureInfo.InvariantCulture));
            //Console.ReadLine();



            //-----------------------EXEMPLO MATRIZ

            //int[,] mat; // para declarar matriz com dimensões 2...n usa-se virgula
            //int n, cont = 0;
            //n = int.Parse(Console.ReadLine());
            //mat = new int[n, n]; // matrizes em C# tem de ser instanciadas.

            //for(int i = 0; i < n; i++)
            //{
            //    string[] linha = Console.ReadLine().Split(' ');
            //    for(int j = 0; j < n; j++)
            //    {
            //        mat[i, j] = int.Parse(linha[j]);
            //    }
            //}
            //Console.WriteLine("DIAGONAL PRINCIPAL: ");
            //for(int i = 0; i < n; i++)
            //{
            //    Console.Write(mat[i, i] + " ");
            //}
            //for(int i =0; i < n; i++)
            //{
            //    for(int j = 0; j < n; j++)
            //    {
            //        if(mat[i,j] < 0)
            //        {
            //            cont++;
            //        }
            //    }
            //}
            //Console.WriteLine("\nQUANTIDADE DE NEGATIVOS = " + cont);
            //Console.ReadLine();

            // ----------------AULA SOBRE LISTAS

            //List<string> lista = new List<string>();
            //List<Produto> list = new List<Produto>();
            //lista.Add("joão");
            //lista.Add("guima");
            //lista.Add("cleide");
            //lista.Add("maria");
            //lista.Add("ana");
            //lista.Add("jose");

            //lista.Remove("maria");
            //lista.RemoveAt(0);
            //int pos = lista.FindIndex(x => x == "guima");
            //Console.WriteLine(pos);
            //foreach (var item in lista)
            //{
            //    Console.WriteLine(item);
            //}

            //list.Add(new Produto("TV", 1500.99, 5));
            //list.Add(new Produto("micro-ondas", 500.99, 6));
            //list.Add(new Produto("geladeira", 1250.99, 2));

            //Console.WriteLine(list.FindIndex(x => x.preco < 1250));


            //Console.ReadLine();

            //-----------------Aula SOBRE CONJUNTOS(HASHSET)

            //HashSet<int> a = new HashSet<int>();
            //HashSet<int> b = new HashSet<int>();

            //a.Add(3);
            //a.Add(5);
            //a.Add(8);
            //a.Add(9);

            //b.Add(3);
            //b.Add(4);
            //b.Add(5);

            //b.Add(4); // ele não adiciona o elemento pois já existe um elemento igual ao adicionado.
            //a.ExceptWith(b);// remove os elementos de a que também pertecem a b
            //a.UnionWith(b);// une os elemento de a com de b
            //a.IntersectWith(b); // faz a intersecção dos elemento de a e b
            //foreach (int x in a)
            //{
            //    Console.WriteLine(x);
            //}

            //foreach(int x in b)
            //{
            //    Console.WriteLine(x);
            //}

            //Console.WriteLine("Digite um valor inteiro: ");
            //int n = int.Parse(Console.ReadLine());
            //if (b.Contains(n))
            //{
            //    Console.WriteLine("Pertence");
            //}
            //else
            //{
            //    Console.WriteLine("Não pertence");
            //}

            //--------------------exemplo de associação com outras classes

            Fornecedor f;
            f = new Fornecedor("Lojas LTDA", "lojas@gmail.com", "32112555");
            Produto p = new Produto("TV", 1000.00, f);
            Console.WriteLine(p);

            Console.ReadLine();






        }
    }
}
