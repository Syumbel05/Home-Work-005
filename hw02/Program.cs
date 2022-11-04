/*Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0

*/
int []array =new int [new Random().Next(4 ,4)];
int sum=0;
int sum1=0;
for(int i=0;i<array.Length;i++)
{
    array[i]=new Random().Next(-6,89);
      Console.WriteLine($"{array[i]}");
Console.WriteLine();
if (i%2==0)
sum=sum+array[i];
else 
sum1=sum1+array[i];

}


Console.Write("сумму элементов, стоящих на нечётных позициях " + sum1);