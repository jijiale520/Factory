namespace Factory.Properties
{
    public abstract class ISofaFactory
    {
        public abstract void Price();
        public abstract void Weight();

        public abstract void Transport(ITransport trans);
    }
}