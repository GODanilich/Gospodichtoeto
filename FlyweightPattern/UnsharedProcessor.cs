using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    public class UnsharedProcessor
    {   
        public string ModelName { get; private set; }
        public string SN {  get; private set; }
        public string ManufacturedIn { get; private set; }

        public UnsharedProcessor(string modelName, string sN, string manufacturedIn)
        {
            ModelName = modelName;
            SN = sN;
            ManufacturedIn = manufacturedIn;
        }

        public IFlyweight? flyweight(FlyweightFactory factory)
        {
            return factory.GetFlyweight(ModelName);
        }

        public override string ToString()
        {
            return $"Unshared data: Model name = {ModelName}, SN = {SN}, Manufactured in {ManufacturedIn}";
        }
    }
}
