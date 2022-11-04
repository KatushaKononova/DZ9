// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Write_cyb();
        }

        static void Write_cyb(){
            Console.WriteLine("Введите число");
            int num = Convert.ToInt32(Console.ReadLine());
            int num_cub=1;
            while(num_cub!=num){
                Console.Write(Math.Pow(num_cub,3) + ", ");
                num_cub++;
            }
            Console.Write(Math.Pow(num,3));
        }
    }
}
