/*
 
Shemelin Pavel

4. Реализовать метод проверки логина и пароля. 
На вход подается логин и пароль. 
На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains).
Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
С помощью цикла do while ограничить ввод пароля тремя попытками.

*/

namespace Lesson2
{
    using System;
    using ClassLibraryLesson2;

    partial class Lesson2
    {

        static bool TryLogin(string login, string password)
        {

            const string trueLogin = "root";
            const string truePassword = "GeekBrains";

            return (login == trueLogin && password == truePassword) ? true : false;

        }

        static void Task4()
        {

            string Welcome = "Вы выбрали задачу проверки логина и пароля\n";
            Welcome = Welcome + "Это очаровывает!\n";
            Welcome = Welcome + "Давайте начнем.\n";

            ClassLibraryLesson2.PrintTaskWelcomeScreen(Welcome);

            const ushort totalNumberOfAttempts = 3;

            ushort counterOfAttempts = 0;

            do
            {

                counterOfAttempts++;

                string userLogin = ClassLibraryLesson2.MakeQuestion("логин");
                string userPassword = ClassLibraryLesson2.MakeQuestion("пароль");

                if (TryLogin(userLogin, userPassword))
                {

                    ClassLibraryLesson2.Print("Доступ предоставлен!");
                    break;

                }
                else
                {

                    ClassLibraryLesson2.Print("Логин или пароль неверен!");
                    ClassLibraryLesson2.Print($"Осталось {totalNumberOfAttempts - counterOfAttempts} попытки.");

                }

            }
            while (counterOfAttempts < totalNumberOfAttempts);

            ClassLibraryLesson2.Pause();

        }

    }

}