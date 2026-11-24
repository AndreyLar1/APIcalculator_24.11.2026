using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leason1 
{
    public class Math 
    {
       
        public int sum(int num1, int num2) => num1 + num2; // сложение двух чисел 

       
        public int sub(int num1, int num2) => num1 - num2; // вычитание 

        
        public int mul(int num1, int num2) => num1 * num2; // умножение

        
        public double div(double num1, double num2) // деление 
        {
            if (num2 == 0) return 0; 
            return num1 / num2; 
        }

        
        public int sum(int num1, int num2, int num3) => num1 + num2 + num3; // сложение трех чисел 

        
        public int mod(int num1, int num2) => num1 % num2; // остаток от деления

        
        public double pow(double num1, double num2) => System.Math.Pow(num1, num2); // возведение в степень

        
        public double sqrt(double num) => System.Math.Sqrt(num); // квадратный корень

        
        public double abs(double num) => System.Math.Abs(num); // модуль числа

        
        public long fact(int num) // факториал (long потому что быстро число растет) 
        {
            long result = 1; 
            for (int i = 1; i <= num; i++) 
            {
                result = result * i; 
            }
            return result; 
        }

        
        public double percent(double num, double percent) => (num * percent) / 100; // процент от числа 

       
        public double round(double num) => System.Math.Round(num); // округление до ближайшего 

        
        public double max(double num1, double num2) => System.Math.Max(num1, num2); // макс из двух 

        
        public int arraySum(int[] nums) => nums.Sum(); // сумма всех элементов массива

        
        public double arrayAvg(double[] nums) => nums.Average(); // среднее ариф. метод average сам находит его 

       
        public int arrayMin(int[] nums) => nums.Min(); // мин число в массиве 
        
        public int arrayMax(int[] nums) => nums.Max(); // макс число в массиве 
    }
}