using System;
using System.Collections.Generic;
using System.Linq;

namespace Iterator
{
    class MidDayNewsPapaerIterator : IIterator
    {
        private readonly List<string> _employees;
        int _current;
        public MidDayNewsPapaerIterator(List<string> employees)
        {
            _employees = employees;
            _current = 0;
        }
        public string GetCurrent()
        {
            return _employees.ElementAt(_current);
        }

        public string GetFirst()
        {
           return  _employees.First();
        }

        public string GetLast()
        {
            return _employees.Last();
        }

        public bool IsDone()
        {
            return _current >= _employees.Count - 1;
        }

        public string Next()
        {
            _current++;
            return _employees.ElementAt(_current);
        }
    }
}
