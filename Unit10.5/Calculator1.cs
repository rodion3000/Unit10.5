using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit10._5
{
    public class Calculator1: MiniCalculator
    {
        ILogger Logger { get; }
        public Calculator1(ILogger logger)
        {
            Logger = logger;
        }

        public void Calc()
        {
            Logger.Event("Калькулятор начал свою работу");
            Console.WriteLine("Введите первое число для сложения");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число для сложения");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine($"{x}+{y} равно {x + y}");
        }
    }
}
