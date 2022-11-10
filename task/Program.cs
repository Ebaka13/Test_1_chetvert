string[] arrFirst = new string[7] { "1234", "10", "1+1", "hello", "sun", "Shako", "4/+21" };
string[] arrSecond = new string[arrFirst.Length];

void NewArray(string[] arr1, string[] arr2)
{
    int count = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        if (arr1[i].Length < 4)
        {
            arr2[count] = arr1[i];
            count++;
        }
    }
}

void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}
NewArray(arrFirst, arrSecond);
PrintArray(arrSecond);
