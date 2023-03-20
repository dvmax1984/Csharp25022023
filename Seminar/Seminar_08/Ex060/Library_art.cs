public static class Library_art
{
    public static string PrintArray(int[] array)
    {
        string output = String.Empty;
        for (int i = 0; i < array.Length; i++)
        {
            output = output + array[i] + " ";
        }
        return output;
    }
}