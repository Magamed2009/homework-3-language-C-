﻿int a,b;
a=Convert.ToInt32(Console.ReadLine());
int[] arr = new int[a];
for (int i = 0; i < a; i++)
{
    arr[i]=Convert.ToInt32(Console.ReadLine());
}
b=Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < a; i++)
{
    System.Console.Write($"{arr[i]+b} ");
}