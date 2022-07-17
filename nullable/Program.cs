namespace Nullable;

class Program
{
    static int Find()
    {
        return 0;
    }

    static void Main(string[] args)
    {
        int? number = null;
        var i = number.Value;
    }
}