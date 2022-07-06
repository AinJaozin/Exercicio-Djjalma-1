using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ////NOME: João Victor Da Silva       RA: 6322526

            ////1 - Faça um programa que receba o nome do aluno, nota de trabalho, nota da prova 1 e nota da prova 2.Calcule a média 
            ////final(média simples) e apresente o conceito obtido seguindo a seguinte formula:
            ////O conceito da será calculado da seguinte forma:

            ////Se a nota final for maior ou igual a 8.5, então o conceito é A.
            ////Se a nota final estiver entre 7.0 e 8.4, então o conceito é B.
            ////Se a nota final estiver entre 6.0 e 6.9, então o conceito é C.
            ////Se a nota final estiver entre 0.1 e 5.9, então o conceito é D.
            ////Se a nota final for igual a 0.0, então o conceito é E.

            double n2, n3, n4, media;
            string nome;

            Console.WriteLine("Digite o seu nome:");
            nome = Console.ReadLine();

            Console.WriteLine("Digite a sua nota da apresentação");
            n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a sua nota da primeira prova ");
            n3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a sua nota da segunda prova");
            n4 = double.Parse(Console.ReadLine());

            media = ((n2 + n3 + n4) / 3);

            if (media > 8.5)

            {
                Console.WriteLine(" Conceito final : Meus parabéns");
            }
            if (media >= 7.0 == media <= 8.4)
            {
                Console.WriteLine(" Conceito final : Otimo");
            }
            if (media >= 6.0 == media <= 6.9)
            {
                Console.WriteLine(" Conceito final : Se esforce");
            }
            if (media == 0.0)
            {
                Console.WriteLine(" Conceito final : :(");
            }

            Console.ReadKey();

        }

    }

}


