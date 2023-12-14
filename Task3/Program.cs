int a;
int min(int a)
{
    int cnt=-999999999;
    while(a!=0)
    {
        if(a%10>cnt) {cnt=a%10;}
        a/=10;
    }
    return cnt;
}
int max(int a)
{
    int cnt=999999999;
    while(a!=0)
    {
        if(a%10<cnt) {cnt=a%10;}
        a/=10;
    }
    return cnt;
}
a=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"{max(a)} + {min(a)} = {max(a)+min(a)}");