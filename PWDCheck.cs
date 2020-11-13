using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PWDCheck
{
    public partial class PWDCheck : Form
    {
        public PWDCheck()
        {
            InitializeComponent();
        }

        private void PogaParbaudit(object sender, EventArgs e)
        {
            lblvertiba_1.Text = "Ievadita vertiba: " + tbparole1.Text;
            lblhash_1.Text = "Hash: " + Convert.ToString(tbparole1.Text.GetHashCode());

            int cipari = 0;
            int simboli = 0;
            int burti = 0;

            try
            {
                for (int i = 0; i < tbparole1.Text.Length; i++)
                {
                    if (tbparole1.Text[i] >= '0' && tbparole1.Text[i] <= '9')
                    {
                        cipari++;
                    }
                    else if ((tbparole1.Text[i] >= 'A' && tbparole1.Text[i] <= 'Z') || (tbparole1.Text[i] >= 'a' && tbparole1.Text[i] <= 'z'))
                    {
                        burti++;
                    }
                    else
                    {
                        simboli++;
                    }
                }
            }
            catch
            {


            }
            lblcipari_1.Text = "Cipari: " + cipari.ToString();
            lblburti_1.Text = "Burti: " + burti.ToString();
            lblchar_1.Text = "Char: " + simboli.ToString();
            if ((cipari + burti + simboli >= 11) && (cipari > 1) && (simboli > 1) && (burti > 1))
            {
                lblpaole_1.Text = "Password OK";
            }
            else lblpaole_1.Text = "Password NOT OK";



            lblvertiba_2.Text = "Ievadita vertiba: " + tbparole2.Text;
            lblhash_2.Text = "Hash: " + Convert.ToString(tbparole2.Text.GetHashCode());

            int cipari2 = 0;
            int simboli2 = 0;
            int burti2 = 0;

            try
            {
                for (int i = 0; i < tbparole2.Text.Length; i++)
                {
                    if (tbparole2.Text[i] >= '0' && tbparole2.Text[i] <= '9')
                    {
                        cipari2++;
                    }
                    else if ((tbparole2.Text[i] >= 'A' && tbparole2.Text[i] <= 'Z') || (tbparole2.Text[i] >= 'a' && tbparole2.Text[i] <= 'z'))
                    {
                        burti2++;
                    }
                    else
                    {
                        simboli2++;
                    }
                }
            }
            catch
            {

            }
            lblcipari_2.Text = "Cipari: " + cipari2.ToString();
            lblburti_2.Text = "Burti: " + burti2.ToString();
            lblsimboli_2.Text = "Char: " + simboli2.ToString();
            if ((cipari2 + burti2 + simboli2 >= 11) && (cipari2 > 1) && (simboli2 > 1) && (burti2 > 1))
            {
                lblparole_2.Text = "Password OK";
            }
            else lblparole_2.Text = "Password NOT OK";



        }




        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblhash_1_Click(object sender, EventArgs e)
        {

        }
    }
 }