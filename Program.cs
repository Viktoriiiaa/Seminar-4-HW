// Напишите программу, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B (Math.Pow НЕ использовать)

/*
int NumberPower(int number1, int number2)
{
    int power = 1;
    for (int i = 1; i <= number2; ++i)
    {
        power = number1 * power;
    }
    return power;
}

Console.WriteLine("Введите число A: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int power = NumberPower(number1, number2);
Console.WriteLine(power);
*/

// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

/*
Console.WriteLine("Enter a number");
int i = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while (i > 0)
{
    int num = i % 10;
    i = i / 10;
    sum = sum + num;
}
Console.WriteLine("The sum of all digits is equal to: " + sum);
*/

// Напишите программу, которая создает массив заданного пользователем размера, заполняет массив элементами от 1 до 99 и выводит их на экран.
/*

int [] CreatRandArray (int n)
{
    int [] arr = new int [n];
    for (int i = 0; i< n; i++)
    {
        arr[i] = new Random().Next(0,98);
    }
    return arr; 
}

void PrintArray(int [] arr)
{
    for (int i = 0; i< arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

Console.WriteLine("Введите размер массива: ");
int number1 = Convert.ToInt32(Console.ReadLine());

PrintArray(CreatRandArray(number1));
*/
