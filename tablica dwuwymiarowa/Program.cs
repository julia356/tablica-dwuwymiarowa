using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tablica_dwuwymiarowa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] A;
            int m, n;

            do
            {
                Console.WriteLine("Podaj liczbę wierszy tablicy dwuwymiarowej");
            } while (!int.TryParse(Console.ReadLine(), out m) || m <= 0);

            do
            {
                Console.WriteLine("Podaj liczbę kolumn tablicy dwuwymiarowej mneijszej od 10: ");
            } while (!int.TryParse(Console.ReadLine(), out n) || n <= 0 || n > 10);

            A = new int[m, n];
            Random random = new Random();
            int sum = 0;
            int min = 0, max = 0;


            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                    A[i, j] = random.Next(-350, 350);
            }
            // Wyświetlanie emelentów tablicy
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                    Console.Write(A[i, j] + " \t ");
                Console.WriteLine();
            }
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                    sum += A[i, j];
            }

            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                    if (min > A[i, j]) min = A[i, j];
            }

            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                    if (max < A[i, j]) max = A[i, j];
            }

            Console.WriteLine("Suma: " + sum);
            Console.WriteLine("Minimum: " + min);
            Console.WriteLine("Maksimum: " + max);
        }
    }
}
