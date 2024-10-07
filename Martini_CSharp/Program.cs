using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Martini_CSharp.Serie1;
// int, float, char, string etc...
// sbyte, short, int, long => entiers signés
// byte ushort, uint, ulong => non signés
// Conversions implicites et explicites
// Plage de valeurs réduite à grande: conversion inplicite
// Conversion explicite (type)var
// Console.ReadKey()
// Float, Double: standard, Decimal: trèes grande précision, plus de précision
// après la virgule mais moins avant
// pour préciser faut faire long a = 123L
// Decimal c'est m et float c'est f.
// var/static
// string = "bla"
// char = 'c'
// bool a = false, true (faux par default)
// parsing: bool estentier = int.TryParse(var, out entier) 
// and && un seul il fait tous les calculs avant, le double il regarder condition
// par condition
namespace Martini_CSharp
{
    public static class Program
    { 
 
        public static void Main()
        {
            int A, B;
            string entree;
            string oper;

            Console.WriteLine("Introduire le premier nombre");
            entree = Console.ReadLine();
            bool entree_A = int.TryParse(entree, out A);

            Console.WriteLine("Introduire le deuxième nombre");
            entree = Console.ReadLine();
            bool entree_B = int.TryParse(entree, out B);

            Console.WriteLine("Indiquer l'operateur");
            oper = Console.ReadLine();
            if (oper == "+")
            {
                Operations.Addition(A, B);
            }
            else if (oper == "-")
            {
                Operations.Soustraction(A, B);
            }
            else if (oper == "*")
            {
                Operations.Produit(A, B);
            }
            else if (oper == "/")
            {
                Operations.Quotien(A, B);
            }
            else
            {
                Console.WriteLine($"{A} {oper} {A} = Opération invalide");
            }
            Console.ReadKey();

            // Division entiere:
            Console.WriteLine("Division entière");

            Console.WriteLine("Introduire le premier nombre");
            entree = Console.ReadLine();
            entree_A = int.TryParse(entree, out A);

            Console.WriteLine("Introduire le deuxième nombre");
            entree = Console.ReadLine();
            entree_B = int.TryParse(entree, out B);
            if (B != 0)
            {
                Division_entiere.IntegerDivision(A, B);
            }
            else
            {
                Console.WriteLine(A + "/" + B + "= Opération invalide");
            }
            Console.ReadKey();

            // Fonction pow:

            Console.WriteLine("Fonction puissance");

            Console.WriteLine("Introduire le premier nombre");
            entree = Console.ReadLine();
            entree_A = int.TryParse(entree, out A);

            Console.WriteLine("Introduire le deuxième nombre");
            entree = Console.ReadLine();
            entree_B = int.TryParse(entree, out B);
            if (B > 0){
                Pow.Puissance(A, B);
            }
        }
    }
}
