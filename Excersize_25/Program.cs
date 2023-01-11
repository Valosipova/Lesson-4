//  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A
// в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

int numberA= 0;
int numberB = 0;
int sum = 0;

while(true)
{
    Console.WriteLine("Введите целое число А:");

    if(int.TryParse(Console.ReadLine(), out int number))
    {
        numberA = number; 
        break;
    }
    else Console.WriteLine("Число введено некорректно");
}

while(true)
{
    Console.WriteLine("Введите целое натуральное число В: ");

    if(int.TryParse(Console.ReadLine(), out int number))
    {
        if(number < 0) 
        {
            Console.WriteLine("Введено отрицательное число");
        }
        else numberB = number; 
        break;
    }
    else Console.WriteLine("Число введено некорректно");
}

Console.WriteLine("Число " + numberA + " в степени " + numberB + " = " + Calculate(numberA, numberB));


int Calculate(int A, int B)
{
    if (A == 0 && B == 0)
    {
        sum = 1;
    }
    else
    {
        sum = A;
        for(int i = 1; i < B; i++)
        {
            sum = sum * A;
        }
    }
    return sum;
}


