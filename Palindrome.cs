using System;

public class Code
{
    public static void Main(string[] args)
    {
        // introduce user to the rules
        while (true)
        {
            Console.WriteLine("Welcome to THE GAME");
            Console.WriteLine($"We will check if the word \nyou pass is the same inverted");

            // ask for word to check
            Console.WriteLine("Pass the word: ");
            string word = Console.ReadLine(); 

            // inform user about outcome
            if (IsPalindrome(word))
            {
                Console.WriteLine("Yes, the word is the same forwards and backwards!");
            }
            else
            {
                Console.WriteLine("No, the word is not the same forwards and backwards.");
            }

            // ask user if they wanna play one more
            Console.WriteLine("Do you want to play again? (yes/no)");
            string playAgain = Console.ReadLine().ToLower();
            if (playAgain != "yes")
            {
                break; 
            }
        }
    }

    // check if reverse equal normail(palindrome)
    public static bool IsPalindrome(string word)
    {
        if (word == null) return false;

        string reversedWord = Reverse(word);
        return word.Equals(reversedWord, StringComparison.OrdinalIgnoreCase); 
    }

    // reversing string
    public static string Reverse(string word)
    {
        if (word == null) return null;

        char[] array = word.ToCharArray();
        Array.Reverse(array);
        return new string(array);
    }
}
