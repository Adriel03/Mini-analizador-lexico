using  mini_analizador_lexico.Clases;
namespace mini_analizador_lexico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                textBox2.Text = textBox1.Text + " " + AnLex.analizar(textBox1.Text);
                textBox1.Clear();
            }
        }
    }
}