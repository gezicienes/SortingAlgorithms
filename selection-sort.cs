// Seçerek Sıralama (Selection Sort)
using System;
using System.Diagnostics;

class Enes
{
    static void Selectionsort (int[] arr)
    {
        int n = arr.Length;

        for (int i = 0; i < n - 1; i++)
        {
            int min_idx = i;
            for (int j = i + 1; j < n; j++)
                if (arr[j] < arr[min_idx])
                    min_idx = j;

            int temp = arr[min_idx];
            arr[min_idx] = arr[i];
            arr[i] = temp;
        }
    }
    static void printArray(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n; ++i)
            Console.Write(arr[i] + " ");
        Console.WriteLine();
    }

    public static void Main()
    {
        int dizi;
        dizi = Convert.ToInt32(Console.ReadLine());
        Stopwatch watch = new Stopwatch();

        watch.Start();
        int[] arr = new int[dizi];
        Random rnd = new Random();
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rnd.Next(1, 1000);
        }
        Selectionsort(arr);
        Console.WriteLine("Düzenlenmiş diziniz: ");
        printArray(arr);
        watch.Stop();
        Console.WriteLine("baglantı süresi: {0}", watch.Elapsed.Milliseconds + " milisaniye" + watch.Elapsed.Seconds);
    }
}
