namespace Factory.Properties
{
    public class ChineseStyle : IProduce
    {
        public ISofaFactory ProduceSofa()
        {
            return new ChineseSofa();
        }

        public IDeskFactory ProduceDesk()
        {
            return new ChineseDesk();
        }

        public ICounterFactory ProdunceCounter()
        {
            return new ChineseCounter();
        }
    }
}