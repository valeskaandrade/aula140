using System;

namespace TesteTryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());
                int result = n1 / n2;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Divisão por zero");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Erro de formatação: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }

        }
    }
}
