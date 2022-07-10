namespace csharp5;

class Program
{
    static int GetHightestScore(int[] scores)
    {
        return scores.Max();
    }

    static int GetAverageScore(int[] scores)
    {
        if (scores.Length == 0)
        {
            return 0;
        }

        return (int)scores.Average();
    }

    static int GetIndexOf(int[] scores, int score)
    {
        for (var i = 0; i < scores.Length; i++)
        {
            if (scores[i] == score)
            {
                return i;
            }
        }

        return -1;
    }

    static void Sort(int[] scores)
    {
        Array.Sort(scores);
    }

    static void Main(string[] args)
    {
        var scores = new int[5];
        for (var i = 0; i < scores.Length; i++)
        {
            scores[i] = 10 * (i + 1);
        }

        foreach (var score in scores)
        {
            Console.WriteLine(score);
        }
    }
}