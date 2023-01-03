// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int x=20;
int y=30;

bool checkSame= x==y;

Console.WriteLine(checkSame);

x*=2;
Console.WriteLine(x);

bool isSuccess=false;

if (checkSame && isSuccess)
    Console.WriteLine("GOOD");
    else
    Console.WriteLine("BAD");