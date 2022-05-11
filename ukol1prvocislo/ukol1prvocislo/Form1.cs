using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ukol1prvocislo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool JePrvocislo(int cislo)
        {
            if (cislo < 2) return false;
            if (cislo == 2) return true;
            if (cislo % 2 == 0) return false;
            for (int i = 3; i < Math.Sqrt(cislo); i += 2)
            {
                if (cislo % i == 0) { return false; }
            }
            return true;
        }
        Random rd = new Random();
        List<int> list = new List<int>();
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            list.Clear();
            bool cyklus = true;
            int n = (int)numericUpDown1.Value;
            for(int i = 0; i < n; i++)
            {
                list.Add(rd.Next(5, 121));
            }
            foreach(int h in list)
            {
               
                listBox1.Items.Add(h);
            }
            for(int x=0; x < n && cyklus; x++)
            {

                if(JePrvocislo(list[x]))
                {
                    cyklus = false;
                    MessageBox.Show("První prvocislo: ",  list[x].ToString());
                }
            }

        }
    }
}
/*Na vstupu je číslo N a N-prvková posloupnost kladných celých čísel z intervalu
<5,120>. Obsahuje posloupnost prvočíslo a jaké? Pro zkrácení běhu programu
použijte typ bool, to znamená, že jakmile najde první prvočíslo tak je cyklus prohledávání ukončen.

Ošetřete uživatelský vstup!*/