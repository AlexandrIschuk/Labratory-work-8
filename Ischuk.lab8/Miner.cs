using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ischuk.lab8
{
    internal class Miner
    {
        public static int[,] ArrZeroOpen(int[,] arr, int[,] arr1)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(1); j++)
                    arr[i, j] = 0;
            for (int i = 1; i < arr.GetLength(0) - 1; i++)
                for (int j = 1; j < arr.GetLength(1) - 1; j++)
                    if (arr1[i, j] == 9)
                    {
                        arr[i, j] = arr1[i, j];
                        if (arr[i + 1, j] != 9)
                            arr[i + 1, j]++;
                        if (arr[i - 1, j] != 9)
                            arr[i - 1, j]++;
                        if (arr[i, j + 1] != 9)
                            arr[i, j + 1]++;
                        if (arr[i, j - 1] != 9)
                            arr[i, j - 1]++;
                        if (arr[i - 1, j - 1] != 9)
                            arr[i - 1, j - 1]++;
                        if (arr[i + 1, j + 1] != 9)
                            arr[i + 1, j + 1]++;
                        if (arr[i + 1, j - 1] != 9)
                            arr[i + 1, j - 1]++;
                        if (arr[i - 1, j + 1] != 9)
                            arr[i - 1, j + 1]++;
                    }
            return arr;
        }
        public static int[,] RandomArr(int[,] arr)
        {
            Random rnd = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rnd.Next(6, 10);
                }
            return arr;
        }
        public static int MineCount(int[,] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(1); j++)
                    if (arr[i, j] == 9)
                    {
                        count++;
                    }
            return count;

        }
        public static string MineCount1(int[,] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(1); j++)
                    if (arr[i, j] == 9)
                    {
                        count++;
                    }
            return "0" + count;


        }
    }
}
