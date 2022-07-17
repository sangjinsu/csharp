namespace CShap;

class Program
{
    class TestException : Exception
    {
    }

    static void TestFunc()
    {
        throw new TestException();
    }

    static void Main(string[] args)
    {
        try
        {
            // var a = 10;
            // var b = 0;
            // var result = a / b;
            TestFunc();
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine(e);
            throw;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
        finally
        {
            // DB, 파일 정리 등등 
        }
    }
}