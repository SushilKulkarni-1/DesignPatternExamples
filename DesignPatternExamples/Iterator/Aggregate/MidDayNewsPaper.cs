using System.Collections.Generic;
using System.Diagnostics;

namespace Iterator
{
    class MidDayNewsPaper : INewsPaperCompany
    {
        private List<string> _employees = new List<string>();
        public MidDayNewsPaper()
        {
            _employees.Add("MidDay - Employee Name - EM1");
            _employees.Add("MidDay - Employee Name - EM2");
            _employees.Add("MidDay - Employee Name - EM3");
            _employees.Add("MidDay - Employee Name - EM4");
        }

        public IIterator CreateIterator()
        {
            return new MidDayNewsPapaerIterator(_employees);
        }
    }
}
