using static Library1;
using static Library_MAX;
using static Library;

int[] array = new int[12];
FillArray(array);
Console.WriteLine(printArray(array));
var x = GetPosNeg(array);
Console.WriteLine(x.p);
Console.WriteLine(x.n);


