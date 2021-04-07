using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Aula37
{
    class Program
    {
        static void Main(string[] args)
        {
            //Treinamento - Aula37, inserir dados, tipo, string, int, float, double, char
            //Jonas Valereo - Técnico em Informática

            //Declarando as variaveis, tipo, string, int, float, double, cha

            string nome;
            string sobrenome;
            int idade;
            char sexo;
            float altura;
            double peso;

            //Declarando entrada de dado no console, método ReadLine

            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite seu sobrenome: ");
            sobrenome = Console.ReadLine();
            Console.WriteLine("Digite sua idade: ");
            idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite seu sexo: ");
            sexo = char.Parse(Console.ReadLine());
            Console.WriteLine("Digite sua altura: ");
            altura = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite seu peso: ");
            peso = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            //imprimir saida de dados no console, método WhriteLine, concatenação

            Console.WriteLine("O resultado é !!! ");
            Console.WriteLine();
            Console.WriteLine("Meu nome: " + nome);
            Console.WriteLine("Meu sobrenome: " + sobrenome);
            Console.WriteLine("Minha idade: " + idade + " " + "anos");
            Console.WriteLine("Meu sexo: " + sexo);
            Console.WriteLine("Minha altura: " + altura.ToString("F2", CultureInfo.InvariantCulture) + " " + "altura");
            Console.WriteLine("Meu peso: " + peso.ToString("F2", CultureInfo.InvariantCulture) + " " + "Kg");

            // saida do aplicativo console, método Readkey, Retorna o valor da tecla pressionada

            Console.ReadKey();
            
            //Fim do progama



        }
    }
}
