namespace Lesson2
{
    using System;
    using ClassLibraryLesson2;

    partial class Lesson2
    {

        static void StartMenu()
        {

            string Welcome = "Добрый день, пользователь!\n";
            Welcome = Welcome + "Выберите чем бы Вы хотели заняться:\n";
            Welcome = Welcome + "Меню на сегодня:\n";
            Welcome = Welcome + "1 - Вычисление минимального числа из трех\n";
            Welcome = Welcome + "2 - Подсчет числа знаков в числе\n";
            Welcome = Welcome + "3 - Сумма положительных нечетных чисел в ряду\n";
            Welcome = Welcome + "4 - Проверка логина и пароля\n";
            Welcome = Welcome + "6 - Хорошие числа в миллиарде\n";
            Welcome = Welcome + "7 - Рекурсивный вывод ряда\n";

            Welcome = Welcome + "0 - Выход из программы\n";

            while (true)
            {

                ClassLibraryLesson2.PrintTaskWelcomeScreen(Welcome);

                ConsoleKeyInfo userChooseKey = Console.ReadKey(true);

                switch (userChooseKey.Key)
                {

                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        Task1();
                        break;

                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        Task2();
                        break;

                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        Task3();
                        break;

                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        Task4();
                        break;

                    case ConsoleKey.D6:
                    case ConsoleKey.NumPad6:
                        Task6();
                        break;

                    case ConsoleKey.D7:
                    case ConsoleKey.NumPad7:
                        Task7();
                        break;

                    case ConsoleKey.D0:
                    case ConsoleKey.NumPad0:
                        Environment.Exit(0); // на выход
                        break;

                }
            }


        }


    }

}