using System;
namespace Unit10._5
{
    class Program
    {
        static ILogger Logger { get; set; }
        static void Main()
        {
            Logger = new Logger();
            var calculator1 = new Calculator1(Logger);
            int x;
            int y;
            try
            {
                calculator1.Calc();
            }
            catch (Exception ex)
            { Console.WriteLine(ex.Message); }
        }
    }
    public interface MiniCalculator
    {
        void Calc();
    }
    public interface ILogger
    {
        void Event(string message);
        void Error(string mesaage);

    }
    public class Calculator : MiniCalculator
    {
        public void Calc()
        {
            Console.WriteLine("Введите первое число для сложения");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число для сложения");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine($"{x}+{y} равно {x + y}");
        }


    }
    public class Logger : ILogger
    {
        public void Error(string mesaage)
        {
            Console.WriteLine(mesaage);
        }

        public void Event(string message)
        {
            Console.WriteLine(message);
        }
    }
}

