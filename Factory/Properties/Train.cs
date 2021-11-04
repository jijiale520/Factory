using System;

namespace Factory.Properties
{
    public class Train : ITransport
    {
        public void Speed()
        {
            Console.WriteLine("火车运输速度");
        }

        public void Price()
        {
            Console.WriteLine("火车运输价格");
        }
    }
}