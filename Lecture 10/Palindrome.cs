// Palindrome Checker
// =================
// This program checks whether a given string is a palindrome.
// A palindrome is a word, phrase, number, or other sequence of characters
// that reads the same forward and backward (ignoring spaces, punctuation, and capitalization).
// This implementation uses a recursive approach to check palindromes.

using System;
using System.Text;

class PalindromeChecker
{
    /// <summary>
    /// Checks if a string is a palindrome (recursive implementation)
    /// </summary>
    /// <param name="word">The string to check</param>
    /// <returns>True if the string is a palindrome, false otherwise</returns>
    public static bool IsPalindrome(string word)
    {
        // Base case 1: Empty string or single character is always a palindrome
        if (word.Length <= 1)
        {
            return true;
        }
        
        // Compare first and last characters (case-insensitive)
        char firstChar = char.ToLower(word[0]);
        char lastChar = char.ToLower(word[word.Length - 1]);

        // If characters match, check the substring between them
        if (firstChar == lastChar)
        {
            // Recursive case: Check the substring without the first and last characters
            return IsPalindrome(word.Substring(1, word.Length - 2));
        }
        else
        {
            // Base case 2: First and last characters don't match - not a palindrome
            return false;
        }
    }

    /// <summary>
    /// Enhanced palindrome checker that handles punctuation and spaces
    /// </summary>
    /// <param name="phrase">The phrase to check</param>
    /// <returns>True if the phrase is a palindrome, false otherwise</returns>
    public static bool IsPalindromeEnhanced(string phrase)
    {
        // Normalize the string: remove spaces and punctuation, convert to lowercase
        StringBuilder cleanString = new StringBuilder();
        foreach (char c in phrase)
        {
            if (char.IsLetterOrDigit(c))
            {
                cleanString.Append(char.ToLower(c));
            }
        }
        
        // Use the basic palindrome checker on the cleaned string
        return IsPalindrome(cleanString.ToString());
    }

    /// <summary>
    /// Test harness for palindrome checking functions
    /// </summary>
    public static void Main()
    {
        Console.WriteLine("Palindrome Checker");
        Console.WriteLine("=================");
        
        // Test cases for basic palindrome checker
        Console.WriteLine("\nBasic Palindrome Checker (exact matching):");
        TestPalindrome("navan", IsPalindrome);
        TestPalindrome("racecar", IsPalindrome);
        TestPalindrome("hello", IsPalindrome);
        TestPalindrome("a", IsPalindrome);
        TestPalindrome("", IsPalindrome);
        
        // Test cases for enhanced palindrome checker
        Console.WriteLine("\nEnhanced Palindrome Checker (ignores case and punctuation):");
        TestPalindrome("A man, a plan, a canal, Panama!", IsPalindromeEnhanced);
        TestPalindrome("Was it a car or a cat I saw?", IsPalindromeEnhanced);
        TestPalindrome("No 'x' in Nixon", IsPalindromeEnhanced);
        TestPalindrome("This is not a palindrome", IsPalindromeEnhanced);
    }

    /// <summary>
    /// Helper method to test palindrome functions and display results
    /// </summary>
    /// <param name="input">String to test</param>
    /// <param name="palindromeFunc">Palindrome checking function to use</param>
    private static void TestPalindrome(string input, Func<string, bool> palindromeFunc)
    {
        bool result = palindromeFunc(input);
        Console.WriteLine($"'{input}': {(result ? "IS a palindrome" : "NOT a palindrome")}");
    }
}