Console.WriteLine("Input number a");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number b");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number c");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if(a > max ) max = a;
if(b > max ) max = b;
if(c > max ) max = c;

Console.Write("max = " + max);