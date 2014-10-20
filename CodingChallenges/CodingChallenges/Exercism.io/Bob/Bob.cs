using System;
using System.Text.RegularExpressions;
class Bob
{
    public string Hey(string input)
    {
        if (HasAlphabeticCharacters(input)
            && input.Equals(input.ToUpper(), StringComparison.Ordinal))
            return "Whoa, chill out!";
        if (input.EndsWith("?"))
            return "Sure.";
        if (string.IsNullOrWhiteSpace(input))
            return "Fine. Be that way!";
        return "Whatever.";
    }

    /// <summary>
    /// An input can only be classified as shouting if it contains an alphabetic character (according to the test cases)
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public bool HasAlphabeticCharacters(string input)
    {
        return Regex.IsMatch(input, "[A-Z]", RegexOptions.IgnoreCase);
    }
}