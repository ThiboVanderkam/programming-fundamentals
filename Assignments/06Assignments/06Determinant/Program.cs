using System;

namespace _06Determinant
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] matrix = new int[2][];
            matrix[0] = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);
            matrix[1] = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);

            int determinant = (matrix[0][0] * matrix[1][1]) - (matrix[0][1] * matrix[1][0]);
            Console.WriteLine(determinant);
        }
    }
}
