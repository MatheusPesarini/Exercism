public static class ReverseString
{
    public static string Reverse(string input)
    {
        string reversedInput = "";

        for (int i = 0; i < input.Length; i++)
        {
            reversedInput += $"{input[input.Length - i - 1]}";
        }

        return reversedInput;
    }
}