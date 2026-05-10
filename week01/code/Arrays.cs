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
         //Step 1: Create an array to store results
         //Step 2: Loop through required length from 0
         //Step 3: Then for each index, multiply number by index+1
         //Step 4: Store the result in array, then return array

    //Step1 code    
    double[] result = new double[length];

    // Step2 code 
    for (int i = 0; i < length; i++)
    {
        // Step3 code
        result[i] = number * (i + 1);
    }

    // Step4: Return completed array
    return result;
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
        //Step 1: I will find a split point using the (amount), because it tell how many items from the end go to the front
        //Step 2: Then, I will take last (amount) elements
        //Step 3: Then, I will take first part (everything before last amount)
        //Step 4: Begin to rearrange where; last part goes first and the first part goes after
        //Step 5: Finally modify the original list, not to return new one

    // Step 1: Get the last (amount) elements
    List<int> endPart = data.GetRange(data.Count - amount, amount);

    // Step 2: Get the first part of the list
    List<int> startPart = data.GetRange(0, data.Count - amount);

    // Step 3: Clear original list
    data.Clear();

    // Step 4: Add rotated parts back
    data.AddRange(endPart);
    data.AddRange(startPart);
    }
}
