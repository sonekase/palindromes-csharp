using System;
using System.Collections.Generic;
using System.Linq;

class Palindromes
{
  private string InputWord;

  public Palindromes(string word)
  {
    InputWord = word;
  }
  public bool IsItPalindromes()
  {
    int matchCount = 0;
    for(int i = 0; i < InputWord.Length; i++)
    {
      if(InputWord.ElementAt(i) == InputWord.ElementAt((InputWord.Length-1) - i))
      {
        matchCount++;
      }
    }
    Console.WriteLine(matchCount);
    return matchCount == InputWord.Length;
  }
}

public class Program
{
  public static void Main()
  {
    Console.WriteLine("Please enter a word");
    string input = Console.ReadLine();
    Palindromes userPalindromes = new Palindromes(input);
    if(userPalindromes.IsItPalindromes())
    {
      Console.WriteLine("It is a Palindromes!");
    } else
    {
      Console.WriteLine("It is not a Palindromes!");
    }
  }
}
