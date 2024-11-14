namespace Practica_6_do_while
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(textBox1.Text);
            if (numero % 2 == 0)
            {
                listBox1.Items.Add(numero + " es par");
            }
            else
            {
                listBox1.Items.Add(numero + " es impar");
            }
            textBox1.Text = " ";
            textBox1.Focus();
        }
    }
}
