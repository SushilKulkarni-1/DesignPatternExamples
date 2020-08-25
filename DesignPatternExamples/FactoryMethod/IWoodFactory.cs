namespace FactoryMethod
{
    public interface IWoodFactory
    {
        IWoodProduct CreateProduct(WoodItem woodItem);
    }
}
