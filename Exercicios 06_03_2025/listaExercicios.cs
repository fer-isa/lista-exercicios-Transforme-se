using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_06_03_2025
{
    internal class listaExercicios
    {
        public void Exercicio01()

        {
            //Console.WriteLine("exercicio 01");
            int valor;

            Console.WriteLine("Digite um número: ");
            valor = Convert.ToInt32(Console.ReadLine());

            if (valor > 100)
            {
                Console.WriteLine("O número é maior que 100");
            }
            else if (valor == 100)
            {
                Console.WriteLine("O número é 100");
            }
            else
            {
                Console.WriteLine("O número é menor que 100");
            }

            Console.WriteLine("--------------------------------------------------------------");

        }



        public void Exercicio02()
        {
            //Console.WriteLine("Exercicio 02");

            int totalVotos, votosEmBranco, votosNulos, votosValidos;


            Console.WriteLine("Digite a quantidade de votos em branco: ");
            votosEmBranco = Convert.ToInt32(Console.ReadLine());




            Console.WriteLine("Digite a quantidade de votos nulos: ");
            votosNulos = Convert.ToInt32(Console.ReadLine());




            Console.WriteLine("Digite a quantidade de votos válidos: ");
            votosValidos = Convert.ToInt32(Console.ReadLine());

            totalVotos = votosEmBranco + votosNulos + votosValidos;

            Console.WriteLine("Resultados: ");

            Console.WriteLine(votosEmBranco * 100 / totalVotos + "% de votos em branco");
            Console.WriteLine(votosNulos * 100 / totalVotos + "% de votos Nulos");
            Console.WriteLine(votosValidos * 100 / totalVotos + "% de votos válidos");


            Console.WriteLine("--------------------------------------------------------------");



        }


        public void Exercicio03(int n1)
        {

            //Console.WriteLine("Exercicio 03");

            int n2;


            Console.WriteLine("Digite um  número: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            if (n1 > n2)
            {
                Console.WriteLine("O número é maior");
            }
            else
            {
                Console.WriteLine("O número é menor");
            }

            Console.WriteLine("--------------------------------------------------------------");


        }

        public void Exercicio04()
        {
            //Console.WriteLine("exercicio 04");
            int valor1, valor2;
            Console.WriteLine("Digite o primeiro número: ");
            valor1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o primeiro número: ");
            valor2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("O maior dos dois valores é: " + Math.Max(valor1, valor2));


            Console.WriteLine("--------------------------------------------------------------");

        }



        public void Exercicio05()
        {
            //Console.WriteLine("exercicio 05");

            int valor1, valor2;
            Console.WriteLine("Digite o primeiro número: ");
            valor1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o primeiro número: ");
            valor2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("O menor dos dois valores é: " + Math.Min(valor1, valor2));


            Console.WriteLine("--------------------------------------------------------------");

        }


        public void Exercicio06()
        {

            //Console.WriteLine("exercicio 06");

            int n1, n2, n3, resultado;

            Console.WriteLine("digite o primeiro número: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("digite o segundo  número: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("digite o terceiro número: ");
            n3 = Convert.ToInt32(Console.ReadLine());

            resultado = n1 + n2 + n3;

            Console.WriteLine("O resultado da soma do números é:  " + resultado);

            Console.WriteLine("--------------------------------------------------------------");
        }


        public void Exercicio07(int parametro1, int parametro2)
        {


            //Console.WriteLine("Exercicio 07");

            int maiorNumero, menorNumero, valorUsuario;

            maiorNumero = Math.Max(parametro1, parametro2);
            menorNumero = Math.Min(parametro1, parametro2);

            Console.WriteLine("Digite um valor: ");
            valorUsuario = Convert.ToInt32(Console.ReadLine());

            if ((valorUsuario < maiorNumero) && (valorUsuario > menorNumero))
            {
                Console.WriteLine("O valor esta dentro do intervalo");
            }
            else
            {
                Console.WriteLine("O valor não esta dentro do intervalo");
            }

            Console.WriteLine("--------------------------------------------------------------");

        }

        public void Exercicio08(int valor)
        {
            //Console.WriteLine("exercicio 08");

            Console.WriteLine("Digite um valor: ");
            valor = Convert.ToInt32(Console.ReadLine());

            if (valor % 2 == 0)
            {
                Console.WriteLine("O número é Par");
            }
            else
            {
                Console.WriteLine("O número é Impar");
            }

            Console.WriteLine("--------------------------------------------------------------");

        }

        public void Exercicio09()
        {

            
            double nota1, nota2, nota3, nota4;

            Console.WriteLine("Digite a 1° nota: ");
            nota1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a 2° nota: ");
            nota2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a 3° nota: ");
            nota3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a 4° nota: ");
            nota4 = Convert.ToDouble(Console.ReadLine());

            double media = (nota1 + nota2 + nota3 + nota4) / 4;


            if (media >= 7.5)
            {
                Console.WriteLine("A média das notas é " + media + ". O estudante está aprovado.");
            }
            else
            {
                Console.WriteLine("A média das notas é " + media + ". O estudante está reprovado.");
            }

            Console.WriteLine("--------------------------------------------------------------");
        }






        public void Menu()
        {
            string opcao;

            do
            {
                Console.WriteLine("--- Menu ---");
                Console.WriteLine("1. Exercício 01");
                Console.WriteLine("2. Exercício 02");
                Console.WriteLine("3. Exercício 03");
                Console.WriteLine("4. Exercício 04");
                Console.WriteLine("5. Exercício 05");
                Console.WriteLine("6. Exercício 06");
                Console.WriteLine("7. Exercício 07");
                Console.WriteLine("8. Exercício 08");
                Console.WriteLine("9. Exercício 09");
                Console.WriteLine("0. Sair");
                Console.Write("Escolha uma opção: ");

                
                opcao = Console.ReadLine();

                
                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("Executando Exercício 01...");
                        Exercicio01();
                        break;
                    case "2":
                        Console.WriteLine("Executando Exercício 02...");
                        Exercicio02();
                        break;
                    case "3":
                        Console.WriteLine("Executando Exercício 03...");
                        Exercicio03(15);
                        break;
                    case "4":
                        Console.WriteLine("Executando Exercício 04...");
                        Exercicio04();
                        break;
                    case "5":
                        Console.WriteLine("Executando Exercício 05...");
                        Exercicio05();
                        break;
                    case "6":
                        Console.WriteLine("Executando Exercício 06...");
                        Exercicio06();
                        break;
                    case "7":
                        Console.WriteLine("Executando Exercício 07...");
                        Exercicio07(10,5);
                        break;
                    case "8":
                        Console.WriteLine("Executando Exercício 08...");
                        Exercicio08(10);
                        break;
                    case "9":
                        Console.WriteLine("Executando Exercício 09...");
                        Exercicio09();
                        break;
                    case "0":
                        Console.WriteLine("Saindo...");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opção inválida! Tente novamente.");
                        break;
                }


            } while (opcao.ToLower() != "0");




        }
    }
}











