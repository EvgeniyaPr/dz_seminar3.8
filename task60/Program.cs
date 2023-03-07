// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,,] GenerateMatrix(int quantity1, int quantity2, int quantity3)
{
    Random rand = new Random();
    int[,,] matrix = new int[quantity1, quantity2, quantity3];
    for (int i = 0; i < quantity1; i++)
    {
        for (int j = 0; j < quantity2; j++)
        {
            for (int k = 0; k < quantity3; k++)
            {
                matrix[i, j, k] = rand.Next(10, 100);
            }

        }
    }
    return matrix;
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                System.Console.Write(matrix[i, j, k] + "(" + i + ", " + j + ", " + k + ")" + "\t");
            }
        }
        System.Console.WriteLine();
    }
}

int quantity1 = ReadInt("Введите колчество элеметов для первого измерения: ");
int quantity2 = ReadInt("Введите колчество элеметов для второго измерения: ");
int quantity3 = ReadInt("Введите колчество элеметов для третьего измерения: ");
var myMatrix = GenerateMatrix(quantity1, quantity2, quantity3);
PrintMatrix(myMatrix);
