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
            float quant = 1, valor, totalval = 0, totalitens = 0;
            do
            {

                quant++;
                Console.WriteLine("Digite a quantidade do produto,quando quiser terminar digite 0:");
                quant = float.Parse(Console.ReadLine());
                if (quant == 0)
                    break;

                Console.WriteLine("Digite o  valor desses produto :");
                valor = float.Parse(Console.ReadLine());

                totalitens += quant;
                totalval += quant * valor;

            } while (true);
            Console.WriteLine("a quandidade de produtos é:" + totalitens);
            Console.WriteLine("o valor total da suacompra é:" + totalval);


        }
        public static void Exercicio2()
        {
            string nome, nomemaio = "", nomemenor = "";
            int numitens, parada = 2;
            float preco, menor, maior;

            maior = float.MaxValue;
            menor = float.MinValue;

            do
            {
                Console.WriteLine(" entre com o nome do produto");
                nome = Console.ReadLine();

                Console.WriteLine(" entre com o total de itens :");
                numitens = int.Parse(Console.ReadLine());

                Console.WriteLine("entrecom o preço unitario");
                preco = float.Parse(Console.ReadLine());

                float total = numitens * preco;
                if (total > maior)
                {
                    maior = total;
                    nomemaio = nome;

                }
                if (total < menor)
                {
                    menor = total;
                    nomemenor = nome;
                }

                Console.WriteLine(" digite 1 para sair e 2 para continuar: ");
                parada = int.Parse(Console.ReadLine());
                Console.WriteLine("maior quantia investida {0} no produto {1}", maior, nomemaio);
                Console.WriteLine("maior quantia investida {0} no produto {1}", menor, nomemenor);

            } while (parada != 1);


        }
        public static void Exercicio3()
        {
            float pesos, tpesos = 0;
            Console.WriteLine("Digite a quantidade de avaliaçoes que voce fará:");
            int quantavali = int.Parse(Console.ReadLine());

            int c = 1;
            do
            {
                c++;
                Console.WriteLine("Digite os pesos das notas {i}:");
                pesos = float.Parse(Console.ReadLine());
                tpesos += pesos;
            } while (c <= quantavali);
                Console.WriteLine("a soma dos pesos é: " + tpesos);
            if (tpesos < 100)
                Console.WriteLine("Pesos insuficientes");

            else if (tpesos > 100)
                Console.WriteLine("superior a 100% alcansada");


            else
            {
                Console.WriteLine("porcentagem de 100% alcansada");
            }
        }
            
        
        public static void Exercicio4()
        {


            string sigla;
            do
            {

                
                Console.WriteLine("informe a sigla do estado desejado, ou SS para sair:");
                sigla = Console.ReadLine();

                switch (sigla)
                {
                    case "AC":
                        Console.WriteLine("sigla referente ao Acre");
                        break;

                    case "AL":
                        Console.WriteLine("sigla referente ao Alagoas");
                        break;
                    case "AP":
                        Console.WriteLine("sigla referente ao Amapá");
                        break;
                    case "AM":
                        Console.WriteLine("sigla referente ao Amazonas");
                        break;
                    case "BA":
                        Console.WriteLine("sigla referente ao Bahia");
                        break;
                    case "CE":
                        Console.WriteLine("sigla referente ao Ceará");
                        break;
                    case "DF":
                        Console.WriteLine("sigla referente ao Distrito Federal");
                        break;
                    case "ES":
                        Console.WriteLine("sigla referente ao Espirito Santo");
                        break;
                    case "GO":
                        Console.WriteLine("sigla referente ao Goiás");
                        break;
                    case "MA":
                        Console.WriteLine("sigla referente ao Maranhão");
                        break;
                    case "MT":
                        Console.WriteLine("sigla referente ao Mato Grosso");
                        break;
                    case "MS":
                        Console.WriteLine("sigla referente ao Mato Grosso do Sul");
                        break;
                    case "MG":
                        Console.WriteLine("sigla referente ao Minas Gerais");
                        break;
                    case "PA":
                        Console.WriteLine("sigla referente ao Pará");
                        break;
                    case "PB":
                        Console.WriteLine("sigla referente ao Paraíba");
                        break;
                    case "PR":
                        Console.WriteLine("sigla referente ao Paraná");
                        break;
                    case "PE":
                        Console.WriteLine("sigla referente ao Pernambuco");
                        break;
                    case "PI":
                        Console.WriteLine("sigla referente ao Piauí");
                        break;
                    case "Rj":
                        Console.WriteLine("sigla referente ao Rio de Janeiro");
                        break;
                    case "RN":
                        Console.WriteLine("sigla referente ao Rio Grande do Norte");
                        break;
                    case "RS":
                        Console.WriteLine("sigla referente ao Rio Grande do Sul");
                        break;
                    case "RO":
                        Console.WriteLine("sigla referente ao Rondonia");
                        break;
                    case "RR":
                        Console.WriteLine("sigla referente ao Roraima");
                        break;
                    case "SC":
                        Console.WriteLine("sigla referente ao Santa Catarina");
                        break;
                    case "SP":
                        Console.WriteLine("sigla referente ao São Paulo");
                        break;
                    case "SE":
                        Console.WriteLine("sigla referente ao Sergipe");
                        break;
                    case "TO":
                        Console.WriteLine("sigla referente ao Tocantins");
                        break;
                    case "SS":
                        Console.WriteLine("seu programa sera finalizado");
                        break;
                    default:
                        Console.WriteLine("Sigla invalida");
                        break;

                }
            }while (sigla!="SS");
        }
        public static void Exercicio5()
        {
            int mes, dia;
            do
            {


                Console.WriteLine("Digite o numero do mes em que deseja, ou 13 para encerrar:");
                mes = int.Parse(Console.ReadLine());
                switch (mes)
                {
                    case (1):
                        Console.WriteLine("A estação é verão");
                        break;
                    case (2):
                        Console.WriteLine("A estação é verão");
                        break;
                    case (3):
                        Console.WriteLine("me informe o dia:");
                        dia = int.Parse(Console.ReadLine());
                        if (dia >= 20)
                            Console.WriteLine("a estaçao é outono");
                        else
                            Console.WriteLine("A estação é verão");
                        break;
                    case (4):
                        Console.WriteLine("A estação é outono");
                        break;
                    case (5):
                        Console.WriteLine("A estação é outono");
                        break;
                    case (6):
                        Console.WriteLine("me informe o dia:");
                        dia = int.Parse(Console.ReadLine());
                        if (dia >= 20)
                            Console.WriteLine("a estaçao é inverno");
                        else
                            Console.WriteLine("A estação é outono");
                        break;
                    case (7):
                        Console.WriteLine("a estaçao é inverno");
                        break;
                    case (8):
                        Console.WriteLine("a estaçao é inverno");
                        break;
                    case (9):
                        Console.WriteLine("me informe o dia:");
                        dia = int.Parse(Console.ReadLine());
                        if (dia >= 22)
                            Console.WriteLine("a estaçao é primavera");
                        else
                            Console.WriteLine("A estação é inverno");
                        break;
                    case (10):
                        Console.WriteLine("a estaçao é primavera");
                        break;
                    case (11):
                        Console.WriteLine("a estaçao é primavera");
                        break;
                    case (12):
                        Console.WriteLine("me informe o dia:");
                        dia = int.Parse(Console.ReadLine());
                        if (dia >= 21)
                            Console.WriteLine("a estaçao é verão");
                        else
                            Console.WriteLine("A estação é primavera");
                        break;
                    case 13:
                        Console.WriteLine("seu programa esta encerrando");
                        break;
                    default:
                        Console.WriteLine("mes invalido");
                        break;
                }
            }while(mes!= 13);
        }
        public static void Exercicio6()
        {
            float peso, altura, imc;
            do
            {
                Console.WriteLine("informe sua altura, ou 0 para encerrar:");
                altura = float.Parse(Console.ReadLine());
                if (altura != 0)
                {
                    Console.WriteLine("informe o seu peso:");
                    peso = float.Parse(Console.ReadLine());
                    imc = peso / (altura * altura);

                    if (imc < 18.5)
                        Console.WriteLine("esta abaixo do peso");
                    else if (imc == 18.5 && imc == 34.90)
                        Console.WriteLine("Peso normal");
                    else if (imc == 25.0 && imc == 29.9)
                        Console.WriteLine("Sobrepeso");
                    else if (imc == 30.0 && imc == 34.9)
                        Console.WriteLine("obesidade grau 1");
                    else if (imc == 35.0 && imc == 39.9)
                        Console.WriteLine("obesidade de grau 2");
                    else
                        Console.WriteLine("Obesidade de grau 3(morbita)");
                }
            } while (altura != 0);
        }
        public static void Exercicio7()
        {
            int numero;
            Console.WriteLine("digite um numero maior que zero:");
            numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Divisores de " + numero + ":");

            int f = 1;
            do
            {
                f++;
                if (numero % f == 0)
                {
                    Console.WriteLine(f);
                }
            } while (f <= numero);
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
