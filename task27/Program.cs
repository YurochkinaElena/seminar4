// задача 27. Напишите программу, которая принимает на вход число и выдает произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine(Getmultiply(9));
int Getmultiply(int num)
{
    int result = 1;
    for(int i = 1; i <= num; i++)
    {
        result *= i;
    }
    return result;
}
