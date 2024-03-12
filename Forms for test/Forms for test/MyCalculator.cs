using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_for_test
{
    public partial class MyCalculator : Form
    {
        public MyCalculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kontrolkaWprowadzania.Text = kontrolkaWprowadzania.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kontrolkaWprowadzania.Text = kontrolkaWprowadzania.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kontrolkaWprowadzania.Text = kontrolkaWprowadzania.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            kontrolkaWprowadzania.Text = kontrolkaWprowadzania.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            kontrolkaWprowadzania.Text = kontrolkaWprowadzania.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            kontrolkaWprowadzania.Text = kontrolkaWprowadzania.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            kontrolkaWprowadzania.Text = kontrolkaWprowadzania.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            kontrolkaWprowadzania.Text = kontrolkaWprowadzania.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            kontrolkaWprowadzania.Text = kontrolkaWprowadzania.Text + "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            kontrolkaWprowadzania.Text = kontrolkaWprowadzania.Text + "0";
        }
        int pamiecKalkulatora = 0;
        private void plus_Click(object sender, EventArgs e)
        {
            int wprowadzonaWartosc = int.Parse(kontrolkaWprowadzania.Text);
            pamiecKalkulatora += wprowadzonaWartosc;
            wynik.Text = pamiecKalkulatora.ToString();
            kontrolkaWprowadzania.Text = "";
        }

        private void minus_Click(object sender, EventArgs e)
        {
            int wprowadzonaWartosc = int.Parse(kontrolkaWprowadzania.Text);
            pamiecKalkulatora -= wprowadzonaWartosc;
            wynik.Text = pamiecKalkulatora.ToString();
            kontrolkaWprowadzania.Text = "";
        }

        private void mnozenie_Click(object sender, EventArgs e)
        {
            int wprowadzonaWartosc = int.Parse(kontrolkaWprowadzania.Text);
            pamiecKalkulatora = pamiecKalkulatora * wprowadzonaWartosc;
            wynik.Text = pamiecKalkulatora.ToString();
            kontrolkaWprowadzania.Text = "";
        }

        private void dzielenie_Click(object sender, EventArgs e)
        {
            int wprowadzonaWartosc = int.Parse(kontrolkaWprowadzania.Text);
            pamiecKalkulatora = pamiecKalkulatora / wprowadzonaWartosc;
            wynik.Text = pamiecKalkulatora.ToString();
            kontrolkaWprowadzania.Text = "";
        }

        private void znakrownosci_Click(object sender, EventArgs e)
        {

        }

        private void clear_Click(object sender, EventArgs e)
        {
            kontrolkaWprowadzania.Text = "";
            wynik.Text = "";
        }
    }
}
