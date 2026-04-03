using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atestat_Alexandru_Salaghe
{
    public partial class Variante_bacalaureat : Form
    {
        public Variante_bacalaureat()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 back = new Form1();
            back.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://bac.simplu.info/vezi-pdf/web/viewer?file=https://arhiva.simplu.info/bac/info/variante-2020/informatica_2020_sp_mi_c_test_01.pdf");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://bac.simplu.info/vezi-pdf/web/viewer?file=https://arhiva.simplu.info/bac/info/variante-2020/informatica_2020_sp_mi_c_test_02.pdf");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://bac.simplu.info/vezi-pdf/web/viewer?file=https://arhiva.simplu.info/bac/info/variante-2020/informatica_2020_sp_mi_c_test_03.pdf");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://bac.simplu.info/vezi-pdf/web/viewer?file=https://arhiva.simplu.info/bac/info/variante-2020/informatica_2020_sp_mi_c_test_04.pdf");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://bac.simplu.info/vezi-pdf/web/viewer?file=https://arhiva.simplu.info/bac/info/variante-2020/informatica_2020_sp_mi_bar_01.pdf");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://bac.simplu.info/vezi-pdf/web/viewer?file=https://arhiva.simplu.info/bac/info/variante-2020/informatica_2020_sp_mi_bar_02.pdf");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://bac.simplu.info/vezi-pdf/web/viewer?file=https://arhiva.simplu.info/bac/info/variante-2020/informatica_2020_sp_mi_bar_03.pdf");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://bac.simplu.info/vezi-pdf/web/viewer?file=https://arhiva.simplu.info/bac/info/variante-2020/informatica_2020_sp_mi_bar_04.pdf");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://bac.simplu.info/vezi-pdf/web/viewer?file=https://arhiva.simplu.info/bac/info/variante-2020/informatica_2020_sp_mi_bar_05.pdf");
        }

        private void button6_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Process.Start("https://bac.simplu.info/vezi-pdf/web/viewer?file=https://arhiva.simplu.info/bac/info/variante-2020/informatica_2020_sp_mi_c_test_05.pdf");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://bac.simplu.info/info/variante-2020/");
        }
    }
}
