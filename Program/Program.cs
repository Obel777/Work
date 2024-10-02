int[] A = {2, 3, 7, 9, 11};
double S = 0;
int i = 0;
while (i < A.Length)
{
    S = S + A[i];
    i++;
}
double SA = S / A.Length;
Console.WriteLine($"Среднее арифметическое: {SA}");