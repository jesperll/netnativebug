namespace App2
{
    // these two lines will result in the .Net Native compiler failing
    interface ISomething<T1, T2> { }
    class Something<T> : ISomething<T[], T[][]> { }
}