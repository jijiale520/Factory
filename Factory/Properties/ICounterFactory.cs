namespace Factory.Properties
{
    public abstract class ICounterFactory
    {
        public abstract void Price();
        public abstract void Weight();
        public abstract void SetTransport(ITransport trans);
    }
}