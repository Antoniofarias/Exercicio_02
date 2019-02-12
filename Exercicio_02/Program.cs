using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Desenvolva um algoritmo que permita a entrada do nome do usuário e exiba na tela.
            string nome;

            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("O nome digitado é: " +nome);

            Console.ReadKey();
        }     
    }
}
