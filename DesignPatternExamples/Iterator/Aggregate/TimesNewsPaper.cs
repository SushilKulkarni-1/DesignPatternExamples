namespace Iterator
{
    class TimesNewsPaper : INewsPaperCompany
    {
        string[] _employees = new  string[10];
        public TimesNewsPaper()
        {
            _employees[0] = "Times - EMP1";
            _employees[1] = "Times - EMP2";
            _employees[2] = "Times - EMP3";
            _employees[3] = "Times - EMP4";
            _employees[4] = "Times - EMP5";
        }


        public IIterator CreateIterator()
        {
            return new TimesNewsPapaerIterator(_employees);
        }
    }
}
