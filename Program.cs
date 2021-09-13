using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProMod
{
    class Program
    {
        //public static double Fatorial(int numero)
        //{
        //    double resultado = 1;
        //    while (numero != 1)
        //    {
        //        resultado = resultado * numero;
        //        numero = numero - 1;
        //    }
        //    return resultado;
        //}
        //public  static int Idadeemdias(int ano, int meses, int dias)
        //{
        //    int resultado = (ano * 365 + meses * 30 + dias);
        //    return resultado;
        //}
        //static void Criar_Array(ref int[] vetor)
        //{
        //    for (int i = 0; i < vetor.Length; i++)
        //    {
        //        Console.Write("Digite o {0} valor: ", i + 1);
        //        vetor[i] = int.Parse(Console.ReadLine());
        //    }
        //}
        //static int Soma(int[] vetor)
        //{
        //    int somatoria = 0;
        //    for (int i = 0; i < vetor.Length; i++)
        //    {
        //        if (vetor[i] % 2 == 0)
        //        {
        //            somatoria += vetor[i];
        //        }
        //    }
        //    return (somatoria);
        //}
        //static int Maior(int[] vetor)
        //{
        //    int maior_numero = vetor[0];
        //    for (int i = 1; i < vetor.Length; i++)
        //    {
        //        if (vetor[i] > maior_numero)
        //        {
        //            maior_numero = vetor[i];
        //        }
        //    }
        //    return (maior_numero);
        //}

        //public static bool Validacpf(string cpf)
        //{
        //    int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
        //    int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
        //    string tempCpf;
        //    string digito;
        //    int soma;
        //    int resto;
        //    cpf = cpf.Trim();
        //    cpf = cpf.Replace(".", "").Replace("-", "");
        //    if (cpf.Length != 11)
        //        return false;
        //    tempCpf = cpf.Substring(0, 9);
        //    soma = 0;

        //    for (int i = 0; i < 9; i++)
        //        soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
        //    resto = soma % 11;
        //    if (resto < 2)
        //        resto = 0;
        //    else
        //        resto = 11 - resto;
        //    digito = resto.ToString();
        //    tempCpf = tempCpf + digito;
        //    soma = 0;
        //    for (int i = 0; i < 10; i++)
        //        soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
        //    resto = soma % 11;
        //    if (resto < 2)
        //        resto = 0;
        //    else
        //        resto = 11 - resto;
        //    digito = digito + resto.ToString();
        //    return cpf.EndsWith(digito);

        //}

        public static bool Validaprimo(int numero)
        {
            int divisores = 0;

            // verificar a quantidade de divisores do numero 
            for (int i = 1; i <= numero; i++)
            {
                // verifica se é divisor
                if (numero % i == 0)
                {
                    divisores++;
                }
            }
            // verificar se possui apenas dois divisores

            if (divisores == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            //1.Escreva uma função que calcule e retorne o fatorial
            //de um número inteiro positivo
            //public static double Calculafatorial(int numero)

            //int value;
            //Console.WriteLine(" Digite um valor para retornarmos o seu fatorial: ");
            //value = int.Parse(Console.ReadLine());

            //Console.WriteLine(" O fatorial de " + value + " é " + Fatorial(value));
            //Console.ReadKey();

            //2.Escreva uma função que verifique se um número é
            //primo.Sua função deve retornar verdadeiro ou
            //falso.O argumento de entrada é o número a ser
            //verificado.
            int numero;
            Console.WriteLine("Digite um número: ");
            numero = int.Parse(Console.ReadLine());

            if(Validaprimo(numero) == true)
            {
                Console.WriteLine("É um número primo ! ");
            }
            else
            {
                Console.WriteLine("não é um número primo ! ");
            }

            //3.Faça um algoritmo que leia a idade de uma
            //pessoa expressa em anos, meses e dias e
            //escreva a idade dessa pessoa expressa apenas
            //em dias. Considerar ano com 365 dias e mês com
            //30 dias.

            //int ano, meses, dias;
            //Console.WriteLine("Digite sua idade em anos: ");
            //ano = int.Parse(Console.ReadLine());

            //Console.WriteLine("Digite sua idade em meses: ");
            //meses = int.Parse(Console.ReadLine());

            //Console.WriteLine("Digite sua idade em dias: ");
            //dias = int.Parse(Console.ReadLine());

            //Console.WriteLine("A idade em dias é:  " + Idadeemdias(ano, meses, dias));

            //4.Descreva um programa que apresente as rotinas
            //abaixo que são escolhidas pelo usuário a partir de
            //um menu apresentado no início do programa:

            //a) Criação de um array de 20 números inteiros e
            //positivos e que só pode ser executada uma
            //única vez(faça as proteções necessárias contra
            //uma Segunda utilização desta rotina);

            //b) Cálculo da soma de todos os números que são
            //pares;

            //c) Determine o maior número do array;

            //Obs: O programa deve impedir que números
            //negativos sejam gravados no array bem como que
            //a criação do array seja realizada uma 2ª vez ou
            //então que as rotinas “b” e “c” sejam realizadas
            //antes da criação do array.A rotina a ser executada
            //deve ser de opção do usuário que a escolherá
            //através de um menu que deve ser apresentado no
            //início do programa e no fim da operação de cada
            //rotina.Esse menu deve conter ainda a opção “Fim
            //de serviço”.

            //int[] vetor = new int[20];
            //int escolha;
            //bool controle = true;
            //do
            //{
            //    Console.Clear();
            //    Console.WriteLine("1 ­ Digitação dos valores no ARRAY");
            //    Console.WriteLine("2 ­ Cálculo da soma dos números pares");

            //    Console.WriteLine("3 ­ Determinar maior número do ARRAY");
            //    Console.WriteLine("4 ­ Fim de serviço");
            //    escolha = int.Parse(Console.ReadLine());
            //    switch (escolha)
            //    {
            //        case 1:
            //            if (controle == false)
            //            {
            //                Console.Write("Vetor já criado!");
            //                Console.ReadKey();
            //            }
            //            else
            //            {
            //                Criar_Array(ref vetor);
            //                controle = false;
            //            }
            //            break;
            //        case 2:
            //            Console.Write("A soma dos elementos pares do Array é { 0}", Soma(vetor));
            //    Console.ReadKey();
            //            break;
            //        case 3:
            //            Console.Write("O maior número do Array é {0}", Maior
            //            (vetor));
            //            Console.ReadKey();
            //            break;
            //    }
            //} while (escolha != 4);

            //5.Desenvolva um programa que receba via teclado
            //o número do CPF do usuário e o valide através de
            //uma função C#.

            //string cpf;
            //Console.WriteLine(" Digite o seu CPF, para verificarmos se é válido: ");
            //cpf = Console.ReadLine();
            //bool resultado = Validacpf(cpf);
            //if (resultado == true)
            //{
            //    Console.WriteLine(" Teu CPF é válido ! ");
            //}
            //else
            //{
            //    Console.WriteLine(" Teu CPF não é válido ! ");
            //}

        }
    }
}