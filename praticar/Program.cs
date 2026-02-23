using System;
using System.Globalization;
namespace media
{
    class program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, n4, media;
            Console.WriteLine("digite a primeira nota");
            n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("digite a segunda nota");
            n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("digite a terceira nota");
            n3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("digite a quarta nota");
            n4 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            media = (n1 + n2 + n3 + n4) / 4;
            Console.WriteLine("media: " + media.ToString("F1", CultureInfo.InvariantCulture));

            if (media <= 6.9)
            {
                Console.WriteLine("aluno de exame");
            }
            else
            {
                Console.WriteLine("aluno aprovado");
            }
            Console.ReadLine();
        }
    }
}