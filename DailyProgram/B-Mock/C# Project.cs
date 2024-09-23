using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Instantiate the ManipulationMethod class
        ManipulationMethod manipulationMethod = new ManipulationMethod();

        // Find Palindrome Word
        Console.WriteLine("----Find Palindrome Word-----");
        string word = "malayalam";
        bool result = manipulationMethod.IsPalindrome(word);
        Console.WriteLine($"Palindrome Result: {result}");

        // Count Words
        Console.WriteLine("----Count Words-----");
        string words = "The quick brown fox jumps over the lazy dog";
        int countWords = manipulationMethod.CountWords(words);
        Console.WriteLine($"Count Words Result: {countWords}");

        // Reverse Words
        Console.WriteLine("----Reverse Words-----");
        string sentence = "The quick brown fox jumps over the lazy dog";
        string reversedWords = manipulationMethod.ReverseWords(sentence);
        Console.WriteLine($"Reverse Words Result: {reversedWords}");
    }
}

public class ManipulationMethod
{
    // Method to check if a word is a palindrome
    public bool IsPalindrome(string word)
    {
        word = word.ToLower();
        char[] wordArr = word.ToCharArray();
        Array.Reverse(wordArr);
        string reversedWord = new string(wordArr);
        return word == reversedWord;
    }

    // Method to count the number of words in a sentence
    public int CountWords(string sentence)
    {
        string[] wordsArr = sentence.Split(" ");
        return wordsArr.Length;
    }

    // Method to reverse the words in a sentence
    public string ReverseWords(string sentence)
    {
        string[] wordArr = sentence.Split(" ");
        Array.Reverse(wordArr);
        return string.Join(" ", wordArr);
    }
}


