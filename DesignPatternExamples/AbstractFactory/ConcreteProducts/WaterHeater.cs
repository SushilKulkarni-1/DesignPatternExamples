namespace AbstractFactory
{
    public class WaterHeater : IElectricProducts
    {
        public WaterHeater()
        {
            System.Console.WriteLine("WaterHeater Created");
        }

        public void GetProductDetails()
        {
            System.Console.WriteLine("Color- Gray . Watt - 100. Type - Wall Mount");
        }
    }
}
