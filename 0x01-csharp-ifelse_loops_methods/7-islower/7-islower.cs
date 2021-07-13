using System;

class Character
{
    public static bool IsLower(char c)
    {
        string alphabet = "abcdefghijklmnopqrstuvwxyz";
        return alphabet.Contains(c);
    }
}
