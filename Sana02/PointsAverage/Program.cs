using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть 5 оцінок студента за 100-бальною системою:");

        int finishGrade = 0;
        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"Оцінка {i}: ");
            int grade = Convert.ToInt32(Console.ReadLine());

            if (grade < 0 || grade > 100)
            {
                Console.WriteLine("Помилка. Оцінка повинна бути в межах від 0 до 100.");
                return;
            }

            finishGrade += grade;
        }

        double average = (double)finishGrade / 5;

        Console.WriteLine($"Середній бал: {average}");

        if (average >= 50)
        {
            Console.WriteLine("Студент допущений до екзамену.");
        }
        else
        {
            Console.WriteLine("Студент не допущений до екзамену.");
        }
    }
}