// Sayarak Sıralama (Counting Sort) 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
class Enes
{
    static void countSort(int[] arr)
    {
        int max = arr.Max();
        int min = arr.Min();
        int range = max - min + 1;
        int[] count = new int[range];
        int[] output = new int[arr.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            count[arr[i] - min]++;
        }
        for (int i = 1; i < count.Length; i++)
        {
            count[i] += count[i - 1];
        }
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            output[count[arr[i] - min] - 1] = arr[i];
            count[arr[i] - min]--;
        }
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = output[i];
        }
    }
    static void printArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine("");
    }
    public static void Main(string[] args)
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
        countSort(arr);
        Console.WriteLine("düzenlemiş diziniz:");
        printArray(arr);
        watch.Stop();
        Console.WriteLine("baglantı süresi: {0}", watch.Elapsed.Milliseconds + " milisaniye ve yandaki de " + watch.Elapsed.Seconds);
    }
}
