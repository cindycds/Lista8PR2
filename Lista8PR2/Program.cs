using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista8PR2
{
    internal class Program


    {

        public static void Exercicio1()
        {


        }
        public static void Exercicio2()
        {

        }
        public static void Exercicio3()
        {

        }
        public static void Exercicio4()
        {

        }
        public static void Exercicio5()
        {

        }
        public static void Exercicio6()
        {

        }
        public static void Exercicio7()
        {

        }

        static void Main(string[] args)
        {
            int menuzin;
            do
            {
                Console.WriteLine("========MENU=========");
                Console.WriteLine("Digite 0 para sair");
                Console.WriteLine("exercicio 1");
                Console.WriteLine("exercicio 2");
                Console.WriteLine("exercicio 3");
                Console.WriteLine("exercicio 4");
                Console.WriteLine("exercicio 5");
                Console.WriteLine("exercicio 6");
                Console.WriteLine("exercicio 7");

                menuzin = int.Parse(Console.ReadLine());

                switch (menuzin)
                {
                    case 0: Console.WriteLine("Obrigada por utilizar o sistema");
                        break;
                    case 1:
                        Exercicio1();
                        break;
                    case 2:
                        Exercicio2();
                        break;
                    case 3:
                        Exercicio3();
                        break;
                    case 4:
                        Exercicio4();
                        break;
                    case 5:
                        Exercicio5();
                        break;
                    case 6:
                        Exercicio6();
                        break;
                    case 7:
                        Exercicio7();
                        break;

                        default:
                        Console.WriteLine("Exercicio invalido");
                        break;
                }
                

            }while (menuzin !=0);
        }
    }
}
