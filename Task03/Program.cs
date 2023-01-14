//Задача 28: Напишите программу, которая    4: 1*2*3*4=24
//принимает на вход число N и выдаёт
//произведение чисел от 1 до N.
//4 -> 24
//5 -> 120

int Multiplication(int number)
{
    int multi = 1;
    for (int i = 1; i <= number; i++)
    {
        multi = multi * i;
    }
    return multi;
}

Console.WriteLine("Введите целое натурально число которое больше 0 ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
    int numberMulty = Multiplication(number);
    Console.WriteLine(numberMulty);
}
else
{
    Console.WriteLine("Введенное число должно быть больше 0");
}


