using System
class Program
{
    static void PrintArr (string[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write (arr[i] + " ");
        }
    }

    static string[] StrInput()
    {
        string str = Console.ReadLine();
        string[] arr = str.Split(' ');
        return arr;
    }

    static void Main()
    {
        string[] array = StrInput();
        string[] newStr = new string[array.Length];
        int i = 0;
        for (int j = 0; j < array.Length; j++)
        {
            if (array[j].Length < 4)
            {
                newStr[i++] = array[j];
            }
        }
        Array.Resize(ref newStr, i);
        PrintArr(newStr);
    }
}