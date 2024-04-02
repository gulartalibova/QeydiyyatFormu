namespace Qeydiyyat_Formu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //listBox1.Items.Add("Ad: " + textBox1.Text + "Soyad: " + textBox2.Text + "Universitet: " + textBox3.Text + "Fakulte: " + textBox4.Text + "Tarix: " + maskedTextBox1.Text);

            string ad, soyad, universitet, fakulte, tarix;
            ad = textBox1.Text;
            soyad = textBox2.Text;
            universitet = textBox3.Text;
            fakulte = textBox4.Text;
            tarix = maskedTextBox1.Text;
            listBox1.Items.Add (ad+" "+soyad+" "+universitet+" "+fakulte+" "+tarix);

        }
    }
}
