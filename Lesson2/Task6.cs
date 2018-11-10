/*
 
Shemelin Pavel

6. Написать программу подсчета количества «Хороших» чисел в диапазоне от 1 до 1 000 000 000.
Хорошим называется число, которое делится на сумму своих цифр.
Реализовать подсчет времени выполнения программы, используя структуру DateTime.

*/

namespace Lesson2
{
    using System;
    using ClassLibraryLesson2;

    partial class Lesson2
    {

        static void Task6()
        {

            string Welcome = "Вы выбрали задачу подсчета количества хороших чисел в миллиарде\n";
            Welcome = Welcome + "Это внушает!\n";
            Welcome = Welcome + "Давайте начнем.\n";

            ClassLibraryLesson2.PrintTaskWelcomeScreen(Welcome);

            int counter = 0;

            DateTime beginMarkOfTime = DateTime.Now;

            for (int currentNumber = 1; currentNumber <= 1000000000; currentNumber++)
            {

                string currentNumberAsString = currentNumber.ToString();

                int summOfNumbers = 0;
                foreach(char currentChar in currentNumberAsString)
                {

                    summOfNumbers = summOfNumbers + Int32.Parse(currentChar.ToString());

                }

                if (currentNumber % summOfNumbers == 0)
                {
                    counter++;
                }
                
            }

            DateTime finishMarkOfTime = DateTime.Now;

            TimeSpan deltaMarkOfTime = finishMarkOfTime - beginMarkOfTime;

            ClassLibraryLesson2.Print($"Количество хороших чисел: {counter}. Затрачено времени: {deltaMarkOfTime.TotalMinutes} минут");

            ClassLibraryLesson2.Pause();

        }

    }

}