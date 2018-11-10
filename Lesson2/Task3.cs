/*
 
Shemelin Pavel

3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.

*/

namespace Lesson2
{
    using System;
    using ClassLibraryLesson2;

    partial class Lesson2
    {

        static void Task3()
        {

            string Welcome = "Вы выбрали задачу подсчета суммы нечетных положительных чисел\n";
            Welcome = Welcome + "Это завораживает!\n";
            Welcome = Welcome + "Давайте начнем.\n";

            ClassLibraryLesson2.PrintTaskWelcomeScreen(Welcome);

            double totalSumm = 0;

            while(true)
            {

                string userAnwerAsString = ClassLibraryLesson2.MakeQuestion("число. Для окончания ряда чисел введите 0");

                if (Double.TryParse(userAnwerAsString, out double currentNumber))
                {

                    if(currentNumber > 0 && currentNumber % 2 != 0)
                    {

                        totalSumm = totalSumm + currentNumber;

                    }
                    else if (currentNumber == 0)
                    {

                        break;

                    }
                }
                else
                {

                    ClassLibraryLesson2.Print($"Введенное значение {userAnwerAsString} не подходит!");

                }

            }

            ClassLibraryLesson2.Print($"Сумма положительных нечетных положительных чисел: {totalSumm}");

            ClassLibraryLesson2.Pause();

        }

    }

}