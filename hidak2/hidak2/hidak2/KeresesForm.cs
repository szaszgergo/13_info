using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hidak2
{
    public partial class KeresesForm : Form
    {
        private List<Form1.Fuggohid> hidak;
        public KeresesForm(List<Form1.Fuggohid> lista)
        {
            InitializeComponent();
            hidak = lista;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void KeresesForm_Load(object sender, EventArgs e)
        {
            var orszagok = hidak.Select(h => h.Country).Distinct().OrderBy(c => c).ToList();
            comboBox2.DataSource = orszagok;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string kivalasztottOrszag = comboBox2.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(kivalasztottOrszag))
            {
                var talalatok = hidak
                    .Where(h => h.Country == kivalasztottOrszag)
                    .Select(h => h.Name)
                    .ToList();

                listBox1.Items.Clear(); // korábbi elemek törlése

                if (talalatok.Count > 0)
                {
                    foreach (var nev in talalatok)
                    {
                        listBox1.Items.Add(nev);
                    }
                }
                else
                {
                    listBox1.Items.Add("Nincs találat.");
                }
            }
            else
            {
                MessageBox.Show("Kérlek, válassz ki egy országot!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
