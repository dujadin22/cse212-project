using System.Collections.Generic;

public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  
    /// For example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  
    /// Assume that length is a positive integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // PLAN:
        // 1. Create a new array that has the size of 'length'.
        // 2. Use a loop to go through each index of the array.
        // 3. For each index i, calculate the multiple by multiplying
        //    'number' by (i + 1).
        // 4. Store the result in the array at position i.
        // 5. After the loop finishes, return the array.

        double[] result = new double[length];

        for (int i = 0; i < length; i++)
        {
            result[i] = number * (i + 1);
        }

        return result;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  
    /// For example, if the data is List<int>{1,2,3,4,5,6,7,8,9} 
    /// and amount is 3 then the result should be 
    /// List<int>{7,8,9,1,2,3,4,5,6}.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // PLAN:
        // 1. Find the position where the list should be split.
        //    This is data.Count - amount.
        // 2. Get the last 'amount' elements using GetRange().
        // 3. Get the first part of the list (from index 0 to split position).
        // 4. Clear the original list.
        // 5. Add the last elements first.
        // 6. Then add the first elements.

        int splitIndex = data.Count - amount;

        List<int> lastPart = data.GetRange(splitIndex, amount);
        List<int> firstPart = data.GetRange(0, splitIndex);

        data.Clear();

        data.AddRange(lastPart);
        data.AddRange(firstPart);
    }
}