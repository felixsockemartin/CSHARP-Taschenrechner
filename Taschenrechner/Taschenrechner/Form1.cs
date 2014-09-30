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
        float temp1, temp2;


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
    }
}
