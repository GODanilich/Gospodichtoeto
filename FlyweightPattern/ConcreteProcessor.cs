using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    public class ConcreteProcessor : IFlyweight
    {

        public int ClockSpeed { get; private set; }
        public int CoreCount { get; private set; }

        public int ThreadCount { get; private set; }

        public string Manufacturer { get; private set; }

        public string Platform { get; private set; }

        public string DDRType {  get; private set; }

        public ConcreteProcessor (int clockSpeed, int coreCount, int threadCount, string manufacturer, string platform, string dDRType)
        {
            ClockSpeed = clockSpeed;
            CoreCount = coreCount;
            ThreadCount = threadCount;
            Manufacturer = manufacturer;
            Platform = platform;
            DDRType = dDRType;
        }

        public IFlyweight Operation()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"Concrete data: Clock speed = {ClockSpeed}, core count = {CoreCount}, thread count = {ThreadCount}, manufacturer = {Manufacturer}, platform = {Platform}, ddr type: {DDRType}";
        }
    }
}
