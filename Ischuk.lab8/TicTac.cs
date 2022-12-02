using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ischuk.lab8
{
    internal class TicTac
    {
        public static string GameFunForX(char[,] arr, int count, int count1)
        {
            char x = 'X';
            count1++;
            string num = "";
            count = TicTac.Winner(arr, x, count);
            if (count >= 9)
            {
                num = "Крестики Победили";
            }
            else if (count1 == 9)
            {
                num = "Ничья";
            }
            return num;
        }
        public static string GameFunForZero(char[,] arr, int count, int count1)
        {
            char zero = 'O';
            count = TicTac.Winner(arr, zero, count);
            string num = "";
            if (count >= 9)
            {
                num = "Нолики Победили";
            }
            else if (count1 == 9)
            {
                num = "Ничья";

            }
            return num;
        }
        public static int Winner(char[,] arr, char x, int count)
        {
            if (arr[1, 1] == x)
                if (arr[1, 2] == x)
                    if (arr[1, 3] == x)
                    {
                        count = 9;
                    }
            if (arr[2, 1] == x)
                if (arr[2, 2] == x)
                    if (arr[2, 3] == x)
                    {
                        count = 9;
                    }
            if (arr[3, 1] == x)
                if (arr[3, 2] == x)
                    if (arr[3, 3] == x)
                    {
                        count = 9;
                    }
            if (arr[1, 1] == x)
                if (arr[2, 1] == x)
                    if (arr[3, 1] == x)
                    {
                        count = 9;
                    }
            if (arr[1, 2] == x)
                if (arr[2, 2] == x)
                    if (arr[3, 2] == x)
                    {
                        count = 9;
                    }
            if (arr[1, 3] == x)
                if (arr[2, 3] == x)
                    if (arr[3, 3] == x)
                    {
                        count = 9;
                    }
            if (arr[1, 1] == x)
                if (arr[2, 2] == x)
                    if (arr[3, 3] == x)
                    {
                        count = 9;
                    }
            if (arr[1, 3] == x)
                if (arr[2, 2] == x)
                    if (arr[3, 1] == x)
                    {
                        count = 9;
                    }
            return count;
        }
        
        public static void Random2DArray(char[,] arr, int n, int m)
        {
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    arr[i, j] = '#';

        }
        
    }
}
