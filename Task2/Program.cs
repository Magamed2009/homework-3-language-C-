int a,b;
void Add(int a,int b)
{
    System.Console.WriteLine($"Add:{a+b}");
}
void Subtract(int a,int b)
{
    System.Console.WriteLine($"Subtract:{a-b}");
}
void Multiply(int a,int b)
{
    System.Console.WriteLine($"Multiply:{a*b}");
}
void Division(int a,int b)
{
    System.Console.WriteLine($"Division:{a/b}");
}
a=Convert.ToInt32(Console.ReadLine());
b=Convert.ToInt32(Console.ReadLine());
Add(a,b);
Subtract(a,b);
Multiply(a,b);
Division(a,b);