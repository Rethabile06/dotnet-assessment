namespace TGS.Challenge
{
    /*
         Given a zero-based integer array of length N, the equivalence index (i) is the index where the sum of all the items to the left of the index
         are equal to the sum of all the items to the right of the index.

         Constraints: 0 <= N <= 100 000

         Example: Given the following array [1, 2, 3, 4, 5, 7, 8, 10, 12]
         Your program should output "6" because 1 + 2 + 3 + 4 + 5 + 7 = 10 + 12

         If no index exists then output -1

         There are accompanying unit tests for this exercise, ensure all tests pass & make
          sure the unit tests are correct too.
       */

    public class EquivalenceIndex
    {
        public int Find(int[] numbers)
        {
            // Define local variables
            int length = numbers.Length;
            int[] sumFromLeft = new int[length];
            int[] sumFromRight = new int[length];

            // Adding values from index 0 to last
            for (int i = 0; i < length; i++)
            {
                sumFromLeft[i] = i == 0 ? numbers[0] : sumFromLeft[i - 1] + numbers[i];
            }

            // Adding values from last index to 0
            for (int i = length - 1; i >= 0; i--)
            {
                sumFromRight[i] = (numbers.Length - 1) == i ? numbers[i] : sumFromRight[i + 1] + numbers[i];
            }

            // Find the index of the same sum
            for (int i = 1; i < length - 1; i++)
            {
                if (sumFromLeft[i] == sumFromRight[i]) 
                    return i;
            }

            return -1;
        }
    }
}