namespace Fundamentos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Width = 150;
            this.button1.Text = "Botón pulsado.";
            this.textBox1.Location = new Point(70, 100);
            this.textBox1.TextAlign = HorizontalAlignment.Right;
            this.BackColor = Color.Turquoise;
        }
    }
}