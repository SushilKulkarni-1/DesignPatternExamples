namespace AbstractFactory
{
    public class SmartTV : IElectronicProducts
    {
        public SmartTV()
        {
            System.Console.WriteLine("SmartTV Created");
        }

        public void GetProductDetails()
        {
            System.Console.WriteLine("Color- Black . Watt - 100. Type - Wall Mount TV");
        }
    }

}
