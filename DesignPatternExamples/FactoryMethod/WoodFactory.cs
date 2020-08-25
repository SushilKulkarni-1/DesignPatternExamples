namespace FactoryMethod
{
    class WoodFactory : IWoodFactory
    {
        public IWoodProduct CreateProduct(WoodItem woodItem)
        {
            IWoodProduct woodProduct=null;
            switch (woodItem)
            {
                case WoodItem.CricketBat:
                    woodProduct= new CricketBat();
                    break;
                case WoodItem.HockeyStick:
                    woodProduct = new HockeyStick();
                    break;
            }

            return woodProduct;
        }
    }
}
