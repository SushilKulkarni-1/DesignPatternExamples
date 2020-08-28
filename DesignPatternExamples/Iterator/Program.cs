using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            INewsPaperCompany timesNews = new TimesNewsPaper();
            INewsPaperCompany midDayNews = new MidDayNewsPaper();

            IIterator timesNewsIterator = timesNews.CreateIterator();
            IIterator midDayNewsIterator = midDayNews.CreateIterator();

            Console.WriteLine(" Times News Paper Employees");
            PrintEmployees(timesNewsIterator);


            Console.WriteLine(" Mid Day Paper Employees");
            PrintEmployees(midDayNewsIterator);

            Console.ReadKey();


        }

        private static void PrintEmployees(IIterator iterator)
        {
            Console.WriteLine(iterator.GetFirst());
            while(!iterator.IsDone())
            {
                Console.WriteLine(iterator.Next());
            }
        }
    }
}
