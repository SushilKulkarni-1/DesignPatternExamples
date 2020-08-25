namespace AbstractFactory
{
    public interface IProductFactory
    {
        IElectricProducts CreateElectricProducts();
        IElectronicProducts CreateElectronicProducts();
    }
}
