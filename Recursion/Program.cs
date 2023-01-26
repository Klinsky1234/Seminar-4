/* РЕКУРСИЯ - ЭТО МЕТОД, КОТОРЫЙ ВЫЗЫВАЕТ САМ СЕБЯ */
int Factorial(int n)
{
    if (n == 1) return 1;
    else return n * Factorial(n - 1);
}

Console.WriteLine(Factorial(5)); // 1*2*3*4*5 = 120 - это факториал 5 

/* double Factorial(int n) - кароче, эта хуита не хочет считать !!
{
    if (n == 1) return 1;
    else return n * Factorial(n - 1);
}
for (int i = 0; i < 40; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
} */