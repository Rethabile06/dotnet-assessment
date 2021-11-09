using System;

namespace TGS.Challenge
{
    /*
        Devise a function that takes a string & returns the number of 
        vowels (aeiou) in that string.

        "Hi there!" = 3
        "What do you mean?"  = 6

        There are accompanying unit tests for this exercise, ensure all tests pass & make
        sure the unit tests are correct too.
     */
    public class VowelCount
    {
        public int Count(string value)
        {
            // Check for null values
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException();

            // Define counter and vowels
            int counter = 0;
            char[] vowels = { 'a', 'e', 'i', 'o', 'u'};
            value = value.ToLower();

            for (int i = 0; i < value.Length; i++)
            {
                if (value[i] == vowels[0] || value[i] == vowels[1] || value[i] == vowels[2] ||
                    value[i] == vowels[3] || value[i] == vowels[4])
                    counter++;
            }

            return counter;
        }
    }
}
