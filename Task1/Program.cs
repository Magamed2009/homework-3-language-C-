int a;
void Add(int a)
{
    int cnt=0;
    while(a!=0)
    {
        if(a%10%2==0) {cnt++;}
        a/=10;
    }
    System.Console.WriteLine($"Even:{cnt}");
}
void Subtract(int a)
{
    int cnt=0;
    while(a!=0)
    {
        if(a%10%2!=0) {cnt++;}
        a/=10;
    }
    System.Console.WriteLine($"Odd:{cnt}");
}
void Multiply(int a)
{
    int cnt=0;
    while(a!=0)
    {
        cnt++;
        a/=10;
    }
    System.Console.WriteLine($"Digit:{cnt}");
}
void Division(int a)
{
    int cnt=0;
    while(a!=0)
    {
        cnt+=a%10;
        a/=10;
    }
    System.Console.WriteLine($"Sum:{cnt}");
}
a=Convert.ToInt32(Console.ReadLine());
Add(a);
Subtract(a);
Multiply(a);
Division(a);