using System;

namespace Factory.Properties
{
    public class JapanSofa : ISofaFactory
    {
        private ITransport transport;
        
        
        public override void Price()
        {
            Console.WriteLine("日式沙发价格");
        }

        public override void Weight()
        {
            Console.WriteLine("日式沙发重量");
        }

        public override void Transport(ITransport trans)
        {
            this.transport = trans;
        }
    }
}