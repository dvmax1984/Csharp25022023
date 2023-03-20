public static class classCountRepeat
{
    public static int[] CountRepeat(int[] array, int[] b)
    {
        for (int i = 0; i < array.Length; i++)
        {
            int c = array [i];

            for (int j = 0; j < array.Length; j++)
            {
                if (array[j] == c)
                {
                    b[i] += 1;
                }
            }


        }

        return b;
    }
}