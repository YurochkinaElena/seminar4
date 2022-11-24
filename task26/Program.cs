// Задача 26. Напишите программу, которая принимает на вход число и выдает количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5


// 1 способ
//Console.WriteLine(GetCount(6547));

//int GetCount(int num)
//{
//    int length = 0;
//    while (num > 0)
//    {
//        length++;
//        num /= 10;  //num = num /10
//    }
//    return length;
//}


//2способ

var num1 = Convert.ToInt32(Console.ReadLine());
var length = GetCount(num1);
Console.WriteLine(length);

int GetCount(int num)
{
   int length = 0;
   while (num > 0)
    {
        length++;
        num /= 10;  //num = num /10
    }
    return length;
}