using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FlyweightPattern
{
    public class FlyweightFactory
    {
        private Dictionary<int, IFlyweight> flyweights = new Dictionary<int, IFlyweight>();

        public FlyweightFactory() 
        {
            flyweights.Add((int)Entity.Intel, new ConcreteProcessor(5000, 8, 16, "intel", "LGA1700", "DDR4"));
            flyweights.Add((int)Entity.AMD, new ConcreteProcessor(5500, 16, 32, "AMD", "AM5", "DDR5"));
        }

        public IFlyweight? GetFlyweight(int key)
        {
            if (flyweights.ContainsKey(key)) return flyweights[key];
            else return null;
        }
    }
}
