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
    public partial class ClasaXI : Form
    {
        public ClasaXI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();
            Form1 back = new Form1();
            back.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.pbinfo.ro/articole/11234/generarea-permutarilor");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.pbinfo.ro/articole/810/grafuri-neorientate");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.pbinfo.ro/articole/6036/tare-conexitate");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.pbinfo.ro/articole/16597/metoda-backtracking");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.pbinfo.ro/articole/26111/generarea-aranjamantelor");
        }

        private void button5_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Process.Start("https://www.pbinfo.ro/articole/26112/generarea-combinarilor");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.pbinfo.ro/articole/137/generarea-submultimilor");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.pbinfo.ro/articole/8/parcurgerea-grafurilor-neorientate");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.pbinfo.ro/articole/5792/graf-eulerian");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.pbinfo.ro/articole/5790/graf-hamiltonian");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.pbinfo.ro/articole/509/grafuri-orientate");
        }

       

       
    }
}
