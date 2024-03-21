using System;

class Program
{
    static bool Polindromo(string word)
    {
        char[] wordChars = word.ToCharArray();
        Array.Reverse(wordChars);
        string wordInverse = new string(wordChars);

        for (int i = 0; i < word.Length; i++)
        {
            if (word[i] != wordInverse[i])
            {
                return false;
            }
        }

        return true;
    }

    static void Main(string[] args)
    {
        Console.WriteLine(Polindromo("bolacha"));
        Console.WriteLine(Polindromo("abelha"));
        Console.WriteLine(Polindromo("asa"));
    }
}
