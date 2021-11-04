using System;

namespace Factory.Properties
{
    public class ChineseDesk : IDeskFactory
    {
        private ITransport transport;
        
        
        public override void Price()
        {
            Console.WriteLine("中式书桌价格");
        }

        public override void Weight()
        {
            Console.WriteLine("中式书桌重量");
        }

        public override void Transport(ITransport trans)
        {
            this.transport = trans;
        }
    }
}