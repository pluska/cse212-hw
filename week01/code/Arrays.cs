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

        // I'm going to use an array to store the information.
        // then a loop that iterates the number of times that is “length”.
        // I will use the index of the loop to multiply with “number” and store the result in the array.


        double[] numbers = new double[length];

        for (int i = 1; i <= length; i++)
        {
            double temp;

            temp = number * i;

            numbers.SetValue(temp, i-1);

        }

        return numbers; // replace this return statement with your own
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

        // First, using % I will determinate if the amount is in the right range
        // I will use a conditions to verify if the rotation is needed
        // I will use two new lists for this exercise
        // The first will be elementsMoved, which will use the function GetRange with the first element that know should go at the end
        // the second will be elementsRotated, which will use the functions GetRange to get the elements should be now at the beggining
        // Then I will clear "data" list
        // And use AddRange to insert elementsMoved and elementsRotated into "data"

        int rotateBy = amount % data.Count;
        if (rotateBy == 0)
        {
            return;
        }
        List<int> elementsMoved = data.GetRange(data.Count - rotateBy, rotateBy);
        List<int> elementsRotated = data.GetRange(0, data.Count - rotateBy);
        data.Clear();
        data.AddRange(elementsMoved);
        data.AddRange(elementsRotated);

    }
}
