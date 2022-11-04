// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве

using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            double distance = Get_distance();
            Console.WriteLine($"Расстояние между точками A и B равно {distance}");
        }
        static double Get_distance(){
            Console.WriteLine("Введите координаты точки А через enter (x,y,z)");
            int Ax = Convert.ToInt32(Console.ReadLine());
            int Ay = Convert.ToInt32(Console.ReadLine());
            int Az = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координаты точки B через enter (x,y,z)");
            int Bx = Convert.ToInt32(Console.ReadLine());
            int By = Convert.ToInt32(Console.ReadLine());
            int Bz = Convert.ToInt32(Console.ReadLine());
            double dis= Math.Sqrt(Math.Pow((Bx-Ax),2)+Math.Pow((By-Ay),2)+Math.Pow((Bz-Az),2));
            return dis;
        }
    }
}
