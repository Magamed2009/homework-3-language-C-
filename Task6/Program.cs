int a;
void sum(int a)
{
    int cnt=0;
    for(int i=1; i<=a; i++)
    {
        if(a%i==0) {System.Console.Write($"{i} "); cnt++;}
    }
    System.Console.WriteLine($"\n{cnt}");
}
a=Convert.ToInt32(Console.ReadLine());
sum(a);