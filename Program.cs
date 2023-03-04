Console.WriteLine("Введи что попало через пробел: ");
string[] arr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
int res = ResArrLength(arr);
Console.Write($"[{String.Join(", ", FillArray(res))}]");

int ResArrLength(string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            count++;
        }
    }
    return count;
}

string[] FillArray(int count)
{
    string[] array = new string[count];
    int j = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            array[j] = arr[i];
            j++;
        }
    }
    return array;
}