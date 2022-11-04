/*  Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2 */
int []array =new int [new Random().Next(3 ,3)];
for(int i=0;i<array.Length;i++)
{
    array[i]=new Random().Next(100,999);
      Console.WriteLine($"{array[i]}");
Console.WriteLine();
}
int A=0;
foreach(var item in array)
   if (item%2==0)
   A++;

Console.Write(A);