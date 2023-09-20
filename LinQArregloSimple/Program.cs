using System;
using System.Linq;

namespace LinQArregloSimple0
    0
{
    public class LinqArregloSimple
    {
        public static void Main()
        {
            //282

            var valores = new[] {2, 9, 5, 0, 3, 7, 1, 4, 7, 8, 5};

            Console.Write("Original array: ");
            foreach(var elemento in valores)
            {
                Console.Write($"{elemento}");
            }

            var filtrado =
                from valor in valores
                where valor > 4
                select valor;

            Console.Write("\nValores del arreglo mayores que 4:");
            foreach(var elemento in filtrado)
            {
                Console.Write($" {elemento}");
            }

            var acomodar =
                from valor in valores
                orderby valor
                select valor;

            Console.Write("\nArreglo original, sorted");
            foreach (var elemento in acomodar)
            {
                Console.Write($" {elemento}");
            }

            var sortFilteredResults =
                from valor in filtrado
                orderby valor descending
                select valor;

            Console.Write("\nValores mayores a 4, en orden descendente (two queries):");
            foreach(var elemento in sortFilteredResults)
            {
                Console.Write($" {elemento}");
            }

            var sortAndFilter = 
                from valor in valores
                where valor > 4
                orderby valor descending
                select valor;

            Console.Write("\nValores mayores a 4, orden descendente (one query):");
            foreach (var elemento in sortAndFilter)
            {
                Console.Write($" {elemento}");
            }

            Console.WriteLine();
        }
    }
}