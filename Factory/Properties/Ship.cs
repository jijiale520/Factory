using System;

namespace Factory.Properties
{
    public class Ship : ITransport
    {
        public void Speed()
        {
            Console.WriteLine("轮船运输速度");
        }

        public void Price()
        {
            Console.WriteLine("轮船运输价格");
        }
    }
}