using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CENG307_171180005_HW1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView_lich.AllowUserToAddRows = false;
            dataGridView_eisch.AllowUserToAddRows = false;
            dataGridView_reisch.AllowUserToAddRows = false;
            dataGridView_blisch.AllowUserToAddRows = false;
            dataGridView_data.AllowUserToAddRows = false;

        }
        static int keys_size, arr_size;
        public static int[,] arr = new int[arr_size, 3];
        public static int[] keys = new int[keys_size];

        int[,] arr_reisch;

        static void nullvalues(int[,]arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                    arr[i, j] = -1;
            }
        }
        private void button_table_Click(object sender, EventArgs e)
        {
            if (rb_prime.Checked)
            {
                
                keys_size = Convert.ToInt32(txt_keys_size.Text);
                if(keys_size>900)
                {
                    MessageBox.Show("Keys Size must be at most 900");
                    txt_keys_size.Text = "";
                    arr_size = 0;
                    lbl_table.Text = "Table Size: ";
                }
                arr_size = primeNum(keys_size * 100 / 90);
                lbl_table.Text = "Table Size: " + arr_size.ToString();
            }
            else if(rb_notPrime.Checked)
            {
                keys_size = Convert.ToInt32(txt_keys_size.Text);
                if (keys_size > 900)
                {
                    MessageBox.Show("Keys Size must be at most 900");
                    txt_keys_size.Text = "";
                    arr_size = 0;
                    lbl_table.Text = "Table Size: ";
                }
                arr_size = keys_size * 100 / 90;
                lbl_table.Text = "Table Size: " + arr_size.ToString();
            }
            else
            {
                MessageBox.Show("Please select the Prime or Not Prime radio button.");

            }
            arr = new int[arr_size, 3];
            arr_reisch = new int[arr_size, 3];
            keys = new int[10] {31,23,12,6,9,11,70,61,41,56};

            nullvalues(arr);
            dataGridView_data.Rows.Clear();
            Random rand = new Random();
            for (int i = 0; i < keys.Length; i++)
            {
               /* start:
                keys[i] =  rand.Next(1,100);
                for (int j = 0; j < i; j++)
                {
                    if (keys[i] == keys[j])
                    {
                        goto start;
                    }
                }*/
                
                dataGridView_data.Rows.Add(keys[i], i);
            }

            label13.Text = String.Format("Packing Factor: %{0:0.##}" , packing_factor(arr_size, keys_size) ) ;
           // txt_pri.Text = lich_pri(arr_size).ToString();
        }
        int lich_pri(int arr_size)
        {
            // %86 address factor 860 primary area 140 cellar
            return arr_size * 86 / 100;
        }

        int counter = 0;
        
        private void txt_keys_size_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (counter > txt_keys_size.Text.Length && counter == 0)
                {
                    counter = txt_keys_size.Text.Length;
                }
                else
                {
                    counter = txt_keys_size.Text.Length;

                    int size = Convert.ToInt32(txt_keys_size.Text);
                    if (size <= 900)

                        if (rb_prime.Checked)
                        {
                            arr_size = primeNum(size * 100 / 90);
                            int pri = lich_pri(arr_size);
                            txt_pri.Text = pri.ToString();
                            lbl_table.Text = "Table Size: " + arr_size.ToString();
                            toolTip1.Active = true;
                        }
                        else if (rb_notPrime.Checked)
                        {
                            arr_size = size * 100 / 90;
                            int pri = lich_pri(arr_size);
                            txt_pri.Text = pri.ToString();
                            lbl_table.Text = "Table Size: " + arr_size.ToString();
                            toolTip1.Active = true;
                        }
                        else
                        {
                            MessageBox.Show("Please select the Prime or Not Prime radio button.");
                            int pri = lich_pri(arr_size);
                            txt_pri.Text = pri.ToString();
                            lbl_table.Text = "Table Size: ";
                            toolTip1.Active = true;
                        }
                    else
                    {
                        MessageBox.Show("Keys Size must be at most 900");
                        txt_keys_size.Text = "";
                        txt_pri.Text = "";
                        arr_size = 0;
                        lbl_table.Text = "Table Size: ";
                    }
                }
            }
            catch
            {
                txt_keys_size.Text = "";
                MessageBox.Show("Please Please enter a 'Keys Size' ");
            }
        }
        double packing_factor(int arr_size, int keys_size)
        {
            return Convert.ToDouble(keys_size) / (arr_size) * 100;
        }
        public  int primeNum(double prime)
        {
            start:
            for (int i = 2; i <= (int)Math.Sqrt(prime); i++)
            {
                if (prime % i == 0)
                {
                    prime = prime + 1;
                    goto start;
                }
            }
            return (int)prime;
        }
        private void button_LICH_Click(object sender, EventArgs e)
        {
            try
            {
                Stopwatch watch = new Stopwatch();
                nullvalues(arr);
                int mod = Convert.ToInt32(txt_pri.Text);

                watch.Start();
                LICH(arr, keys, mod);
                watch.Stop();

                print_LICH(arr);
                lbl_lich_performance.Text = "LICH Performance: " + watch.Elapsed.TotalMilliseconds.ToString()+" ms";
                lbl_avg_lich.Text = String.Format("For LICH Average Number of Probes: {0:0.##}", avgProbes(arr));
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please enter a number for the Primary Area Size.\n" + ex.Message);
            }
        }
        double avgProbes(int[,] arr)
        {
            double sum = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                if (arr[i, 2] != -1)
                    sum += arr[i, 2];
            }
            return sum / (double)keys_size;
        }
        private void button_EISCH_Click(object sender, EventArgs e)
        {
            Stopwatch watch = new Stopwatch();
            nullvalues(arr);

            watch.Start();
            EISCH(arr, keys, arr.GetLength(0));
            watch.Stop();

            print_EISCH(arr);
            lbl_eisch_performance.Text ="EISCH Performance: "+ watch.Elapsed.TotalMilliseconds.ToString() + " ms";
            lbl_avg_eisch.Text = String.Format("For EISCH Average Number of Probes: {0:0.##}", avgProbes(arr));

        }
        private void button_REISCH_Click(object sender, EventArgs e)
        {
            Stopwatch watch = new Stopwatch();
            nullvalues(arr);
            nullvalues(arr_reisch);

            watch.Start();
            REISCH(arr, keys, arr.GetLength(0));
            watch.Stop();

            arr_reisch = (int[,])arr.Clone();
            print_REISCH(arr_reisch);
            lbl_reisch_performance.Text = "REISCH Performance: " + watch.Elapsed.TotalMilliseconds.ToString() + " ms";
            lbl_avg_reisch.Text = String.Format("For REISCH Average Number of Probes: {0:0.##}", avgProbes(arr));

        }
        private void button_BLISCH_Click(object sender, EventArgs e)
        {
            Stopwatch watch = new Stopwatch();
            nullvalues(arr);

            watch.Start();
            BLISCH(arr, keys, arr.GetLength(0));
            watch.Stop();

            print_BLISCH(arr);
            lbl_blisch_performance.Text = "BLISCH Performance: " + watch.Elapsed.TotalMilliseconds.ToString() + " ms";
            lbl_avg_blisch.Text = String.Format("For BLISCH Average Number of Probes: {0:0.##}", avgProbes(arr));

        }
        static void setProbes(int[,] arr, int[] keys, int mod)
        {
            for (int i = 0; i < keys.GetLength(0); i++)
            {
                int index = keys[i] % mod;
                int link = arr[index, 1];
                if (arr[index, 0] == keys[i])
                {
                    arr[index, 2] = 1; //probe 1
                }
                else
                {
                    int probe = 2;
                    while (true)
                    {
                        if (arr[link, 0] == keys[i])
                        {
                            arr[link, 2] = probe;
                            break;
                        }
                        else
                        {
                            link = arr[link, 1];
                            probe++;
                        }
                    }
                }

            }
        }
        void print_LICH(int[,] arr)
        {
            dataGridView_lich.Rows.Clear();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                dataGridView_lich.Rows.Add(i, arr[i, 0], arr[i, 1], arr[i, 2]);
            }
        }
        void print_EISCH(int[,] arr)
        {
            dataGridView_eisch.Rows.Clear();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                dataGridView_eisch.Rows.Add(i, arr[i, 0], arr[i, 1], arr[i, 2]);
            }
        }
        void print_REISCH(int[,] arr)
        {
            dataGridView_reisch.Rows.Clear();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                dataGridView_reisch.Rows.Add(i, arr[i, 0], arr[i, 1], arr[i, 2]);
            }
        }
        void print_BLISCH(int[,] arr)
        {
            dataGridView_blisch.Rows.Clear();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                dataGridView_blisch.Rows.Add(i, arr[i, 0], arr[i, 1], arr[i, 2]);
            }
        }
       
        static void BLISCH(int[,] arr, int[] keys, int mod)
        {
            int index;
            int counter = 0;
            for (int i = 0; i < keys.Length; i++)
            {
                index = keys[i] % mod;
                if (arr[index, 0] == -1) 
                {
                    arr[index, 0] = keys[i];
                    arr[index, 2] = 1; 
                }
                else 
                {
                    int probe = 2;
                    if (counter % 2 == 0) 
                    {
                        counter++;
                        for (int j = 0; j < arr.GetLength(0); j++)
                        {
                            if (arr[j, 0] == -1) 
                            {
                                arr[j, 0] = keys[i]; 
                                if (arr[index, 1] == -1) 
                                {
                                    arr[index, 1] = j;
                                    arr[j, 2] = probe; 
                                }
                                else
                                {
                                    int link = arr[index, 1];

                                    while (true)
                                    {
                                        if (arr[link, 1] == -1)
                                        {
                                            arr[link, 1] = j; 

                                            probe++;
                                            arr[j, 2] = probe; 

                                            break;
                                        }
                                        else
                                        {
                                            link = arr[link, 1];
                                            probe++;

                                        }
                                    }
                                }
                                break;
                            }
                        }
                    }
                    else
                    {
                        counter++;
                        for (int j = arr.GetLength(0) - 1; j >= 0; j--)
                        {

                            if (arr[j, 0] == -1) 
                            {
                                arr[j, 0] = keys[i]; 
                                if (arr[index, 1] == -1)
                                {
                                    arr[index, 1] = j;
                                    arr[j, 2] = probe; 
                                }
                                else
                                {
                                    int link = arr[index, 1]; 

                                    while (true)
                                    {
                                        if (arr[link, 1] == -1)
                                        {
                                            arr[link, 1] = j; 

                                            probe++;
                                            arr[j, 2] = probe;

                                            break;
                                        }
                                        else
                                        {
                                            link = arr[link, 1];
                                            probe++;

                                        }
                                    }
                                }
                                break;
                            }
                        }
                    }
                }
            }
            setProbes(arr, keys, mod);
        }
        void REISCH(int[,] arr, int[] keys, int mod)
        {
            Random rand = new Random();
            int index;
            for (int i = 0; i < keys.Length; i++)
            {

                index = keys[i] % mod;
                if (arr[index, 0] == -1)
                {
                    arr[index, 0] = keys[i];
                    arr[index, 2] = 1;
                }
                else
                {
                    int probe = 2;

                    while (true)
                    {
                        int randomPlace = rand.Next(0, arr.GetLength(0) - 1);

                        if (arr[randomPlace, 0] == -1)
                        {
                            
                            arr[randomPlace, 0] = keys[i];
                            if (arr[index, 1] == -1)
                            {
                                arr[index, 1] = randomPlace;
                                arr[randomPlace, 2] = probe;
                                break;
                            }
                            else
                            {
                                arr[randomPlace, 1] = arr[index, 1];
                                arr[index, 1] = randomPlace;
                                arr[randomPlace, 2] = probe;
                                int link = randomPlace;
                                while (arr[link, 1] != -1)
                                {
                                    link = arr[link, 1];
                                    if (arr[link, 0] % mod == index)
                                    {

                                        int m = arr[link, 2] + 1;
                                        arr[link, 2] = m;
                                    }
                                    else
                                    {
                                        break;
                                    }

                                }
                                break;
                            }
                        }
                    }
                }
            }
            setProbes(arr, keys, mod);
        }
        static void LICH(int[,] arr, int[] keys, int mod)
        {
            int index;
            nullvalues(arr);
            // %86 overflow 860 primary area 140 cellar
            for (int i = 0; i < keys.Length; i++)
            {
                index = keys[i] % mod;

                if (arr[index, 0] == -1)
                {
                    arr[index, 0] = keys[i];
                    arr[index, 2] = 1; 

                }
                else
                {
                    for (int j = arr.GetLength(0) - 1; j >= 0; j--)
                    {
                        if (arr[j, 0] == -1)  
                        {
                            int probe = 2;
                            arr[j, 0] = keys[i]; 
                            int l = arr[index, 1];
                            while (true)
                            {
                                if (l == -1) 
                                {
                                    arr[index, 1] = j;
                                    arr[j, 2] = probe; 
                                    break;
                                }
                                else
                                {
                                    if (arr[l, 1] == -1)
                                    {
                                        arr[l, 1] = j;
                                        probe++;
                                        arr[j, 2] = probe; 
                                        break;
                                    }
                                    else
                                    {
                                        l = arr[l, 1];
                                        probe++;
                                    }
                                }
                            }
                            break;
                        }

                    }

                }
            }
            setProbes(arr, keys, mod);
        }
         void EISCH(int[,] arr, int[] keys, int mod)
        {
            int index;
            nullvalues(arr);
            for (int i = 0; i < keys.Length; i++)
            {
                index = keys[i] % mod;
                label4.Text += index.ToString()+ ",  ";
                if (arr[index, 0] == -1) 
                {
                    arr[index, 0] = keys[i];
                    arr[index, 2] = 1; 
                }
                else
                {
                    for (int j = arr.GetLength(0) - 1; j >= 0; j--)
                    {
                        if (arr[j, 0] == -1)
                        {

                            arr[j, 0] = keys[i]; 
                            arr[j, 1] = arr[index, 1]; 
                            arr[j, 2] = 2; 
                            arr[index, 1] = j; 
                            int l = j; 
                            while (arr[l, 1] != -1)
                            {
                                l = arr[l, 1];
                                if (arr[l,0] % mod == index)
                                {
                                    
                                    int m = arr[l, 2] + 1;
                                    arr[l, 2] = m;
                                }
                                else
                                {
                                    break;
                                }
                               
                            }
                            break;
                        }
                    }
                   
                }
            }
            setProbes(arr, keys, mod);
        }

        private void button_LICH_SEARCH_Click(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(txt_search.Text);
                int mod = Convert.ToInt32(txt_pri.Text);
                nullvalues(arr);

                LICH(arr, keys, mod);
                string text = "In LICH search, ";
                _search(arr, x, mod,text);
            }
            catch
            {
                MessageBox.Show("Please enter the number that you are looking for");

            }
        }
        private void button_EISCH_SEARCH_Click(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(txt_search.Text);
                int mod = arr.GetLength(0);
                nullvalues(arr);
                EISCH(arr, keys, mod);
                string text = "In EISCH search, ";
                _search(arr, x, mod, text);
            }
            catch
            {
                MessageBox.Show("Please enter the number you are looking for");

            }
        }
        private void button_REISCH_SEARCH_Click(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(txt_search.Text);
                int mod = arr_reisch.GetLength(0);

                string text = "In REISCH search, ";
                _search(arr_reisch, x, mod, text);
            }
            catch
            {
                MessageBox.Show("Please enter the number you are looking for");

            }

        }
        private void button_BLISCH_SEARCH_Click(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(txt_search.Text);
                int mod = arr.GetLength(0);
                nullvalues(arr);
                BLISCH(arr, keys, mod);
                string text = "In BLISCH search, ";
                _search(arr, x, mod, text);
            }
            catch
            {
                MessageBox.Show("Please enter the number you are looking for");
            }
        }
        void _search(int[,] arr, int x, int mod,string text)
        {
            int index = x % mod;
            int link = arr[index, 1];
            try
            {
                if (arr[index, 0] == x)
                {
                    lb_status.Items.Add(text + x + " was found in 1 step in index " + index + ".");
                }
                else
                {
                    int step = 2;
                    while (true)
                    {
                        if (arr[link, 0] == x)
                        {
                            lb_status.Items.Add(text + x + " was found in " + step + " steps in index " + link + ".");
                            break;
                        }
                        else
                        {
                            link = arr[link, 1];
                            step++;
                        }
                    }
                }
            }
            catch
            {
                lb_status.Items.Add("The number " + x + " you were looking for could not be found.");
            }
        }
    }
}
