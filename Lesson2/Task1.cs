/*
 
Shemelin Pavel

1. Написать метод, возвращающий минимальное из трех чисел.

PS Я сделал, что количество чисел может быть по сути любым

*/

namespace Lesson2
{
    using System;
    using ClassLibraryLesson2;

    partial class Lesson2
    {

        static double MinNumber(string numberAsString, out int counter)
        {

            counter = 0;

            string[] userAnwer = ClassLibraryLesson2.SplitString(numberAsString);

            double value = Double.MaxValue;

            foreach (string element in userAnwer)
            {

                if (Double.TryParse(element, out double currentNumber))
                {

                    counter++; // это было число

                    if (value > currentNumber)
                    {

                        value = currentNumber;

                    }

                }
                else
                {

                    ClassLibraryLesson2.Print($"Введенное значение {element} не является числом!");

                }

            }

            return value;

        }

        static void Task1()
        {

            string Welcome = "Вы выбрали задачу поиска минимального ряда чисел\n";
            Welcome = Welcome + "Это так увлекательно!\n";
            Welcome = Welcome + "Давайте начнем.\n";

            ClassLibraryLesson2.PrintTaskWelcomeScreen(Welcome);

            string userAnwerAsString = ClassLibraryLesson2.MakeQuestion("ряд чисел разделенные пробелом");

            double minNumber = MinNumber(userAnwerAsString, out int counter);
                        
            ClassLibraryLesson2.Print($"Было найдено и обработано {counter} чисел из введенной строки <{userAnwerAsString}>.");

            ClassLibraryLesson2.Print((minNumber == Double.MaxValue) ? "Минимальное значение определить не удалось :(" : $"Минимальное значение равно: {minNumber}");

            ClassLibraryLesson2.Pause();

        }
        
    }

}