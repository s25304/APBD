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
        sum += src[i];//zmiana pod knflikt
    }
    return (double) sum / src.Length;
}
static int max(int[] src)
{
    int max = src[0];
    for (int i = 1; i < src.Length; i++)
    {
        if (src[i] > max) max = src[i];
    }
    return max;
}
