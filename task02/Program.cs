// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, 
// что такого элемента нет. 
// Например, задан массив: 
// 1 4 7 2 
// 5 9 2 3 
// 8 4 2 4 
// 17 -> такого числа в массиве нет


int rows = GetNum("Введите количество строк: ");
int columns = GetNum("Введите количество столбцов: ");
int[,] array = GetArray(rows, columns);
PrintArray(array);


int NumbInRow = GetNum("Введите номер элемента в строке: ");
int NumbInColumn = GetNum("Введите номер элемента в столбце: ");

int GetResult = FindElement(array, NumbInRow, NumbInColumn);



int GetNum(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int[,] GetArray(int row, int column)
{
    int[,] res = new int[row, column];
    for(int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            res[i,j] = new Random().Next(1,10);
        }
    }
    return res;
}


void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) 
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

int FindElement(int[,] array, int row, int column)
{
    
    if (row < array.GetLength(0) && column < array.GetLength(1))
    {
        Console.WriteLine(array[row, column]);
         return array[row, column];
    }
    else
    {
        Console.WriteLine($"{row}{column} -> такого числа в массиве нет");
        return -1;
    }
}
