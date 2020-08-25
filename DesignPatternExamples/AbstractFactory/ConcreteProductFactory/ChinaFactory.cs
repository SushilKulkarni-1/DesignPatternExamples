namespace AbstractFactory
{
    internal class ChinaFactory : IProductFactory
    {       

        IElectricProducts IProductFactory.CreateElectricProducts()
        {
           return new WaterHeater();
        }

        IElectronicProducts IProductFactory.CreateElectronicProducts()
        {
            return new SmartPhone();
        }
    }

}
