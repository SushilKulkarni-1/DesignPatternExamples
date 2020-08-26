namespace Decorator
{
    public abstract class CarDecorator : ICar
    {
        private ICar _car;
        public CarDecorator(ICar car)
        {
            _car = car;
        }
        public abstract string GetDescription();

        public abstract double GetPrice() ;
    }


}
