using System;

namespace Factory.Properties
{
    public class JapanDesk : IDeskFactory
    {
        private ITransport transport;
        
        
        public override void Price()
        {
            Console.WriteLine("日式书桌价格");
        }

        public override void Weight()
        {
            Console.WriteLine("日式书桌重量");
        }

        public override void Transport(ITransport trans)
        {
            this.transport = trans;
        }
    }
}