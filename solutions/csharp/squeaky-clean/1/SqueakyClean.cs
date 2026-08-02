using System.Text;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        var builder = new StringBuilder();
        bool isKebab = false;

        if (identifier == "")
        {
            return "";
        }

        foreach (char c in identifier)
        {

            if (c == ' ')
            {
                builder.Append('_');
            }
            else if (char.IsControl(c))
            {
                builder.Append("CTRL");
            }
            else if (c == '-')
            {
                isKebab = true;
            }
            else if (char.IsLetter(c))
            {
                if (c >= 'α' && c <= 'ω')
                {
                    continue;
                }

                if (isKebab)
                {
                    builder.Append(char.ToUpper(c));
                    isKebab = false;
                }
                else
                {
                    builder.Append(c);
                }
            }
        }

        return builder.ToString();
    }
}
