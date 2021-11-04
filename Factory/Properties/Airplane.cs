using System;

namespace Factory.Properties
{
    public class Airplane : ITransport
    {
        public void Speed()
        {
            Console.WriteLine("飞机运输速度");
        }

        public void Price()
        {
            Console.WriteLine("飞机运输价格");
        }
    }
}