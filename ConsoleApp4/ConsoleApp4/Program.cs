using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            int sizeOfMassiv, number;

            Console.WriteLine("Введите размер массива");
            str = Console.ReadLine();
            for (; ; )
            {
                if (Int32.TryParse(str, out sizeOfMassiv))
                {
                    sizeOfMassiv = Int32.Parse(str);
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Недопустимый символ! Пожалуйста убедитесь, что вводите целое число");
                    Console.WriteLine("Введите размер массива");
                    str = Console.ReadLine();
                }
            }

            Console.WriteLine("Введите число");
            str = Console.ReadLine();

            for (; ; )
            {
                if (Int32.TryParse(str, out number))
                {
                    number = Int32.Parse(str);
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Недопустимый символ! Пожалуйста убедитесь, что вводите целое число");
                    Console.WriteLine("Введите число");
                    str = Console.ReadLine();
                }
            }

            MassivVKvadrate massiv = new MassivVKvadrate(sizeOfMassiv);

            massiv[0] = number;

            Console.WriteLine("Квадрат числа {0} = {1}", number, massiv[0]);
            Console.ReadLine(); 
        }
    }
}
