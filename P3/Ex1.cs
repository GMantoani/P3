/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        CultureInfo culture = CultureInfo.InvariantCulture;


        Console.WriteLine("Digite as 4 notas do aluno (separadas por espaço):");
        string[] notasInput = Console.ReadLine().Split(' ');
        double n1 = double.Parse(notasInput[0], culture);
        double n2 = double.Parse(notasInput[1], culture);
        double n3 = double.Parse(notasInput[2], culture);
        double n4 = double.Parse(notasInput[3], culture);


        double media = (n1 + n2 + n3 + n4) / 4.0;
        Console.WriteLine($"Media: {media.ToString("F1", culture)}");


        if (media >= 7.0)
        {
            Console.WriteLine("Aluno aprovado.");
        }
        else if (media < 5.0)
        {
            Console.WriteLine("Aluno reprovado.");
        }
        else
        {
            Console.WriteLine("Aluno em exame.");
            Console.WriteLine("Digite a nota do exame:");
            double notaExame = double.Parse(Console.ReadLine(), culture);

            // Cálculo da média final
            double mediaFinal = (media + notaExame) / 2.0;
            Console.WriteLine($"Nota do exame: {notaExame.ToString("F1", culture)}");

            if (mediaFinal >= 5.0)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else
            {
                Console.WriteLine("Aluno reprovado.");
            }
            Console.WriteLine($"Media final: {mediaFinal.ToString("F1", culture)}");
        }
    }
}