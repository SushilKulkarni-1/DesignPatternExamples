namespace AbstractFactory
{
    public class IndiaFactory : IProductFactory
    {      

        IElectricProducts IProductFactory.CreateElectricProducts()
        {
           return new Fan();
        }

        IElectronicProducts IProductFactory.CreateElectronicProducts()
        {
           return new SmartTV();
        }
    }

}
