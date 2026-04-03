using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Atestat_Alexandru_Salaghe
{
    public partial class Testul_1 : Form
    {
        Random nr = new Random();
        int n, nr_intreb = 1;
        int[] ap = new int[100];
        string[] intreb = new string[1000];
        string[] intreb1 = new string[1000];
        string[] intreb2 = new string[1000];
        string[] ra = new string[100];
        string[] rb = new string[100];
        string[] rc = new string[100];
        string[] rd = new string[100];
        string[] corect = new string[100];
        string litera;


        public Testul_1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            radioButton1.Visible = true;
            radioButton2.Visible = true;
            radioButton3.Visible = true;
            radioButton4.Visible = true;
            label1.Visible = true;
            label4.Visible = true;
            button2.Visible = true;
            label6.Visible = true;
            StreamReader f = new StreamReader(@"intrebari.txt");
            n = Convert.ToInt32(f.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                intreb[i] = f.ReadLine();
                intreb1[i] = f.ReadLine();
                intreb2[i] = f.ReadLine();
                ra[i] = f.ReadLine();
                rb[i] = f.ReadLine();
                rc[i] = f.ReadLine();
                rd[i] = f.ReadLine();
                corect[i] = f.ReadLine();
            }
            for(int i=1;i<=n;i++)
            {
                richTextBox1.Text = richTextBox1.Text+"\n"+ intreb[i] + "\n " + intreb1[i] + "\n" + intreb2[i] + "\n " + ra[i] + "\n " + rb[i] + "\n " + rc[i] + "\n " + rd[i] + "\n " + corect[i] + "\n";
            }
            int x;
            x = 1 + nr.Next(9);
            ap[x] = 1;
            label1.Text = intreb[x];
            label4.Text = intreb1[x];
            label6.Text = intreb2[x];
            radioButton1.Text = ra[x];
            radioButton2.Text = rb[x];
            radioButton3.Text = rc[x];
            radioButton4.Text = rd[x];
            button2.Enabled = true;
            button1.Enabled = false;
            litera = corect[x];


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            nr_intreb++;
            if (nr_intreb > 9)
            {
                if (radioButton1.Checked && litera == "a" ||
                    radioButton2.Checked && litera == "b" ||
                    radioButton3.Checked && litera == "c" ||
                    radioButton4.Checked && litera == "d")
                {
                    int z = Convert.ToInt32(label5.Text);
                    z++;
                    label5.Text = Convert.ToString(z);
                }

                    MessageBox.Show("test finalizat");
                button2.Enabled = false;
                Form1 f1 = new Form1();
                f1.Show();               
                Close();
                
            }
            else
            {
                if (radioButton1.Checked && litera == "a" ||
                    radioButton2.Checked && litera == "b" ||
                    radioButton3.Checked && litera == "c" ||
                    radioButton4.Checked && litera == "d")
                {
                    int z = Convert.ToInt32(label5.Text);
                    z++;
                    label5.Text = Convert.ToString(z);
                }

                int x;
                do
                {
                    x =  1 + nr.Next(9);
                } while (ap[x] == 1);

                ap[x] = 1;
                label1.Text = intreb[x];
                label4.Text = intreb1[x];
                label6.Text = intreb2[x];
                radioButton1.Text = ra[x];
                radioButton2.Text = rb[x];
                radioButton3.Text = rc[x];
                radioButton4.Text = rd[x];
                litera = corect[x];
            }


        }
    }
}