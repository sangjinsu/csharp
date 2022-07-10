using System.Collections;

namespace csharp6;

class Program
{
    class Map
    {
        private int[,] tiles =
        {
            { 1, 1, 1, 1, 1 },
            { 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0 }
        };

        public void Render()
        {
            var defaultColor = Console.ForegroundColor;
            for (var y = 0; y < tiles.GetLength(1); y++)
            {
                for (var x = 0; x < tiles.GetLength(0); x++)
                {
                    if (tiles[y, x] == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }

                    Console.Write('\u25cf');
                }

                Console.WriteLine();
            }

            Console.ForegroundColor = defaultColor;
        }
    }

    static void Main(string[] args)
    {
        // 2차원 배열
        var arr = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
        var map = new Map();
        //map.Render();

        var list = new List<int>();
        for (var i = 0; i < 5; i++)
        {
            list.Add(i);
        }

        list.Insert(2, 999);

        foreach (var num in list)
        {
            Console.WriteLine(num);
        }

        var dic = new Dictionary<int, int>();
    }
}