using System;

namespace ConversorDeMoedasComSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            string op;
            decimal n1, n2, resultado;

            Console.WriteLine("Digite o tipo de moeda que quer converter");
            Console.WriteLine("\nR = Real");
            Console.WriteLine("\nUSR = Dolar");
            op =Console.ReadLine();
            Console.WriteLine("Digite o valor da cotação");
            n1 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor a ser cotado");
            n2 = decimal.Parse(Console.ReadLine());
            
            switch (op)

            {
                case "R":
                    resultado = Somar.Soma(n1, n2);
                    Console.WriteLine($"O resultado é:R${resultado:N2}");
                    break;

                case "USR":
                    resultado = Somar.Soma(n1, n2);
                    Console.WriteLine($"O resultado é:${resultado:N2}");
                    break;

                default:
                    Console.WriteLine("Operaçao Inválida");
                    break;

            }
                
        }
    }
}
