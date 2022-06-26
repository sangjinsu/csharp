namespace CSharp
{
    class Program
    {
        static int Add(int a, int b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            int ret = Add(5, 100);
            Console.WriteLine(ret);
        }
    }
}