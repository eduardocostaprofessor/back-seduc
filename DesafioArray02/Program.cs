//                     0   1    2    3     4    5   6   7   8    9
int[] arrayNumeros1 = { 50, 90, 200, 499, 1257, 56, 589, 90, 30, 201 };
//                     0     1    2   3  4  5  6   7  8   9
int[] arrayNumeros2 = { 999, 456, 898, 1, 5, 7, 80, 2, 3, 2010 };

for (int i = 0; i < arrayNumeros1.Length; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(arrayNumeros1[i]);
    }
    else
    {
        Console.WriteLine(arrayNumeros2[i]);
    }
}