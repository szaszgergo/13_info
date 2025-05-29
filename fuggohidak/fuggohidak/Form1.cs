using System.IO;

namespace fuggohidak
{
    public partial class Form1 : Form
    {
       public static List<Fuggohid> hidak = new List<Fuggohid>();

        public Form1()
        {

            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                int utan = 0;
                foreach (var item in hidak)
                {
                    if (item.Date >= 2000)
                    {
                        utan++;
                    }
                }
                textBox5.Text = utan.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void megnyitásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(ofd.FileName);
                string FistLine = sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    Fuggohid sor = new Fuggohid(sr.ReadLine());
                    hidak.Add(sor);
                    listBox1.Items.Add(sor.Name);
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected = listBox1.SelectedIndex;
            textBox1.Text = hidak[selected].Location;
            textBox2.Text = hidak[selected].Country;
            textBox3.Text = hidak[selected].Length.ToString();
            textBox4.Text = hidak[selected].Date.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                int elott = 0;
                foreach (var item in hidak)
                {
                    if (item.Date < 2000)
                    {
                        elott++;
                    }
                }
                textBox5.Text = elott.ToString();
            }
        }

        private void keresésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(hidak);
            this.Hide();
            form2.Show();
        }
    }
    public class Fuggohid
    {
      

        public int Placement { get; set; }
        public string Name { get; set; }

        public string Location { get; set; }
        public string Country { get; set; }
        public int Length { get; set; }
        public int Date { get; set; }

        public Fuggohid(string rows)
        {
            string[] parts = rows.Split('\t');
            Placement = int.Parse(parts[0]);
            Name = parts[1];
            Location = parts[2];
            Country = parts[3];
            Length = int.Parse(parts[4]);
            Date = int.Parse(parts[5]);
        }

    }


}
