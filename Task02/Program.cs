//Задача 26: Напишите программу, которая принимает
//на вход число и выдаёт количество цифр в числе.
//456 -> 3
//78 -> 2
//89126 -> 5

int SumDigit(int digit)
{
    int count = 1;
    while (digit >= 10)
    {
      digit = digit / 10;
      count = count + 1; 
    }
    return count;
}

Console.WriteLine("Введите целое натурально число ");
int number = Convert.ToInt32(Console.ReadLine());

int sumDigit = SumDigit(number);
Console.WriteLine(sumDigit);



