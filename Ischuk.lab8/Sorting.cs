using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Ischuk.lab8
{
    internal class Sorting
    {
        public static long ShellSortTime(int[] arr,long t)
        {
            Stopwatch stopwatch1 = new Stopwatch();
            stopwatch1.Start();
            Sorting.ShellSort(arr);
            stopwatch1.Stop();
            t = stopwatch1.ElapsedMilliseconds;
            return t;
        }
        public static long ShakerSortTime(int[] arr,long t1)
        {
            Stopwatch stopwatch2 = new Stopwatch();
            stopwatch2.Start();
            Sorting.ShakerSort(arr);
            stopwatch2.Stop();
            t1 = stopwatch2.ElapsedMilliseconds;
            return t1;
        }
        public static string sort(int[] arr, int[] arr1, long t,long t1)
        {
            string timestr = "";
            if (t1 > t)
            {
                timestr = ("Сортировка Шелла быстрее сортировки перемешиванием на " + (t1 - t) + " Мс");

            }
            else
            {
                timestr = ("Сортировка Перемешиванием быстрее сортировки Шелла на " + (t - t1) + " Мс");
            }
            return timestr;
        }
        public static string OutputArray(int[] arr)
        {
            string Str = "";
            if (arr.Length <= 100)
            {
                for (int i = 0; i < arr.Length; i++)
                    Str = Str + " " + arr[i];

            }
            else
                Str = "Массив создан.Но выходит за рамки строки.";
            return Str;

        }

        public static void Copy(int[] arr, int[] arr1)
        {
            for (int i = 0; i < arr.Length; i++)
                arr1[i] = arr[i];
        }
        public static int[] RandomArray(int[] newarr)
        {
            Random rnd = new Random();
            for (int i = 0; i < newarr.Length; i++)
                newarr[i] = rnd.Next(-100, 100);
            return newarr;
        }
        public static void ShellSort(int[] arr)
        {
            int j;
            int step = arr.Length / 2;
            while (step > 0)
            {
                for (int i = 0; i < (arr.Length - step); i++)
                {
                    j = i;
                    while ((j >= 0) && (arr[j] > arr[j + step]))
                    {
                        int tmp = arr[j];
                        arr[j] = arr[j + step];
                        arr[j + step] = tmp;
                        j -= step;
                    }
                }
                step = step / 2;
            }
        }
        public static void Swap(int[] myint, int i, int j)
        {
            int glass = myint[i];
            myint[i] = myint[j];
            myint[j] = glass;
        }
        public static void ShakerSort(int[] myint)
        {
            int left = 0,
                right = myint.Length - 1,
                count = 0;

            while (left < right)
            {
                for (int i = left; i < right; i++)
                {
                    count++;
                    if (myint[i] > myint[i + 1])
                        Swap(myint, i, i + 1);
                }
                right--;

                for (int i = right; i > left; i--)
                {
                    count++;
                    if (myint[i - 1] > myint[i])
                        Swap(myint, i - 1, i);
                }
                left++;
            }
        }
    }
}
