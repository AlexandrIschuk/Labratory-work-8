
using System.ComponentModel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Diagnostics;
using System.Linq.Expressions;
using Microsoft.VisualBasic.ApplicationServices;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.Runtime.CompilerServices;
using Timer = System.Windows.Forms.Timer;
using System;

namespace Ischuk.lab8
{
    public partial class Form1 : Form
    {
        DateTime date;
        public Form1()
        {
            InitializeComponent();
            InitB();
            TicTac.Random2DArray(Arr2D, 4, 4);
            Sorting.Copy(arr, arr1);
            Miner.RandomArr();
            Miner.ArrZeroOpen();
            textBox19.Text = Miner.MineCount1();
            Miner.MineCount();  
        }
        static bool start = false;
        int timer2 = 0;
        string SecondStr = "";
        int count = 0;
        int Count1 = 0;
        int i = 0; 
        char[,] Arr2D = new char[4, 4];
        int[] arr = new int[0];
        int[] arr1 = new int[0];
        int[,] arr2 = new int[10, 10];
        private Button[,] S = new Button[10, 10];
        public static double Mcount = Miner.MineCount();


        public void InitB()
        {
            for (int i = 0; i < 10; ++i)
                for (int j = 0; j < 10; ++j)
                {
                    S[i, j] = new Button();
                    S[i, j].Location = new Point(550 + (i * 50), 100 + (j * 50));
                    S[i, j].Size = new Size(50, 50);
                    S[i, j].BackgroundImage = Ischuk.lab8.Properties.Resources.closed;
                    S[i, j].BackgroundImageLayout = ImageLayout.Zoom;
                    S[i, j].FlatStyle = FlatStyle.Popup;
                    S[i, j].Click += new EventHandler(Button1_Click);
                    S[i, j].MouseUp += new MouseEventHandler(Button1_MouseUp);
                    tabPage1.Controls.Add(S[i, j]);

                }
        }
        void StartWatch()
        {
            start = true;
            timer1();
        }
        public static void StopWatch()
        {
            start = false;
        }
        public void timer1()
        {
            date = DateTime.Now;

            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(TickTimer);
            timer.Start();
        }
        private void TickTimer(object sender, EventArgs e)
        {
            long Tick = DateTime.Now.Ticks - date.Ticks;
            DateTime stopWatch = new DateTime();
            stopWatch = stopWatch.AddTicks(Tick);
            if (start)
            {
                label1.Text = "0" + string.Format("{00:ss}", stopWatch);
                Miner.timeend = string.Format("{0:ss}", stopWatch).ToString();
            }
        }
        private void buttonCount_Click(object sender, EventArgs e)
        {
            if (label5.Text == "Ответ неверный." || label5.Text == "")
            {
                double a = 0;
                double b = 0;
                double otv = 0;
                if (!double.TryParse(textBox4.Text, out a) || !double.TryParse(textBox5.Text, out b) || !double.TryParse(textBox6.Text, out otv))
                    MessageBox.Show("Ошибка ввода!");
                else
                {
                    label5.Text = Function.function(a, b, otv, i);
                    if (label5.Text == "Ответ верный.")
                    {
                        i = 0;
                    }
                    else
                    {
                        i++;
                        textBox6.Text = "";
                    }
                }
            }
            else if (label5.Text == "Ответ верный.")
            {
                MessageBox.Show("Игра завершена!");
            }
            else
            {
                MessageBox.Show("Попытки закончились.\nПопробуйте еще раз!");
            }


        }
        private void buttonFunDel_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            label5.Text = "";


        }
        private void NewArrBut_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                int lenArr = 0;
                if (!int.TryParse(textBoxLen.Text, out lenArr) || lenArr <= 1)
                    MessageBox.Show("Длинна массива должна превышать единицу\nили введено не число!");
                else
                {
                    arr = new int[lenArr];
                    Sorting.RandomArray(arr);
                    arr1 = new int[lenArr];
                    Sorting.Copy(arr, arr1);
                    int m = arr.Length;
                    if (m <= 100)
                    {
                        dataGridView1.ColumnCount = m;
                        for (int i = 0; i < m; i++)
                        {
                            dataGridView1.Rows[0].Cells[i].Value = arr[i];
                        }
                    }
                    else
                    {
                        dataGridView1.ColumnCount = 1;
                        dataGridView1.Columns[0].Width = 700;
                        dataGridView1.Rows[0].Cells[0].Value = "Массив создан";
                    }
                }
            }
            else
                MessageBox.Show("Массив уже создан");
        }
        private void SortBut_Click(object sender, EventArgs e)
        {
            long t = 0;
            t = Sorting.ShellSortTime(arr, t);
            long t1 = 0;
            t1 = Sorting.ShakerSortTime(arr1, t1);
            label6.Text = ("Время сортировки: " + t + " Мс");
            label7.Text = ("Время сортировки: " + t1 + " Мс");
            label8.Text = Sorting.sort(arr, arr1, t, t1);
            int h = arr.Length;
            if (h <= 100)
            {
                dataGridView2.ColumnCount = h;
                for (int i = 0; i < h; i++)
                {
                    dataGridView2.Rows[0].Cells[i].Value = arr[i];
                }
                int n = arr1.Length;
                dataGridView3.ColumnCount = n;
                for (int i = 0; i < n; i++)
                {
                    dataGridView3.Rows[0].Cells[i].Value = arr1[i];

                }
            }
            else
            {
                dataGridView2.ColumnCount = 1;
                dataGridView2.Columns[0].Width = 700;
                dataGridView2.Rows[0].Cells[0].Value = "Массив отсортирован";

                dataGridView3.ColumnCount = 1;
                dataGridView3.Columns[0].Width = 700;
                dataGridView3.Rows[0].Cells[0].Value = "Массив отсортирован";
            }

        }
        private void DelBut_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            dataGridView3.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView2.Columns.Clear();
            dataGridView3.Columns.Clear();
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
        }
        private void StrBut1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBoxString.Text = String.TestString();
                label22.Text = String.VowCon(String.TestString());
            }
            else
            {
                label22.Text = String.VowCon(textBoxString.Text);
            }
        }
        private void StrBut2_Click_1(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                textBoxString.Text = String.TestString();
                label23.Text = String.Acount(String.TestString());


            }
            else
            {
                label23.Text = String.Acount(textBoxString.Text);
            }
        }
        private void StrBut3_Click(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                textBoxString.Text = String.TestString1() + String.TestString2();
                label24.Text = String.EqualString(String.TestString1(), String.TestString2());
            }
            else
            {
                if (SecondStr == "")
                {
                    MessageBox.Show("Сначала введите вторую строку!");
                }
                else
                {
                    label24.Text = String.EqualString(SecondStr, textBoxString.Text);

                }
            }
        }
        private void ButDelStr_Click(object sender, EventArgs e)
        {
            textBoxString.Text = "";
            label22.Text = "";
            label23.Text = "";
            label24.Text = "";

        }
        private void buttonSecArr_Click(object sender, EventArgs e)
        {
            SecondStr = textBoxString.Text;
            textBoxString.Text = "";
        }
        private void TicTacRestGameBut_Click(object sender, EventArgs e)
        {
            label13.Text = "";
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            pictureBox4.Image = null;
            pictureBox5.Image = null;
            pictureBox6.Image = null;
            pictureBox7.Image = null;
            pictureBox8.Image = null;
            pictureBox9.Image = null;
            Count1 = 0;
            count = 0;
            TicTac.Random2DArray(Arr2D, 4, 4);
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (label13.Text != "")
            {
                MessageBox.Show("Игра завершена. Начните заново.");
            }
            else if (pictureBox1.Image == null)
            {
                if (Count1 % 2 == 0)
                {
                    pictureBox1.Image = Ischuk.lab8.Properties.Resources.x;
                    Arr2D[1, 1] = 'X';
                    label13.Text = TicTac.GameFunForX(Arr2D, count, Count1);
                }
                else
                {
                    pictureBox1.Image = Ischuk.lab8.Properties.Resources.o;
                    Arr2D[1, 1] = 'O';
                    label13.Text = TicTac.GameFunForZero(Arr2D, count, Count1);
                }
                Count1++;
            }
            else
            {
                MessageBox.Show("Клетка занята");
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (label13.Text != "")
            {
                MessageBox.Show("Игра завершена. Начните заново.");
            }
            else if (pictureBox2.Image == null)
            {
                if (Count1 % 2 == 0)
                {
                    pictureBox2.Image = Ischuk.lab8.Properties.Resources.x;
                    Arr2D[2, 1] = 'X';
                    label13.Text = TicTac.GameFunForX(Arr2D, count, Count1);
                }
                else
                {
                    pictureBox2.Image = Ischuk.lab8.Properties.Resources.o;
                    Arr2D[2, 1] = 'O';
                    label13.Text = TicTac.GameFunForZero(Arr2D, count, Count1);
                }
                Count1++;
            }
            else
            {
                MessageBox.Show("Клетка занята");
            }

        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (label13.Text != "")
            {
                MessageBox.Show("Игра завершена. Начните заново.");
            }
            else if (pictureBox3.Image == null)
            {
                if (Count1 % 2 == 0)
                {
                    pictureBox3.Image = Ischuk.lab8.Properties.Resources.x;
                    Arr2D[3, 1] = 'X';
                    label13.Text = TicTac.GameFunForX(Arr2D, count, Count1);
                }
                else
                {
                    pictureBox3.Image = Ischuk.lab8.Properties.Resources.o;
                    Arr2D[3, 1] = 'O';
                    label13.Text = TicTac.GameFunForZero(Arr2D, count, Count1);
                }
                Count1++;
            }
            else
            {
                MessageBox.Show("Клетка занята");
            }
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (label13.Text != "")
            {
                MessageBox.Show("Игра завершена. Начните заново.");
            }
            else if (pictureBox4.Image == null)
            {
                if (Count1 % 2 == 0)
                {
                    pictureBox4.Image = Ischuk.lab8.Properties.Resources.x;
                    Arr2D[1, 2] = 'X';
                    label13.Text = TicTac.GameFunForX(Arr2D, count, Count1);
                }
                else
                {
                    pictureBox4.Image = Ischuk.lab8.Properties.Resources.o;
                    Arr2D[1, 2] = 'O';
                    label13.Text = TicTac.GameFunForZero(Arr2D, count, Count1);
                }
                Count1++;
            }
            else
            {
                MessageBox.Show("Клетка занята");
            }
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (label13.Text != "")
            {
                MessageBox.Show("Игра завершена. Начните заново.");
            }
            else if (pictureBox5.Image == null)
            {
                if (Count1 % 2 == 0)
                {
                    pictureBox5.Image = Ischuk.lab8.Properties.Resources.x;
                    Arr2D[2, 2] = 'X';
                    label13.Text = TicTac.GameFunForX(Arr2D, count, Count1);
                }
                else
                {
                    pictureBox5.Image = Ischuk.lab8.Properties.Resources.o;
                    Arr2D[2, 2] = 'O';
                    label13.Text = TicTac.GameFunForZero(Arr2D, count, Count1);
                }
                Count1++;
            }
            else
            {
                MessageBox.Show("Клетка занята");
            }
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (label13.Text != "")
            {
                MessageBox.Show("Игра завершена. Начните заново.");
            }
            else if (pictureBox6.Image == null)
            {
                if (Count1 % 2 == 0)
                {
                    pictureBox6.Image = Ischuk.lab8.Properties.Resources.x;
                    Arr2D[3, 2] = 'X';
                    label13.Text = TicTac.GameFunForX(Arr2D, count, Count1);
                }
                else
                {
                    pictureBox6.Image = Ischuk.lab8.Properties.Resources.o;
                    Arr2D[3, 2] = 'O';
                    label13.Text = TicTac.GameFunForZero(Arr2D, count, Count1);
                }
                Count1++;
            }
            else
            {
                MessageBox.Show("Клетка занята");
            }
        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (label13.Text != "")
            {
                MessageBox.Show("Игра завершена. Начните заново.");
            }
            else if (pictureBox7.Image == null)
            {
                if (Count1 % 2 == 0)
                {
                    pictureBox7.Image = Ischuk.lab8.Properties.Resources.x;
                    Arr2D[1, 3] = 'X';
                    label13.Text = TicTac.GameFunForX(Arr2D, count, Count1);
                }
                else
                {
                    pictureBox7.Image = Ischuk.lab8.Properties.Resources.o;
                    Arr2D[1, 3] = 'O';
                    label13.Text = TicTac.GameFunForZero(Arr2D, count, Count1);
                }
                Count1++;
            }
            else
            {
                MessageBox.Show("Клетка занята");
            }

        }
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (label13.Text != "")
            {
                MessageBox.Show("Игра завершена. Начните заново.");
            }
            else if (pictureBox8.Image == null)
            {
                if (Count1 % 2 == 0)
                {
                    pictureBox8.Image = Ischuk.lab8.Properties.Resources.x;
                    Arr2D[2, 3] = 'X';
                    label13.Text = TicTac.GameFunForX(Arr2D, count, Count1);
                }
                else
                {
                    pictureBox8.Image = Ischuk.lab8.Properties.Resources.o;
                    Arr2D[2, 3] = 'O';
                    label13.Text = TicTac.GameFunForZero(Arr2D, count, Count1);
                }
                Count1++;
            }
            else
            {
                MessageBox.Show("Клетка занята");
            }

        }
        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (label13.Text != "")
            {
                MessageBox.Show("Игра завершена. Начните заново.");
            }
            else if (pictureBox9.Image == null)
            {
                if (Count1 % 2 == 0)
                {
                    pictureBox9.Image = Ischuk.lab8.Properties.Resources.x;
                    Arr2D[3, 3] = 'X';
                    label13.Text = TicTac.GameFunForX(Arr2D, count, Count1);
                }
                else
                {
                    pictureBox9.Image = Ischuk.lab8.Properties.Resources.o;
                    Arr2D[3, 3] = 'O';
                    label13.Text = TicTac.GameFunForZero(Arr2D, count, Count1);
                }
                Count1++;
            }
            else
            {
                MessageBox.Show("Клетка занята");
            }

        }
        private void form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            const string message =
                "Вы действительно хотите выйти?";
            const string caption = "Form Closing";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }

        }
        public void Button1_Click(object sender, EventArgs e)
        {
            
            if (!Miner.EndGame)
            {
                if (timer2 == 0)
                {
                    StartWatch();
                    timer2++;
                }
                for (int i = 0; i < 10; ++i)
                    for (int j = 0; j < 10; ++j)
                    {
                        if (sender == S[i, j])
                        {
                            Miner.GameFunction2(S, i, j,label18,MinerRestart);
                            if (Miner.arr[i, j] < 10)
                            {
                                S[i, j].Enabled = false;
                            }
                        }
                    }
            }
            else
            {
                MessageBox.Show("Игра завершена.\nНажмите на смайлик чтобы начать заново.");
                
                
            }
        }
        private void Button1_MouseUp(object sender, MouseEventArgs e)
        {
            if (!Miner.EndGame)
            {
                if (e.Button == MouseButtons.Right)
                {
                    if (timer2 == 0)
                    {
                        StartWatch();
                        timer2++;
                    }
                    for (int i = 0; i < 10; ++i)
                        for (int j = 0; j < 10; ++j)
                        {
                            if (sender == S[i, j])
                            {
                                if (Miner.arr[i, j]>=10)
                                {
                                    S[i, j].BackgroundImage = Ischuk.lab8.Properties.Resources.closed;
                                    Miner.arr[i, j] = Miner.arr[i, j] - 10;
                                    Miner.FlagCount();
                                    Miner.Winner(label18);
                                }
                                else
                                {
                                    S[i, j].BackgroundImage = Ischuk.lab8.Properties.Resources.flaged;
                                    Miner.arr[i, j] = Miner.arr[i, j] + 10; 
                                    Miner.FlagCount();
                                    Miner.Winner(label18);
                                }
                            }
                        }
                }
            }
            else
            {
                MessageBox.Show("Игра завершена.\nНажмите на смайлик чтобы начать заново.");


            }

        }
        private void MinerRestart_Click(object sender, EventArgs e)
        {
            label18.Text = "";
            label1.Text = "000";
            Miner.EndGame = false;
            timer2 = 0;
            StopWatch();
            Miner.sum = 0;
            MinerRestart.BackgroundImage = Ischuk.lab8.Properties.Resources.MineRes2;
            Miner.RandomArr();
            Miner.ArrZeroOpen();
            textBox19.Text = Miner.MineCount1();
            for (int i = 0; i < 10; ++i)
                for (int j = 0; j < 10; ++j)
                {
                    S[i, j].Enabled = true;
                    S[i, j].BackgroundImage = Ischuk.lab8.Properties.Resources.closed;
                }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
