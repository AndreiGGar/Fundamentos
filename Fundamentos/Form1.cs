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

            short numero = 99;
            int mayor = numero;

            int numeroMayor = 99;
            short numeroMenor = 789;
            numeroMenor = (short) numeroMayor;

            string textNumero = "1234";
            int numeroEntero = int.Parse(textNumero);
            double doble = double.Parse(textNumero);

            int valor = 123;
            string texto = valor.ToString();
            string boton = this.button1.ToString();
        }
    }
}