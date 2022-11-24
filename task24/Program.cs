// Задача 24. Напишите программу, которая принимает на вход число (А) и выдает сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

//Console.WriteLine(GetSum(4));

//int GetSum(int num)
//{
//    int sum = 0;
//    for(int i = 1; i <= num; i++)
//    {
//        sum += i; //sum = sum + i
//    }
//    return sum;
//}

int num = 125;
Console.WriteLine("Sum: " + GetSum(num));
Console.WriteLine($"In program{num}");

int GetSum(int num)
{
    int sum = 0;
    for(int i = 1; i <= num; i++)
    {
        sum += i;
    }
    num += 125;
    Console.WriteLine($"In method {num}");
    return sum;
}
