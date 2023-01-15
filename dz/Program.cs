




void SortArray(string[] array)

{
    
    int countLength = 3;
    
    for (int i = 0; i <array.GetLength(0); i++)
    {
        if (array[i].Length > countLength)
        {
          array[i] = null;
        }
        

    }
    
}
void PrintArray(string[] arr)
{
for (int i = 0; i < arr.GetLength(0); i++)
{
// System.Console.Write($"[ {arr[i]} ] ");
System.Console.Write('[' + (arr[i]) + ']');
}
System.Console.WriteLine();
}

System.Console.WriteLine(" array:");
string[] array = { "Zenit", "hello world", "5", "no", "I" };
System.Console.WriteLine('[' + string.Join(",", array) + ']');
SortArray(array);
PrintArray(array);