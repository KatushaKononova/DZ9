// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите пятизначное число");
            string str = Console.ReadLine();
            if(str.Length==5){
                if(str[0]==str[4] && str[1]==str[3]){
                    Console.WriteLine("Число является палиндромом");
                }
                else Console.WriteLine("Число не является палиндромом");
            }
            else Console.WriteLine("Число не пятизначное");
        }
    }
}
