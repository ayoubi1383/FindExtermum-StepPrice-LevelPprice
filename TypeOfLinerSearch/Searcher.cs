using System;
using System.Collections.Generic;

namespace TypeOfLinerSearch
{
    public class Searcher
    {
        public List<(double X, double Y, string extremum)> GetExtremums(double[] x, double[] y, int startIndex, int endIndex)
        {
            List<(double, double, string)> save_extremums = new List<(double, double, string)>();
            //شرط برقراری ارایه 
            if (startIndex < 0 || endIndex > y.Length || startIndex >= endIndex)
            {
                Console.WriteLine("Invalid index range.");
                return save_extremums;
            }

            if (endIndex - startIndex == 1)
            {
                Console.WriteLine($"X = {x[startIndex]} is the only element, considered both maximum and minimum with Y = {y[startIndex]}");
                save_extremums.Add((x[startIndex], y[startIndex], "both"));
                return save_extremums;
            }
            //نقطه اولیه 
            if (y[startIndex] > y[startIndex + 1])
            {
                Console.WriteLine($"X = {x[startIndex]} with Y = {y[startIndex]} is a maximum (first element)");
                save_extremums.Add((x[startIndex], y[startIndex], "maximum"));
            }
            else if (y[startIndex] < y[startIndex + 1])
            {
                Console.WriteLine($"X = {x[startIndex]} with Y = {y[startIndex]} is a minimum (first element)");
                save_extremums.Add((x[startIndex], y[startIndex], "minimum"));
            }
            //نقطه های میانی 
            for (int i = startIndex + 1; i < endIndex - 1; i++)
            {
                if (y[i] > y[i - 1] && y[i] > y[i + 1])
                {
                    Console.WriteLine($"X = {x[i]} with Y = {y[i]} is a maximum");
                    save_extremums.Add((x[i], y[i], "maximum"));
                }
                else if (y[i] < y[i - 1] && y[i] < y[i + 1])
                {
                    Console.WriteLine($"X = {x[i]} with Y = {y[i]} is a minimum");
                    save_extremums.Add((x[i], y[i], "minimum"));
                }
            }
            //نقطه پایانی 
            if (y[endIndex - 1] > y[endIndex - 2])
            {
                Console.WriteLine($"X = {x[endIndex - 1]} with Y = {y[endIndex - 1]} is a maximum (last element)");
                save_extremums.Add((x[endIndex - 1], y[endIndex - 1], "maximum"));
            }
            else if (y[endIndex - 1] < y[endIndex - 2])
            {
                Console.WriteLine($"X = {x[endIndex - 1]} with Y = {y[endIndex - 1]} is a minimum (last element)");
                save_extremums.Add((x[endIndex - 1], y[endIndex - 1], "minimum"));
            }

            return save_extremums;
        }
    }
}