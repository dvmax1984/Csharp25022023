public static class Library1
{
    public static string printArray(int[] collection)
    {
        string elmassiv = String.Empty;
        for(int i = 0; i < collection.Length; i++)
        {
            elmassiv = elmassiv + collection[i] + " ";
        }
        return elmassiv;
    }
}