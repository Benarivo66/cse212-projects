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
        // Create a list to store the multiples
        // Loop through all the integers beginning from one leading up to the length variable
        // For each iteration, append the result of the multiplication of the integer and number to the list created to store the multiples
        // Return the list that stores the multiples

        List<double> result = new();
        for(var k = 1; k <= length; k++){
            result.Add(number * k);
        }  
        return result.ToArray(); 
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
        // create a variable k to track the iteration
        // create a while loop
        //For each iteration:
        // indentify the last item in the data list, store in a variable
        // remove the last item
        // insert that last item at index 0
        // increment k by 1
        var k = 0;
        while(k < amount){
           var lastItem = data[data.Count - 1];
           data.RemoveAt(data.Count - 1);
           data.Insert(0, lastItem);
            k++;
        }
    }
}
