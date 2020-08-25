using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            IWoodFactory woodFactory = new WoodFactory();
            var bat = woodFactory.CreateProduct(WoodItem.CricketBat);
            var stick = woodFactory.CreateProduct(WoodItem.HockeyStick);
            Console.ReadKey();
        }
    }    
}
