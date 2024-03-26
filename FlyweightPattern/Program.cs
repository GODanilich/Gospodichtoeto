// See https://aka.ms/new-console-template for more information
using FlyweightPattern;

int n = 100000000;

 FlyweightFactory flyweightFactory = new FlyweightFactory();

List<UnsharedProcessor> unsharedProcessors = new List<UnsharedProcessor>();

for (int i = 0; i < n; i++)
{
    unsharedProcessors.Add(new UnsharedProcessor("intel", i.ToString(), "2024"));
} 


/* WithoutFlyweight without = new WithoutFlyweight("intel", 1.ToString(), "2024", 5000, 8, 16, "intel", "LGA1700", "DDR4");

List<WithoutFlyweight> list = new List<WithoutFlyweight>();

WithoutFlyweight[] m1 = new WithoutFlyweight[n];

for (int i = 0; i < n; i++)
{
    list.Add(new WithoutFlyweight("intel", 1.ToString(), "2024",  5000, 8, 16, "intel", "LGA1700", "DDR4"));
}
*/


UnsharedProcessor intel = new UnsharedProcessor("intel", 1.ToString(), "2024");

//unsafe { Console.WriteLine(sizeof(WithoutFlyweight)); }

//Console.WriteLine($"{intel}\n{intel.flyweight(flyweightFactory)}");

Console.ReadLine();
