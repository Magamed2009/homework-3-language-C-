int a,b;
void sum(int a,int b)
{
    int cnt=1;
    for(int i=1; i<=b; i++)
    {
        cnt*=a;
    }
    System.Console.WriteLine(cnt);
}
System.Console.Write($"x = ");
a=Convert.ToInt32(Console.ReadLine());
System.Console.Write($"y = ");
b=Convert.ToInt32(Console.ReadLine());
sum(a,b);