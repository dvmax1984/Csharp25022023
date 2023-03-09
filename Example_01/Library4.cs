public static class Library
{
    public static (int p, int n) GetPosNeg(int[] array1)
    {
        int positiv = 0;
        int negativ = 0;
        for (int i = 0; i < array1.Length; i++)
        {
            if (array1[i] > 0)
            {
                positiv = positiv + array1[i];
            }
            else
            {
                negativ = negativ + array1[i];
            }
        }
        return (positiv, negativ);
    }
}
