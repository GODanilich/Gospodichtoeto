using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    public class WithoutFlyweight
    {
        public int ModelName { get; private set; }
        public string SN { get; private set; }
        public string ManufacturedIn { get; private set; }
        public int ClockSpeed { get; private set; }
        public int CoreCount { get; private set; }

        public int ThreadCount { get; private set; }

        public string Manufacturer { get; private set; }

        public string Platform { get; private set; }

        public string DDRType { get; private set; }


        public WithoutFlyweight(int modelName, string sN, string manufacturedIn, int clockSpeed, int coreCount, int threadCount, string manufacturer, string platform, string dDRType)
        {
            ModelName = modelName;
            SN = sN;
            ManufacturedIn = manufacturedIn;
            ClockSpeed = clockSpeed;
            CoreCount = coreCount;
            ThreadCount = threadCount;
            Manufacturer = manufacturer;
            Platform = platform;
            DDRType = dDRType;
        }

        public override string ToString()
        {
            return $"Unshared data: Model name = {ModelName}, SN = {SN}, Manufactured in {ManufacturedIn}";
        }
    }
}
