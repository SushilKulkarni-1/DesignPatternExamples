using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class FactoryProvider
    {
        public IProductFactory GetProductFactory(FactoryLocation factoryLocation)
        {
            IProductFactory factory = null;
            switch (factoryLocation)
            {
                case FactoryLocation.India:
                    factory= new IndiaFactory();
                    break;
                case FactoryLocation.China:
                    factory = new ChinaFactory();  
                    break;
                default:
                    factory= null;
                    break;
            }

            return factory;
        }
    }
}
