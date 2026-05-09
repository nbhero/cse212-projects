public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Create an array that will store all multiples.
        // The size of the array should match the length parameter.
        double[] result = new double[length];


        // Use a loop to go through each position in the array.
        // The loop starts at 0 and ends at length -1
        for (int i = 0; i < length; i++)
        {
            // Calculate the multiple of the number.
            // Since arrays start at index 0, we need to use (i + 1) to get the correct multiple.
            // so the first multiple will be number * 1
            result[i] = number * (i + 1);
        }

        return result; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Create a temporary list to store the rotated values.
        List<int> rotated = new List<int>();

        // Add the last "amount" values from the original list to the temporary list.
        // to the beginning of the new list.
        for (int i = data.Count - amount; i < data.Count; i++)
        {
            rotated.Add(data[i]);
        }

        // Add the remaining values from the beginning of the original list
        for (int i = 0; i < data.Count - amount; i++)
        {
            rotated.Add(data[i]);
        }

        // Clean the list
        data.Clear();

        // Replace the original list values with the rotated values.
        foreach (int value in rotated)
        {
            data.Add(value);
        }
    }
}
