using System;

namespace sec11_excecoes_aula
{
    class Program
    {
        static void Main(string[] args)
        {
            //ESTRUTURA TRY CATCH
            try
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int div = n1 / n2;

            }catch(DivideByZeroException e)
            {
                Console.WriteLine("Error! --- " + e.Message + "\n Divide by zero is not alowed");
            }
            catch(FormatException e)
            {
                Console.WriteLine("Format error!");
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
