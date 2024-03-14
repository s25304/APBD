// See https://aka.ms/new-console-template for more information
using System.IO.IsolatedStorage;

Console.WriteLine("Hello, World!");
//mod1
//mod2
//mod3
static double average(int[] src)
{
    int sum = 0;
    for(int i =0;i < src.Length; i++)
    {
        sum += src[i];
    }
    return (double) sum / src.Length;
}
