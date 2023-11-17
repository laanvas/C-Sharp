using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;


namespace test
{

    class Produto //tudo referente aos produtos
    {

        public int r;

        public void addProduto()
        {
            Console.WriteLine("Você escolheu para adicionar um produto!\n");
            Console.Write("Digite o nome do produto que deseja adicionar:");
        }

        public void rmProduto()
        {
            Console.WriteLine("Você escolheu para remover um produto!");
            Console.Write("Digite o id do produto que deseja remover:");

        }

    }

    class Cliente : Produto //Tudo referente aos clientes 
    {

        List<int> notas = new List<int>();
        int nota;

        public void questionClient()
        {
            Console.WriteLine("Antes de sair, gostaria de colocar uma avaliação?");
            Console.WriteLine("1 - Sim | Outro numero - Não");
            r = Convert.ToInt32(Console.ReadLine());
            if (r == 1)
            {
                addReview();
            }
            else
            {
                Console.WriteLine("Obrigado por ter usado nosso sistema!!!");
                System.Environment.Exit(1);
            }

        }
        public void addReview()
        {
            Console.Clear();
            for (int s = 0; s <= 1; s++)
            {
                Console.Write("Digite a sua nota: ");
                int nota = Convert.ToInt32(Console.ReadLine());
                notas.Add(nota);
            }
            ViewReview();
        }

        void ViewReview()
        {
            Console.WriteLine("Notas inseridas:");
            foreach (int nota in notas)
            {
                Console.WriteLine(nota);
            }
        }

    }


    class Program : Cliente
        {


            void Menu()
            {
                Console.WriteLine("Bem vindo ao sistema do supermecado\n");
                Console.WriteLine("O que deseja realizar?\n");
                Console.WriteLine("1 - Adicionar produto | 2 - Remover Produto | Qualquer outro numero - Sair\n");
                r = Convert.ToInt32(Console.ReadLine());

                switch (r)
                {
                    case 1:
                        addProduto();
                        break;

                    case 2:
                        rmProduto();
                        break;

                    default:
                        //Console.WriteLine("Obrigado por ter usado o sistema!");
                        questionClient();
                        break;
                }

            }



            static void Main(string[] args)
            {
                Program run = new Program();
                run.Menu();
            }
        }


    }

