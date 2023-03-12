public static class Method
{
    public static void FillArray(int[] arr) // 4 x 4
    {
        int toRightSize = arr.Length;
        int toLeftSize = arr.Length;
        int toDownSize = arr.Length;
        int toUpSize = arr.Length;

        for (int toRight = 0; toLeftSize < arr.Length/4; toRight++)
        {
            arr[toRight] = toRight + 1;
        }
    }

        public static ulong GetNumber(string s)
    {
        Console.Write(s);
        ulong result;
        while (!ulong.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }

}