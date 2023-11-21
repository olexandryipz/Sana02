﻿using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть ціле число від 0 до 9: ");
        int number;

        bool isReadSuccess = int.TryParse(Console.ReadLine(), out number);

        if (!isReadSuccess)
        {
            Console.WriteLine("Число має бути цілим");
            return;
        }
        switch (number)
        {
            case 0:
                Console.WriteLine("0 - нуль");
                break;
            case 1:
                Console.WriteLine("1 - один");
                break;
            case 2:
                Console.WriteLine("2 - два");
                break;
            case 3:
                Console.WriteLine("3 - три");
                break;
            case 4:
                Console.WriteLine("4 - чотири");
                break;
            case 5:
                Console.WriteLine("5 - п'ять");
                break;
            case 6:
                Console.WriteLine("6 - шість");
                break;
            case 7:
                Console.WriteLine("7 - сім");
                break;
            case 8:
                Console.WriteLine("8 - вісім");
                break;
            case 9:
                Console.WriteLine("9 - дев'ять");
                break;
            default:
                Console.WriteLine("Помилка. Потрібно ввести число від 0 до 9.");
                break;
        }
    }
}