using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PupilsMark
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float[,] puntuations = new float[10, 10];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine("Enter the puntuation {0} group {1}: ", j + 1, i + 1);
                    puntuations[i, j] = Convert.ToSingle(Console.ReadLine());
                }
            }
        }
    }
}
