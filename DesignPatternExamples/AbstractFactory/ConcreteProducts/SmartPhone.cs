namespace AbstractFactory
{
    internal class SmartPhone : IElectronicProducts
    {
        public SmartPhone()
        {
            System.Console.WriteLine(" SmartPhone created");
        }

        public void GetProductDetails()
        {
            System.Console.WriteLine("Color- White . Battery-6000 mah. Camera - 20 MP");
        }
    }

}
