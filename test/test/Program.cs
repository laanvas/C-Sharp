using System;
using System.Drawing;

namespace test
{


    class Program
    {

       

        void GenerateNumbers()
        {

            Random random = new Random();


            Console.WriteLine("Bem vindo ao gerador de números aleatorios");

            Console.WriteLine("Quantos numeros você deseja obter?\n");
            var quant = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o menor numero que você deseja:\n");
            var min = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o maior numero que você deseja:\n");
            var max = Convert.ToInt32(Console.ReadLine());

            while (min > max)
            {
                Console.WriteLine("O valor minimo não pode ser maior que o valor maximo!\n");
                Console.WriteLine("Digite outro valor minimo:\n");
                min = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("O numeros gerados foram:");

            List<int> numeros = new List<int>();
            for (int runs = 0; runs <= quant; runs++)
            {
                var valor = random.Next(min, max);
                numeros.Add(valor);

            }

            foreach (var valor in numeros)
            {
                Console.WriteLine(valor);
            }

            Console.WriteLine($"{quant} numeros foram gerados!");

        }

        static void Main(string[] args)
        {
            Program run = new Program();
            run.GenerateNumbers();
        }

    }

      
    }
