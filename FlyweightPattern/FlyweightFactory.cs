using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FlyweightPattern
{
    public class FlyweightFactory
    {
        private Dictionary<string, IFlyweight> flyweights = new Dictionary<string, IFlyweight>();

        public FlyweightFactory() 
        {
            flyweights.Add("intel", new ConcreteProcessor(5000, 8, 16, "intel", "LGA1700", "DDR4"));
        }

        public IFlyweight? GetFlyweight(string key)
        {
            if (flyweights.ContainsKey(key)) return flyweights[key];
            else return null;
        }
    }
}
