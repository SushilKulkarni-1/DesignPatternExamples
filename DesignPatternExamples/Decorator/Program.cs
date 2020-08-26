using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            ICar economyCar = new EconomyCar();

            economyCar = new NavigationCarDecorator(economyCar);
            economyCar = new SunRoofCarDecorator(economyCar);

            Console.WriteLine(economyCar.GetDescription());
            Console.WriteLine(economyCar.GetPrice());

            Console.WriteLine("=================================================");
            ICar laxuaryCar = new LaxuaryCar();
            laxuaryCar = new NavigationCarDecorator(laxuaryCar);
            laxuaryCar = new SunRoofCarDecorator(laxuaryCar);

            Console.WriteLine(laxuaryCar.GetDescription());
            Console.WriteLine(laxuaryCar.GetPrice());

            Console.ReadKey();
        }
    }
}
