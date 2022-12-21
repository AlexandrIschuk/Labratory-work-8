using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ischuk.lab8
{
    internal class Miner
    {
        public static int[,] arr1 = new int[10, 10];

        public static int[,] arr = new int[10, 10];
        public static double sum = 0;

        public static void FlagCount()
        {
            double sum1 = 0;
            for (int i = 0; i < 10; ++i)
                for (int j = 0; j < 10; ++j)
                    if (arr[i, j] > 9 )
                    {
                        sum1 = sum1 + arr[i,j];
                    }
            sum = sum1;
        }   
        public static void Winner(Label textBox21)
        {
            if (Form1.Mcount == sum/19)
            {
                textBox21.Text = "Вы победили." + "\r\nВремя игры: " + timeend + " секунд.";
                EndGame = true;
                Form1.StopWatch();
            }
        }
        public static bool EndGame = false;
        public static string timeend = "";
        public static bool GameFunction2( Button[,] S, int n, int m,Label  textBox21,Button MinerRestart)

        {
            string read = "";
            if (arr[n, m] == 0 & n != 0 & m != 0 & m != 9 & n != 9)
            {
                S[n, m].BackgroundImage = Miner.NumFile(arr[n, m]);
                S[n + 1, m].BackgroundImage = Miner.NumFile(arr[n + 1, m]);
                S[n, m + 1].BackgroundImage = Miner.NumFile(arr[n, m + 1]);
                S[n - 1, m].BackgroundImage = Miner.NumFile(arr[n - 1, m]);
                S[n, m - 1].BackgroundImage = Miner.NumFile(arr[n, m - 1]);
                S[n + 1, m + 1].BackgroundImage = Miner.NumFile(arr[n + 1, m + 1]);
                S[n - 1, m - 1].BackgroundImage = Miner.NumFile(arr[n - 1, m - 1]);
                S[n - 1, m + 1].BackgroundImage = Miner.NumFile(arr[n - 1, m + 1]);
                S[n + 1, m - 1].BackgroundImage = Miner.NumFile(arr[n + 1, m - 1]);
            }
            else if (arr[n, m] == 0 & n == 0 & m == 0)
            {
                S[n, m].BackgroundImage = Miner.NumFile(arr[n, m]);
                S[n + 1, m].BackgroundImage = Miner.NumFile(arr[n + 1, m]);
                S[n, m + 1].BackgroundImage = Miner.NumFile(arr[n, m + 1]);
                S[n + 1, m + 1].BackgroundImage = Miner.NumFile(arr[n + 1, m + 1]);

            }
            else if (arr[n, m] == 0 & n == 9 & m == 9)
            {
                S[n, m].BackgroundImage = Miner.NumFile(arr[n, m]);
                S[n - 1, m].BackgroundImage = Miner.NumFile(arr[n - 1, m]);
                S[n, m - 1].BackgroundImage = Miner.NumFile(arr[n, m - 1]);
                S[n - 1, m - 1].BackgroundImage = Miner.NumFile(arr[n - 1, m - 1]);
            }
            else if (arr[n, m] == 0 & n == 0 & m == 9)
            {
                S[n, m].BackgroundImage = Miner.NumFile(arr[n, m]);
                S[n + 1, m].BackgroundImage = Miner.NumFile(arr[n + 1, m]);
                S[n, m - 1].BackgroundImage = Miner.NumFile(arr[n, m - 1]);
                S[n + 1, m - 1].BackgroundImage = Miner.NumFile(arr[n + 1, m - 1]);
            }
            else if (arr[n, m] == 0 & n == 9 & m == 0)
            {
                S[n, m].BackgroundImage = Miner.NumFile(arr[n, m]);
                S[n, m + 1].BackgroundImage = Miner.NumFile(arr[n, m + 1]);
                S[n - 1, m].BackgroundImage = Miner.NumFile(arr[n - 1, m]);
                S[n - 1, m + 1].BackgroundImage = Miner.NumFile(arr[n - 1, m + 1]);
            }
            else if (arr[n, m] == 0 & n == 0)
            {
                S[n, m].BackgroundImage = Miner.NumFile(arr[n, m]);
                S[n + 1, m].BackgroundImage = Miner.NumFile(arr[n + 1, m]);
                S[n, m + 1].BackgroundImage = Miner.NumFile(arr[n, m + 1]);
                S[n, m - 1].BackgroundImage = Miner.NumFile(arr[n, m - 1]);
                S[n + 1, m + 1].BackgroundImage = Miner.NumFile(arr[n + 1, m + 1]);
                S[n + 1, m - 1].BackgroundImage = Miner.NumFile(arr[n + 1, m - 1]);
            }
            else if (arr[n, m] == 0 & n == 9)
            {
                S[n, m].BackgroundImage = Miner.NumFile(arr[n, m]);
                S[n, m + 1].BackgroundImage = Miner.NumFile(arr[n, m + 1]);
                S[n - 1, m].BackgroundImage = Miner.NumFile(arr[n - 1, m]);
                S[n, m - 1].BackgroundImage = Miner.NumFile(arr[n, m - 1]);
                S[n - 1, m - 1].BackgroundImage = Miner.NumFile(arr[n - 1, m - 1]);
                S[n - 1, m + 1].BackgroundImage = Miner.NumFile(arr[n - 1, m + 1]);
            }
            else if (arr[n, m] == 0 & m == 0)
            {
                S[n, m].BackgroundImage = Miner.NumFile(arr[n, m]);
                S[n + 1, m].BackgroundImage = Miner.NumFile(arr[n + 1, m]);
                S[n, m + 1].BackgroundImage = Miner.NumFile(arr[n, m + 1]);
                S[n - 1, m].BackgroundImage = Miner.NumFile(arr[n - 1, m]);
                S[n + 1, m + 1].BackgroundImage = Miner.NumFile(arr[n + 1, m + 1]);
                S[n - 1, m + 1].BackgroundImage = Miner.NumFile(arr[n - 1, m + 1]);
            }
            else if (arr[n, m] == 0 & m == 9)
            {
                S[n, m].BackgroundImage = Miner.NumFile(arr[n, m]);
                S[n + 1, m].BackgroundImage = Miner.NumFile(arr[n + 1, m]);
                S[n - 1, m].BackgroundImage = Miner.NumFile(arr[n - 1, m]);
                S[n, m - 1].BackgroundImage = Miner.NumFile(arr[n, m - 1]);
                S[n - 1, m - 1].BackgroundImage = Miner.NumFile(arr[n - 1, m - 1]);
                S[n + 1, m - 1].BackgroundImage = Miner.NumFile(arr[n + 1, m - 1]);
            }
            S[n, m].BackgroundImage = Miner.NumFile(arr[n, m]);
            if (arr[n, m] == 9)
            {
                EndGame = true;
                Form1.StopWatch();
                MinerRestart.BackgroundImage = Ischuk.lab8.Properties.Resources.MinerRes;
                textBox21.Text = "Вы проиграли." + "\r\nВремя игры: " + timeend + " секунд.";
                for (int i = 0; i < 10; ++i)
                    for (int j = 0; j < 10; ++j)
                    {
                        if (arr[i, j] == 9)
                        {
                            S[i, j].BackgroundImage = Ischuk.lab8.Properties.Resources.bomb;
                        }
                    }
                S[n, m].BackgroundImage = Ischuk.lab8.Properties.Resources.bombed;

            }
            return EndGame;


        }
        public static Image NumFile(int i)
        {
            Image img = Ischuk.lab8.Properties.Resources.opened;
            if (i == 0)
                img = Ischuk.lab8.Properties.Resources.zero;
            else if (i == 1)
                img = Ischuk.lab8.Properties.Resources.num1;
            else if (i == 2)
                img = Ischuk.lab8.Properties.Resources.num2;
            else if (i == 3)
                img = Ischuk.lab8.Properties.Resources.num3;
            else if (i == 4)
                img = Ischuk.lab8.Properties.Resources.num4;
            else if (i == 5)
                img = Ischuk.lab8.Properties.Resources.num5;
            else if (i == 6)
                img = Ischuk.lab8.Properties.Resources.num6;
            else if (i == 7)
                img = Ischuk.lab8.Properties.Resources.num7;
            else if (i == 8)
                img = Ischuk.lab8.Properties.Resources.num8;
            else if (i >= 10)
                img = Ischuk.lab8.Properties.Resources.flaged;
            return img;
        }
        public static void ArrZeroOpen()
        {
            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(1); j++)
                    arr[i, j] = 0;
            for (int i = 1; i < arr1.GetLength(0) - 1; i++)
                for (int j = 1; j < arr1.GetLength(1) - 1; j++)
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
        }
        public static void RandomArr()
        {
            Random rnd = new Random();
            for (int i = 0; i < arr1.GetLength(0); i++)
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    arr1[i, j] = rnd.Next(6, 10);


                }
        }
        public static int MineCount()
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
        public static string MineCount1()
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
