using System;

namespace Factory.Properties
{
    public class EuropeanSofa : ISofaFactory
    {
        private ITransport transport;
        
        
        public override void Price()
        {
            Console.WriteLine("欧式沙发价格");
        }

        public override void Weight()
        {
            Console.WriteLine("欧式沙发重量");
        }

        public override void Transport(ITransport trans)
        {
            this.transport = trans;
        }
    }
}