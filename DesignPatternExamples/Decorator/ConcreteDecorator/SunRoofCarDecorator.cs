namespace Decorator
{
    public class SunRoofCarDecorator : CarDecorator
    {
        private readonly ICar _car;
        private readonly string _description;
        public SunRoofCarDecorator(ICar car) : base(car)
        {
            _car = car;
            _description = "Glass SunRoof  ";
        }

        public override string GetDescription() => _car.GetDescription() + "," + _description;

        public override double GetPrice() => _car.GetPrice() + 7000;
    }


}
