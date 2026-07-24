public static class PythagoreanTriplet
{
    public static IEnumerable<(int a, int b, int c)> TripletsWithSum(int sum)
    {
        int a, b, c;

        for (a = 1; a < sum / 3; a++)
        {
            for (b = a + 1; b < sum / 2; b++)
            {
                c = sum - a - b;

                if (a < b && b < c && a < c)
                {
                    if ((a * a + b * b) == c * c)
                    {
                        yield return (a, b, c);
                    }
                }
            }
        }
    }
}