using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hidak2
{

   
    public partial class Form1 : Form
    {

        public class Fuggohid
        {
            public int Placement { get; set; }
            public string Name { get; set; }
            public string Location { get; set; }
            public string Country { get; set; }
            public int Length { get; set; }
            public int Date { get; set; }
            public Fuggohid(string sor)
            {
                string[] reszek = sor.Split('\t');
                Placement = int.Parse(reszek[0]);
                Name = reszek[1];
                Location = reszek[2];
                Country = reszek[3];
                Length = int.Parse(reszek[4]);
                Date = int.Parse(reszek[5]);
            }
        }
        List<Fuggohid> lista = new List<Fuggohid>();

        public Form1()
        {
            StreamReader sr = new StreamReader("fuggohidak.csv");
            string elsosor = sr.ReadLine();
            while (!sr.EndOfStream)
            {
                Fuggohid sor = new Fuggohid(sr.ReadLine());
                lista.Add(sor);
            }
            sr.Close();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var item in lista)
            {
                listBox1.Items.Add(item.Name);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                int db = lista.Count(h => h.Date >= 2000);
                lblHidakSzama.Text = $"{db}";
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string kivalasztottNev = listBox1.SelectedItem.ToString();
                Fuggohid kivalasztottHid = lista.Find(h => h.Name == kivalasztottNev);

                if (kivalasztottHid != null)
                {
                    tbxhely.Text = kivalasztottHid.Location;
                    tbxorszag.Text = kivalasztottHid.Country;
                    tbxhossz.Text = kivalasztottHid.Length.ToString();
                    tbxev.Text = kivalasztottHid.Date.ToString();
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                int db = lista.Count(h => h.Date < 2000);
                lblHidakSzama.Text = $"{db}";
            }
        }

        private void kilépésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void keresésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            KeresesForm keresForm = new KeresesForm(lista); // lista átadása
            keresForm.FormClosed += (s, args) => this.Show();
            keresForm.Show();
        }

    }
}
