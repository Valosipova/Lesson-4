//Напишите программу, которая задаёт массив из 8 целых чисел с клавиатуры и 
// далее выводит массив на экран в одну строку.

int [] number = new int[8];
Console.Write("(");

for (int i = 0; i < number.Length; i++)
 {
    number [i] = new Random().Next(0, 11);
    Console.Write(" " + Method (i) + " ");
 }
Console.Write(")");

int Method (int a)
{
    return number[a];
}
