using System;

namespace ArrayMul
{
    public class Program
    {
        static void Main(string[] args)
        {
            float[,] A = {
            { float.Parse(args[0]), float.Parse(args[1]) },
            { float.Parse(args[2]), float.Parse(args[3]) }
        };

            float[] b = { float.Parse(args[4]), float.Parse(args[5]) };
            float[] r = new float[2];

            for (int i = 0; i < 2 ; i++)
                for (int j = 0; j < 2; j++)
                    r[i] += A[i, j] * b[j];

            for (int i = 0, test = 0; i < 2 && test >= 0; test++, i++)
                Console.WriteLine($"| {r[i],7:F2} |");
        }
    }
}

/*

float[,] A =
{
    { 1, 2, 3 },
    { 4, 5, 6 }
};

ou 

float[,] A = new float[2,3];

for (int i = 0; i < A.GetLength(0); i++)      // linhas
{
    for (int j = 0; j < A.GetLength(1); j++)  // colunas
    {
        Console.WriteLine(A[i,j]);
    }
}

*/




/***************************************** 
int[,] A =
{
    {1, 2, 3},
    {4, 5, 6}
};
foreach (int value in A)
{
    Console.WriteLine(value);
}
*/
