using System;
using static System.Console;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задание 1.
            string fullName = "Иванов Иван Иванович";
            int age = 30;
            string email = "ivanov@mail.ru";
            float mathScore = 4.93F;
            float programScore = 4.91F;
            float physicsScore = 4.92F;

            Write($"{"ФИО",-29}: {fullName} \n{"Возраст",-29}: {age} \n{"Email",-29}: {email} \n{"Балл по программированию",-29}: {programScore} \n{"Балл по математике",-29}: {mathScore} \n{"Балл по физике",-29}: {physicsScore}\n");
            ReadKey();

            // Задание 2.

            float sumScore = mathScore + programScore + physicsScore;
            WriteLine("Сумма балов по трем предметам: " + sumScore);
            float averageScore = sumScore / 3;
            WriteLine("Среднее арифметическое баллов: " + averageScore);
            ReadKey();
        }
    }
}