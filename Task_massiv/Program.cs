// метод войд принт эрей принимает 2мерную табл чисел и выводит её на экран 
void PrintArray(int[,] matr) // в качестве арг. передаём прямоугольную табл чисел заполненную случ знач
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}
int[,] matrix = new int[3, 7];
PrintArray(matrix); // выше мы создали метод Принтэррей а тут мы его распечатываем 
Console.WriteLine();
FillArray(matrix); // тут мы вызываем массив заполненный случайными числами от 1 до 9
PrintArray(matrix); //  распечатываем 