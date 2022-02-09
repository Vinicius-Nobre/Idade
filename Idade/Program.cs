using System;

namespace Idade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua idade");

            int idade = int.Parse(Console.ReadLine());


            if (idade >= 0 && idade <= 11)
            {
                Console.WriteLine("Você é uma criança");
            }
            else if (idade >= 12 && idade <= 18)
            {
                Console.WriteLine("Você é adolescente");
            }
            else if (idade >= 19 && idade <= 60)
            {
                Console.WriteLine("Você é adulto");
            }else

            {
                Console.WriteLine("Você é idoso");
            }

        }
    }
}
