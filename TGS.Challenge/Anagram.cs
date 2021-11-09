using System;
using System.Text.RegularExpressions;

namespace TGS.Challenge
{
    /*
          Devise a function that checks if 1 word is an anagram of another, if the words are anagrams of
          one another return true, else return false

          "Anagram": An anagram is a type of word play, the result of rearranging the letters of a word or
          phrase to produce a new word or phrase, using all the original letters exactly once; for example
          orchestra can be rearranged into carthorse.

          areAnagrams("horse", "shore") should return true
          areAnagrams("horse", "short") should return false

          NOTE: Punctuation, including spaces should be ignored, e.g.

          horse!! shore = true
          horse  !! shore = true
            horse? heroes = true

          There are accompanying unit tests for this exercise, ensure all tests pass & make
          sure the unit tests are correct too.
       */
    public class Anagram
    {
        public bool AreAnagrams(string word1, string word2)
        {
            // Check for null values
            if (string.IsNullOrWhiteSpace(word1) || string.IsNullOrWhiteSpace(word2))
                throw new ArgumentException();

            // Removing special characters
            word1 = Regex.Replace(word1, @"[^a-zA-Z]+", string.Empty);
            word2 = Regex.Replace(word2, @"[^a-zA-Z]+", string.Empty);

            // Breaking words into characters
            char[] firstCharArray = word1.ToLower().ToCharArray();
            char[] secondCharArray = word2.ToLower().ToCharArray();

            // Sorting characters
            Array.Sort(firstCharArray);
            Array.Sort(secondCharArray);

            // Building string (for comparison)
            word1 = new string(firstCharArray);
            word2 = new string(secondCharArray);

            return word1 == word2;
        }
    }
}