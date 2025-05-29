using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace fuggohidak
{

    public partial class Form2 : Form
    {
        private List<Fuggohid> list = new List<Fuggohid>();
        public Form2(List<Fuggohid> list)
        {
            InitializeComponent();
            this.list = list;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            foreach (var item in list)
            {
                if (!comboBox1.Items.Contains(item.Country))
                {
                    comboBox1.Items.Add(item.Country);
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                listBox1.Items.Clear();
                foreach (var item in list)
                {
                    if (item.Country == comboBox1.SelectedItem.ToString() && item.Length >1000)
                    {
                        listBox1.Items.Add(item.Name);

                    }
                }
            }
            else
            {
                listBox1.Items.Clear();
                foreach(var item in list)
                {
                    if (item.Country == comboBox1.SelectedItem.ToString())
                    {
                        listBox1.Items.Add(item.Name);

                    }
                }
            }
        }
    }
}
