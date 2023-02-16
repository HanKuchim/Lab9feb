using System;
using System.Collections;
using System.Drawing;

class MenuTask
{
    private static int n = 0;
    private static int[] arr;
    public static void Menu(ref int num)
    {
        Console.WriteLine("1 - Make an Array");
        Console.WriteLine("2 - Show array elements");
        Console.WriteLine("3 - Select sort");
        Console.WriteLine("4 - Heap sort");
        Console.WriteLine("5 - Bubble sort");
        Console.WriteLine("6 - Shaker sort");
        Console.WriteLine("7 - Exit");
        Console.WriteLine("Enter number 1-7");
        num = int.Parse(Console.ReadLine());
        switch (num)
        {
            case 1:
                Console.WriteLine("enter array size");
                n = int.Parse(Console.ReadLine());
                CreateArray(ref arr, n); break;
            case 2: Print(arr); break;
            case 3: SortChoice(ref arr); break;
            case 4: HeapSort(ref arr); break;
            case 5: BubbleSort(ref arr); break;
            case 6: ShakerSort(ref arr); break;
            default:
                break;
        }
    }

    private static int[] CreateArray(ref int[] arr, int n)
    {
        Random rnd= new Random();
        Array.Resize(ref arr, n);
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rnd.Next(-100, 101);
        }
        return arr;
    }
    private static void Print(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }
    private static void ShakerSort(ref int[] arr)
    {
        int left = 0,
                right = arr.Length - 1,
                count = 0;

        while (left < right)
        {
            for (int i = left; i < right; i++)
            {
                count++;
                if (arr[i] > arr[i + 1])
                    Swap(ref arr[i], ref arr[i+1]);
            }
            right--;

            for (int i = right; i > left; i--)
            {
                count++;
                if (arr[i - 1] > arr[i])
                    Swap(ref arr[i-1], ref arr[i]);
            }
            left++;
        }
    }

    private static int[] BubbleSort(ref int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr.Length - 1 - i; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    Swap(ref arr[j], ref arr[j + 1]);
                }
            }
        }
        return arr;
    }

    private static void HeapSort(ref int[] arr)
    {
        //Здесь была пирамидальная сортировка. Или будет...
    }

    private static int[] SortChoice(ref int[] arr)
    {
        int indx; 
        for (int i = 0; i < arr.Length; i++) 
        {
            indx = i; 
            for (int j = i; j < arr.Length; j++) 
            {
                if (arr[j] < arr[indx])
                {
                    indx = j;
                }
            }
            if (arr[indx] == arr[i]) 
                continue;
            
            int temp = arr[i]; 
            arr[i] = arr[indx];
            arr[indx] = temp;
        }
        return arr;
    }
    static void Swap(ref int aFirstArg, ref int aSecondArg)
    {
        int tmpParam = aFirstArg;
        aFirstArg = aSecondArg;
        aSecondArg = tmpParam;
    }
}
class Program
{
    static void Main(string[] args)
    {
        int number = 0;
        do
        {
            MenuTask.Menu(ref number);
        } while (number != 7);
    }

}
