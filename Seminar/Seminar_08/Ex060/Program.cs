// Пример с семинара от Сергея

int[] a = { 1, 3, 4, 3, 0, 6, 7, 3, 1, 3, 7, 8, 9, 0, 9, 8, 7, 6, 0, 4, 1 }; // n 
int m = a[0];
for (int i = 0; i < a.Length; i++) if (a[i] > m) m = a[i];
int[] c = new int[m + 1];
for (int i = 0; i < a.Length; i++) c[a[i]]++;
for (int i = 0; i < c.Length; i++) Console.WriteLine($"{i}: {c[i]}");