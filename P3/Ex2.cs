/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite as três características do animal:");
        string caracteristica1 = Console.ReadLine();
        string caracteristica2 = Console.ReadLine();
        string caracteristica3 = Console.ReadLine();


        string animal = "";

        if (caracteristica1 == "vertebrado")
        {
            if (caracteristica2 == "ave")
            {
                animal = (caracteristica3 == "carnivoro") ? "aguia" : "pomba";
            }
            else if (caracteristica2 == "mamifero")
            {
                animal = (caracteristica3 == "onivoro") ? "homem" : "vaca";
            }
        }
        else if (caracteristica1 == "invertebrado")
        {
            if (caracteristica2 == "inseto")
            {
                animal = (caracteristica3 == "hematofago") ? "pulga" : "lagarta";
            }
            else if (caracteristica2 == "anelideo")
            {
                animal = (caracteristica3 == "hematofago") ? "sanguessuga" : "minhoca";
            }
        }

        Console.WriteLine($"Animal: {animal}");
    }
}