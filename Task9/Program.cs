int a,b;
int sum(int a,int b)
{
    if(a<=b) {return a;}
    else {return b;} 
}
a=Convert.ToInt32(Console.ReadLine());
b=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(sum(a,b));