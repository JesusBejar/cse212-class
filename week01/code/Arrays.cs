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

        // declare list (multiplesList)
        List<double> multiplesList = new List<double>();

        // loop through length and add m1 to list 
        for (var i = 0; i < length; i++) {
            // declare multiple 
            double mul = number * i;
            // add mul to list
            multiplesList.Add(mul);
        }

        // convert multiplesList to double type
        return multiplesList.ToArray(); 
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
        // Step 1: Get the elements that will move to the front (last 'amount' elements)
        // For example, if amount is 3, we want the last 3 elements
        List<int> elementsToMove = data.GetRange(data.Count - amount, amount);
        
        // Step 2: Get the elements that will move to the back (all elements except last 'amount' elements)
        // For example, if amount is 3, we want all elements except the last 3
        List<int> elementsToShift = data.GetRange(0, data.Count - amount);
        
        // Step 3: Clear the original list
        data.Clear();
        
        // Step 4: Add the elements in the correct order:
        // First add the elements that moved to the front
        data.AddRange(elementsToMove);
        // Then add the elements that moved to the back
        data.AddRange(elementsToShift);
    }
}
