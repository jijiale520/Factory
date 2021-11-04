using System;

namespace Factory.Properties
{
    public class ChineseCounter : ICounterFactory
    {
        private ITransport transport;
        public override void Price()
        {
            Console.WriteLine("中式柜台价格");
        }

        public override void Weight()
        {
            Console.WriteLine("中式柜台重量");
        }

        public override void SetTransport(ITransport trans)
        {
            this.transport = trans;
        }
    }
}