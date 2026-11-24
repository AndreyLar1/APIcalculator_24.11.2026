using Microsoft.AspNetCore.Mvc;
using APIcalculator.DTO;


namespace APIcalculator.Controllers
{
    [ApiController] // Говорим системе, что этот класс отвечает за обработку API-запросов
    [Route("[controller]")] // Задаем базовый адрес: название класса без слова Controller (/WeatherForecast)
    public class WeatherForecastController : ControllerBase // Объявляем класс контроллера и наследуем базовые функции API
    {
        // Создаем объект вашего класса Math, чтобы вызывать из него готовые методы
        leason1.Math clsMathService = new leason1.Math();

       

        
        [HttpGet("sum2")] // указываем тип запроса GET и уникальный адрес sum2 (сложение 2 чисел)
        public CalcResponseDto GetSum(int num1, int num2) // Теперь метод возвращает не int, а наш объект DTO
        {
            int res = clsMathService.sum(num1, num2); // Считаем ответ через ваш класс Math
            return new CalcResponseDto // Упаковываем ответ в красивую коробку DTO
            {
                Operation = "Сложение двух чисел", // Записываем название операции
                Result = res // Кладем сам результат
            };
        }


        [HttpGet("sub")] // вычитание двух чисел 
        public CalcResponseDto GetSub(int num1, int num2)
        {
            int res = clsMathService.sub(num1, num2); // Вызываем вычитание
            return new CalcResponseDto
            {
                Operation = "Вычитание",
                Result = res
            };
        }


        [HttpGet("mul")] // умножение двух чисел 
        public int GetMul(int num1, int num2) => clsMathService.mul(num1, num2); 

        
        [HttpGet("div")] // Деление двух чисел 
        public double GetDiv(double num1, double num2) => clsMathService.div(num1, num2); 
        

        
        [HttpGet("sum3")] // сложение трех чисел 
        public int GetSum3(int num1, int num2, int num3) => clsMathService.sum(num1, num2, num3); 

        
        [HttpGet("mod")] // остаток от деления
        public int GetMod(int num1, int num2) => clsMathService.mod(num1, num2); 

        
        [HttpGet("pow")] // возведение в степень
        public double GetPow(double num1, double num2) => clsMathService.pow(num1, num2); 

       
        [HttpGet("sqrt")] // квадратный корень из числа
        public double GetSqrt(double num) => clsMathService.sqrt(num); 

        
        [HttpGet("abs")] // модуль числа 
        public double GetAbs(double num) => clsMathService.abs(num);

        
        [HttpGet("fact")] // факториал числа
        public long GetFact(int num) => clsMathService.fact(num); 

        
        [HttpGet("percent")] // найти процент от числа
        public double GetPercent(double num, double percent) => clsMathService.percent(num, percent); 

        
        [HttpGet("round")] // округление числа до целого 
        public double GetRound(double num) => clsMathService.round(num);

        
        [HttpGet("max2")] // максимальное число из двух 
        public double GetMax2(double num1, double num2) => clsMathService.max(num1, num2);
        

        
        [HttpGet("array-sum")] // сумма всех чисел в массиве
        public int GetArraySum([FromQuery] int[] nums) => clsMathService.arraySum(nums); 

        
        [HttpGet("array-avg")] // среднее арифметическое 
        public double GetArrayAvg([FromQuery] double[] nums) => clsMathService.arrayAvg(nums); 
        
        [HttpGet("array-min")] // самое маленькое число в массиве
        public int GetArrayMin([FromQuery] int[] nums) => clsMathService.arrayMin(nums); 

        
        [HttpGet("array-max")] // самое большое число в массиве
        public int GetArrayMax([FromQuery] int[] nums) => clsMathService.arrayMax(nums); 
    }
}