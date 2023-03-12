public static class Figures
{
    // <summary>
    // 1 - S, 2 - T, 3 - J, 4 - L, 5 - I, 6 - квадрат, 7 - Z
    // </summary>
    public static int[,] Figure(int f)
    {

        int[,] pic;
        

        if (f == 1)     /* S змейка */
        {
            pic = new int[,] 
                    {   {1,1,0,0},   /* row 0      7, 4, 1   */
                        {0,0,1,1},   /* row 1      8, 5, 2   */
                        {0,0,0,0},
                        {0,0,0,0} }; /* row 3      9, 6, 3   */
            return pic;
        }

        else if (f == 2)     /* T - Teewee */
        {
            pic = new int[,]
                    {   {1,1,1,0},
                        {0,1,0,0},
                        {0,0,0,0},
                        {0,0,0,0} };
            return pic;
        }

        else if (f == 3)     /* J  */
        {
            pic = new int[,]
                    {   {0,0,0,1},
                        {0,0,0,1},
                        {0,0,0,1},
                        {0,0,1,1} };
            return pic;
        }

        else if (f == 4)     /* L  */
        {
            pic = new int[,]
                    {   {1,0,0,0},
                        {1,0,0,0},
                        {1,0,0,0},
                        {1,1,0,0} };
            return pic;
        }

        else if (f == 5)     /* I  */
        {
            pic = new int[,]
                    {   {0,1,0,0},
                        {0,1,0,0},
                        {0,1,0,0},
                        {0,1,0,0} };
            return pic;
        }
        else if (f == 6)     /* кадрат  */
        {
            pic = new int[,]
                    {   {0,0,0,0},
                        {0,0,0,0},
                        {0,1,1,0},
                        {0,1,1,0} };
            return pic;
        }
        if (f == 7)     /* S змейка обратная*/
        {
            pic = new int[,]
                    {   {0,0,1,1},  
                        {1,1,0,0},  
                        {0,0,0,0},
                        {0,0,0,0} };
            return pic;
        }


        pic = new int[,]
                    {   {0,0,0,0},
                        {0,0,0,0},
                        {0,0,0,0},
                        {0,0,01,0} };
        return pic;

    }
}