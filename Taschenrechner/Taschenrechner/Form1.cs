using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Taschenrechner
{
    public partial class Form1 : Form
    {
        float temp1, temp2, ergebnis;
        char RO = 'n';

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Anzeige.Text = "0";
            Komma.Visible = true;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Text != ",")
            {
                if (Anzeige.Text == "0")
                {
                    Anzeige.Text = ((Button)sender).Text;
                }

                else
                {
                    Anzeige.Text = Anzeige.Text + ((Button)sender).Text;
                }
            }

            else
            {
                Anzeige.Text = Anzeige.Text + ((Button)sender).Text;
                ((Button)sender).Visible = false;
            }
        }

        private void RO_Click(object sender, EventArgs e)
        {
            if (RO != 'n')
            {
                Ergebnis((Button)sender, e);
            }
            RO = Convert.ToChar(((Button)sender).Text);
            if (!(float.TryParse(Anzeige.Text, out temp1)))
            {
                Error.Text = "Es ist ein Fehler aufgetreten.";
            }
            Anzeige.Text = "0";
            ZusatzAnzeige.Text = ZusatzAnzeige.Text + temp1 + ((Button)sender).Text;
            Komma.Visible = true;
            Fakultät.Visible = false;
        }

        private void Ergebnis(object sender, EventArgs e)
        {
            if (!(float.TryParse(Anzeige.Text, out temp2)))
            {
                Error.Text = "Es ist ein Fehler aufgetreten.";
            }
            switch (RO)
            {
                case '+':
                    ergebnis = temp1 + temp2;
                    break;

                case '-':
                    ergebnis = temp1 - temp2;
                    break;

                case '*':
                    ergebnis = temp1 * temp2;
                        Komma.Visible = ergebnis == Math.Round(ergebnis);
                    break;

                case '/':
                    ergebnis = temp1 / temp2;
                        Komma.Visible = ergebnis == Math.Round(ergebnis);
                    break;
            }
            Anzeige.Text = "" + ergebnis;
            RO = 'n';
            Fakultät.Visible = true;
            if (((Button)sender).Text == "=")
            {
                ZusatzAnzeige.Text = "";
            }
        }

        private void Binär_Click(object sender, EventArgs e)
        {
            Anzeige.Text = Convert.ToString(Convert.ToInt64(Anzeige.Text), 2);
        }

        private void Fakultät_Click(object sender, EventArgs e)
        {
            long a, b = 0;
            if (Komma.Visible)
            {
                a = Convert.ToInt64(Anzeige.Text);
                b = a;
                while (a != 0 && a != 1)
                {
                    a--;
                    b = b * a;
                }
            }
            else
            {
                Error.Text = "Syntax Error";
            }
            if (b < 0)
            {
                Error.Text = "Math Error";
                b = 0;
            }
            Anzeige.Text = "" + b;
        }
    }
}
