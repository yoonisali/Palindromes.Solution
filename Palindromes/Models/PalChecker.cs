using System;

namespace Palindromes.Models
{
  public class PalChecker
  {

    public string PalindromeCheck = ""; 
    public void IsItAPalindrome(string stringInput)
    {
      string input = stringInput.ToLower();
      char[] palindromesArray = input.ToCharArray();
      Array.Reverse(palindromesArray);
      string reverseInput = string.Join("", palindromesArray);
      if (input == reverseInput)
      {
        PalindromeCheck = stringInput + " is a palindrome!";
      }
      else
      {
        PalindromeCheck = stringInput + " is NOT a palindrome!";
      }
    }
  }
}