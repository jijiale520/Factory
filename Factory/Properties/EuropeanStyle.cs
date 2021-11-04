namespace Factory.Properties
{
    public class EuropeanStyle : IProduce
    {
        public ISofaFactory ProduceSofa()
        {
            return new EuropeanSofa();
        }

        public IDeskFactory ProduceDesk()
        {
            return new EuropeanDesk();
        }

        public ICounterFactory ProdunceCounter()
        {
            return new ChineseCounter();
        }
    }
}