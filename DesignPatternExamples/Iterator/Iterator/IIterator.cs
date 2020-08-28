namespace Iterator
{
    interface IIterator
    {
        string GetFirst();
        string GetLast();
        string GetCurrent();
        bool IsDone();
        string Next();
    }
}
