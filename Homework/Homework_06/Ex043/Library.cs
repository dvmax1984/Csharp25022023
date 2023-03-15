public static class Library
{
    public static int GetNumber(string s)
    {
        Console.Write(s);

        int result;
        while (!int.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }

    // Источник формулы: https://ru.wikipedia.org/wiki/%D0%9F%D1%80%D1%8F%D0%BC%D0%B0%D1%8F#.D0.92.D0.B7.D0.B0.D0.B8.D0.BC.D0.BD.D0.BE.D0.B5_.D1.80.D0.B0.D1.81.D0.BF.D0.BE.D0.BB.D0.BE.D0.B6.D0.B5.D0.BD.D0.B8.D0.B5_.D0.BD.D0.B5.D1.81.D0.BA.D0.BE.D0.BB.D1.8C.D0.BA.D0.B8.D1.85_.D0.BF.D1.80.D1.8F.D0.BC.D1.8B.D1.85_.D0.BD.D0.B0_.D0.BF.D0.BB.D0.BE.D1.81.D0.BA.D0.BE.D1.81.D1.82.D0.B8
    public static (double x, double y) GetResult(double b1, double k1, double b2, double k2)
    {
        double resultX;
        double resultY;

        resultX = (b1 - b2) / (k2 - k1);

        resultY = ((k2 * b1) - (k1 * b2)) / (k2 - k1);

        return (resultX, resultY);
    }
}