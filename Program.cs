using System;
using System.Net;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Digite quantos itens vão ter na network");
                int n = Convert.ToInt32(Console.ReadLine());
                var network = new Network(n);

                while (true)
                {
                    Console.WriteLine("Deseja adicionar uma conexão(1) ou verificar dois elementos(2)?");
                    int op = Convert.ToInt32(Console.ReadLine());
                    switch (op)
                    {
                        case 1:
                            Console.WriteLine("Digite um nûmero");
                            int first = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Digite outro");
                            int second = Convert.ToInt32(Console.ReadLine());
                            network.Connect(first, second);
                            Console.WriteLine("Conexão feita entre " + first + " e " + second);
                            break;
                        case 2:
                            Console.WriteLine("Digite um nûmero");
                            int a = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Digite outro");
                            int b = Convert.ToInt32(Console.ReadLine());
                            if (network.Query(a, b)) Console.WriteLine("Está conectado");
                            else Console.WriteLine("Não está conectado");
                            break;
                        default:
                            Console.WriteLine("Entrada inválida");
                            break;
                    }
                }
            }
            catch (Exception ex)
            { 
                Console.WriteLine(ex.Message);
            }
        }
    }
}