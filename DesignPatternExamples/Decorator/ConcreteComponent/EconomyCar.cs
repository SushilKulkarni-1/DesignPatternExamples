namespace Decorator
{
    public class EconomyCar : ICar
    {
        public string GetDescription() => "Economy Car";

        public double GetPrice() => 10000;
    }


}
