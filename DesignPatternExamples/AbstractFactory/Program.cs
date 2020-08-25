using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            FactoryProvider factoryProvider = new FactoryProvider();
            IProductFactory productFactoryIndia = factoryProvider.GetProductFactory(FactoryLocation.India);
            productFactoryIndia.CreateElectricProducts().GetProductDetails();
            productFactoryIndia.CreateElectronicProducts().GetProductDetails();

            IProductFactory productFactoryChina = factoryProvider.GetProductFactory(FactoryLocation.China);
            productFactoryChina.CreateElectricProducts().GetProductDetails();
            productFactoryChina.CreateElectronicProducts().GetProductDetails();

            Console.ReadKey();
        }
    }
}
