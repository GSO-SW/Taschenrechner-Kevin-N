using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taschenrechner
{
    public partial class Taschenrechner : Form
    {
        public Taschenrechner()
        {
            InitializeComponent();
        }
        int Rechenzeichen;
        private void button_0_Click(object sender, EventArgs e)
        {
            label_Ausgabe.Text = label_Ausgabe.Text + "0";
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            label_Ausgabe.Text = label_Ausgabe.Text + "1";
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            label_Ausgabe.Text = label_Ausgabe.Text + "2";
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            label_Ausgabe.Text = label_Ausgabe.Text + "3";

        }

        private void button_4_Click(object sender, EventArgs e)
        {
            label_Ausgabe.Text = label_Ausgabe.Text + "4";
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            label_Ausgabe.Text = label_Ausgabe.Text + "5";
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            label_Ausgabe.Text = label_Ausgabe.Text + "6";
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            label_Ausgabe.Text = label_Ausgabe.Text + "7";
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            label_Ausgabe.Text = label_Ausgabe.Text + "8";
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            label_Ausgabe.Text = label_Ausgabe.Text + "9";
        }

        private void Taschenrechner_Load(object sender, EventArgs e)
        {
            label_Ausgabe.Text = "";
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            label_Ausgabe.Text = "";
        }

        private void button_Plus_Click(object sender, EventArgs e)
        {
            label_Ausgabe.Text = label_Ausgabe.Text + "+";
            Rechenzeichen = label_Ausgabe.Text.Length - 1;
        }

        private void button_Minus_Click(object sender, EventArgs e)
        {
            label_Ausgabe.Text = label_Ausgabe.Text + "-";
            Rechenzeichen = label_Ausgabe.Text.Length - 1;
        }

        private void button_Mal_Click(object sender, EventArgs e)
        {
            label_Ausgabe.Text = label_Ausgabe.Text + "*";
            Rechenzeichen = label_Ausgabe.Text.Length - 1;
        }

        private void button_Geteilt_Click(object sender, EventArgs e)
        {
            label_Ausgabe.Text = label_Ausgabe.Text + "/";
            Rechenzeichen = label_Ausgabe.Text.Length - 1;
        }

        private void button_Ergebnis_Click(object sender, EventArgs e)
        {
            if (label_Ausgabe.Text[Rechenzeichen] == '+')
                label_Ausgabe.Text= (Convert.ToDouble(label_Ausgabe.Text.Remove(Rechenzeichen)) + Convert.ToDouble(label_Ausgabe.Text.Remove(0, Rechenzeichen + 1))).ToString();


        }
    }
}
