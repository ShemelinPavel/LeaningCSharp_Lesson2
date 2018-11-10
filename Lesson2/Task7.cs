/*
 
Shemelin Pavel

7. a) Разработать рекурсивный метод, который выводит на экран числа от a до b (a<b);

*/

namespace Lesson2
{
    using System;
    using ClassLibraryLesson2;

    partial class Lesson2
    {

        static void RecursivePrint(int begin, int end)
        {

            if (end >= begin)
            {

                ClassLibraryLesson2.Print(end.ToString());

                end--;

                RecursivePrint(begin, end);
            }

        }

        static void Task7()
        {

            string Welcome = "Вы выбрали задачу рекурсивного вывода ряда чисел\n";
            Welcome = Welcome + "Это забавно!\n";
            Welcome = Welcome + "Давайте начнем.\n";

            ClassLibraryLesson2.PrintTaskWelcomeScreen(Welcome);

            int beginNumber = Int32.Parse(ClassLibraryLesson2.MakeQuestion("начальное число ряда"));
            int endNumber = Int32.Parse(ClassLibraryLesson2.MakeQuestion("конечное число ряда"));

            ClassLibraryLesson2.Print("Вывод ряда:");

            RecursivePrint(beginNumber, endNumber);

            ClassLibraryLesson2.Pause();

        }

    }

}