using System;

namespace Iterator
{
    class TimesNewsPapaerIterator : IIterator
    {
        private string[] _employees;
        int _current;
        public TimesNewsPapaerIterator(string[] employees)
        {
            _employees = employees;
            _current = 0;
        }
        public string GetCurrent()
        {
            return _employees[_current];
        }

        public string GetFirst()
        {
            return _employees[_current];
        }

        public string GetLast()
        {
            return _employees[_employees.Length-1];
        }

        public bool IsDone()
        {
            return _current >= _employees.Length - 1;
        }

        public string Next()
        {
            _current++;
            return _employees[_current];
        }
    }
}
