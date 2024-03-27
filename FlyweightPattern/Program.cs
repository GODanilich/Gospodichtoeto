// See https://aka.ms/new-console-template for more information
using FlyweightPattern;

int n = 10000000;

 FlyweightFactory flyweightFactory = new FlyweightFactory();

List<UnsharedProcessor> unsharedProcessors = new List<UnsharedProcessor>();
/*
for (int i = 0; i < n/2; i++)
{
    unsharedProcessors.Add(new UnsharedProcessor((int)Entity.Intel, i.ToString(), "2024"));
    unsharedProcessors.Add(new UnsharedProcessor((int)Entity.AMD, i.ToString(), "2024"));
} 
*/

WithoutFlyweight without = new WithoutFlyweight((int)Entity.Intel, 1.ToString(), "2024", 5000, 8, 16, "intel", "LGA1700", "DDR4");

List<WithoutFlyweight> list = new List<WithoutFlyweight>();

WithoutFlyweight[] m1 = new WithoutFlyweight[n];

for (int i = 0; i < n; i++)
{
    list.Add(new WithoutFlyweight((int)Entity.Intel+i, i.ToString(), $"2024{i}",  5000+i, 8+i, 16 + i, $"intel{i}", $"LGA1700{i}", $"DDR4{i}"));
}



UnsharedProcessor intel = new UnsharedProcessor((int)Entity.Intel, 1.ToString(), "2024");
UnsharedProcessor amd = new UnsharedProcessor((int)Entity.AMD, 2.ToString(), "2024");

//unsafe { Console.WriteLine(sizeof(WithoutFlyweight)); }

Console.WriteLine($"{intel}\n{intel.flyweight(flyweightFactory)}");
Console.WriteLine($"{amd}\n{amd.flyweight(flyweightFactory)}");

Console.ReadLine();
