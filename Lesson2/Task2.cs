/*
 
Shemelin Pavel

2. Написать метод подсчета количества цифр числа.

*/

namespace Lesson2
{
    using System;
    using ClassLibraryLesson2;

    partial class Lesson2
    {

        static uint CountQuantityOfNumeral(uint userNumber)
        {
            
            uint counter = 0;
            
            do
            {
                counter++;
                userNumber = userNumber / 10;

            }
            while (userNumber >= 1);

            return counter;

        }
                
        static void Task2()
        {

            string Welcome = "Вы выбрали задачу подсчета количества цифр в заданном числе\n";
            Welcome = Welcome + "Это крайне интересно!\n";
            Welcome = Welcome + "Давайте начнем.\n";

            ClassLibraryLesson2.PrintTaskWelcomeScreen(Welcome);

            string userAnwerAsString = ClassLibraryLesson2.MakeQuestion("целое положительное число");

            if (UInt32.TryParse(userAnwerAsString, out uint userNumber))
            {

                ClassLibraryLesson2.Print($"Число цифр в числе: {CountQuantityOfNumeral(userNumber)}");

            }
            else
            {

                ClassLibraryLesson2.Print($"Введенное значение {userAnwerAsString} не подходит!");

            }

            ClassLibraryLesson2.Pause();

        }
        
    }

}