using System;
class Program
{
    static void Main()
    {
        while (true) // Бесконечный цикл
        {
            Console.Write("Введите число или 'q' для выхода: ");
            string input = Console.ReadLine(); // Чтение строки ввода пользователя
            if (input == "q") // Проверка на ввод 'q' для выхода
            {
                break;
            }
            int number;
            if (int.TryParse(input, out number))
            {
                int sum = 0;
                while (number > 0)
                {
                    sum += number % 10;
                    number /= 10;
                }
                if (sum % 2 == 0)
                {
                    Console.WriteLine("[STOP]");
                    break;
                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое числоили 'q'.");
            }
        }
    }
}
