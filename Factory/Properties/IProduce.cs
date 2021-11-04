namespace Factory.Properties
{
    public interface IProduce
    {
        ISofaFactory ProduceSofa();
        IDeskFactory ProduceDesk();
        ICounterFactory ProdunceCounter();
    }
}