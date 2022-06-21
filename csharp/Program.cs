namespace CSharp
{
    class Program
    {
        static int Add(int a, int b)
        {
            return a + b;
        }

        static void AddOne(ref int a)
        {
            a = a + 1;
        }

        static void Divide(int a, int b, out int result1)
        {
            result1 = a / b;
        }
        
        static void Main(string[] args)
        {
            const string b = "123456";
            Console.WriteLine(b);

            if (true)
            {
                Console.WriteLine("hello tired day");
            }

            int result1;
            Divide(10,3, out result1);
            Console.WriteLine(result1);
        }
    }
}