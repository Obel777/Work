string [] arr = {"Hello", "2", "world", ":-)"};
int n = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i].Length <= 3) 
    {
        n++;
    }
}
string [] arr2 = new string[n];
int j = 0;
foreach (string st in arr)
{
    if (st.Length <= 3) 
    {
        arr2[j] = st;
        if (j < n-1) 
        {
            Console.Write($"{arr2[j]}, ");
        }
        j++;
    }
    Console.Write($"{arr2[n-1]}");
}