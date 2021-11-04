namespace Factory.Properties
{
    public class JapanStyle : IProduce
    {
        public ISofaFactory ProduceSofa()
        {
            return new JapanSofa();
        }

        public IDeskFactory ProduceDesk()
        {
            return new JapanDesk();
        }

        public ICounterFactory ProdunceCounter()
        {
            return new JapanCounter();
        }
    }
}