using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

            
            double num1 = double.Parse(Console.ReadLine());
            double num2 = Convert.ToDouble(Console.ReadLine());
            List<double> res = new List<double>();
            for (double i = num1; i <= num2; i = i + 0.1)
            {
                double result = Math.Sin((i + 2) * (i + 2));
               
                int index = res.FindIndex(item => item == result);
                if (index == -1)
                {
                    res.Add(result);
                    Console.WriteLine($"i = {i} : sin = {result}");
                }
                              
            }
            }
            catch (Exception)
            {

                Console.WriteLine("Вы ввели неверный символ");
            }
            Console.ReadKey();
        }
    }
}
