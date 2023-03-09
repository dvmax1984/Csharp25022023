// Contact: Maksim Dvortsov:
// Task: Заполнить рандомно от -9 до 9 - Максим

public static class Library_MAX
{
    public static void FillArrar(int[] array)
    {
        for int i = 0; i < array.Lenght; i++)
        {
            array[i] = new Random().Next(-9, 9);
        }
    }
}