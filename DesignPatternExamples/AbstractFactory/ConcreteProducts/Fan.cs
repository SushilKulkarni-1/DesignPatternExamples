namespace AbstractFactory
{
    public class Fan : IElectricProducts
    {
        public Fan()
        {
            System.Console.WriteLine("Fan Created");
        }

        public void GetProductDetails()
        {
            System.Console.WriteLine("Color- Brown . RPM - 1600. Type - Ceiling");
        }
    }
}
