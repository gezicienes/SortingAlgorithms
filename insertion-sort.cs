//Seçmeli Sıralama (Insertion Sort)
using System;
using System.Diagnostics;

class Enes
{

    void sort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 1; i < n; ++i)
        {
            int key = arr[i];
            int j = i - 1;

            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j = j - 1;
            }
            arr[j + 1] = key;
        }
    }

    static void printArray(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n; ++i)
            Console.Write(arr[i] + " ");

        Console.Write("\n");
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
        Enes ob = new Enes();
        ob.sort(arr);
        Console.WriteLine("Kodunuzun düzenlenmiş hali;");
        printArray(arr);
        watch.Stop();
    }
}
