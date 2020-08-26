namespace Decorator
{
    public class NavigationCarDecorator : CarDecorator
    {
        private readonly ICar _car;
        private readonly string _description;
        public NavigationCarDecorator(ICar car) :base(car)
        {
            _car = car;
            _description = "Navigation system";
        }

        public override string GetDescription() => _car.GetDescription() + "," + _description;

        public override double GetPrice() => _car.GetPrice() + 3000;
    }


}
