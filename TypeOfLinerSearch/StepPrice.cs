using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeOfLinerSearch
{
    public class StepPrice
    {
        public List<int> GetStep(List<(double X, double Y ,string extermom)> x)
        {
            List<int> step = new List<int>();
            foreach (var i in x)
            {
                int numbers = (int)i.Y;
                while (numbers >= 10)
                {
                    int counter = 0;
                    char[] seperator1 = numbers.ToString().ToCharArray();
                    foreach (var result in seperator1)
                    {
                        counter += int.Parse(result.ToString());
                    }
                    numbers = counter;
                }
                step.Add(numbers);
                Console.WriteLine(numbers);
            }
            return step;
        }


        //public List<int> GetStep(List<(double X, double Y)> x)
        //{
        //    List<int> step = new List<int>();

        //    foreach (var i in x)
        //    {
        //        int num = (int)i.Y;

        //        // تابعی برای کاهش عدد به یک رقم
        //        int ReduceToSingleDigit(int n)÷
        //        {
        //            while (n >= 10)
        //            {
        //                int sum = 0;
        //                while (n > 0)
        //                {
        //                    sum += n % 10; // گرفتن رقم یکان و افزودن به مجموع
        //                    n /= 10;       // حذف رقم یکان
        //                }
        //                n = sum; // جایگزینی با مجموع جدید
        //            }
        //            return n;
        //        }

        //        int result = ReduceToSingleDigit(num);
        //        step.Add(result);
        //        Console.WriteLine(result);
        //    }

        //    return step;
        //}
    }
}
