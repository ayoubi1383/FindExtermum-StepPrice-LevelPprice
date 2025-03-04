using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TypeOfLinerSearch
{
    public class Searcher
    {
        public List<(double X, double Y, string extermom)> GetExtremums(double[] x, double[] y)
        {   
            List<(double, double,string)>  save_extremums = new List<(double, double,string)>();
            //برسی خالی بودن و یا تک مقدار بودن 
            if (y.Length == 0)
            {
                Console.WriteLine("The array is empty.");
                return save_extremums;
            }
            else if (y.Length == 1)
            {
                Console.WriteLine($"X = {x[0]} is the only element, considered " +
                    $"both maximum and minimum with Y = {y[0]}");
                save_extremums.Add((x[0], y[0] ,"both"));
                return save_extremums;
            }

            // بررسی اولین مقدار
            if (y[0] > y[1])
            {
                Console.WriteLine($"X = {x[0]} with Y = {y[0]} is a maximum (first element)");
                save_extremums.Add((x[0], y[0], "maximum"));
            }
            else if (y[0] < y[1])
            {
                Console.WriteLine($"X = {x[0]} with Y = {y[0]} is a minimum (first element)");
                save_extremums.Add((x[0], y[0] , "minimum"));
            }

            // بررسی مقدارهای میانی
            for (int i = 1; i < y.Length - 1; i++)
            {
                if (y[i] > y[i - 1] && y[i] > y[i + 1])
                {
                    Console.WriteLine($"X = {x[i]} with Y = {y[i]} is a maximum");
                    save_extremums.Add((x[i], y[i] ,"maximum"));
                }
                else if (y[i] < y[i - 1] && y[i] < y[i + 1])
                {
                    Console.WriteLine($"X = {x[i]} with Y = {y[i]} is a minimum");
                    save_extremums.Add((x[i], y[i] , "minimum"));
                }
            }

            // بررسی آخرین مقدار
            int lastIndex = y.Length - 1;
            if (y[lastIndex] > y[lastIndex - 1])
            {
                Console.WriteLine($"X = {x[lastIndex]} with Y = {y[lastIndex]} is a maximum (last element)");
                save_extremums.Add((x[lastIndex], y[lastIndex], "maximum"));
            }
            else if (y[lastIndex] < y[lastIndex - 1])
            {
                Console.WriteLine($"X = {x[lastIndex]} with Y = {y[lastIndex]} is a minimum (last element)");
                save_extremums.Add((x[lastIndex], y[lastIndex], "minimum"));
            }

            return save_extremums;
        }






    }
}
