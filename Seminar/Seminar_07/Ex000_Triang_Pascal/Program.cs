Console.WriteLine("Треугольник Паскаля");

int[,] a = new int[9,9];

int rowMax = 9; //a.GetLength(0);
int colMax = 9; //a.GetLength(1);

//a[1,1] = 1;

string res = "";
string r;

for (int row = 1; row < rowMax; row++)
{
    for (int col = 1; col < colMax; col++)
    {
        if (col == 1 && row == 1) { a[row, col] = 1; Console.WriteLine(a[row, col]); break;}
        if (col == 2 && row == 2) { a[row, col] = 2; }
        
        a[row, col] = a[row - 1, col - 1] + a[row - 1, col];
        
        if (a[row, col]==0) {r = "";}
        else {r = $" {Convert.ToString(a[row, col])} ";}
        
        res = res + r;
    }
    Console.WriteLine(res);
    res="";
}
