using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fundamentos
{
    public partial class Form17Temperaturas : Form
    {
        string[] months = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
        int[] temperatures = new int[12];
        int i = 0;
        public Form17Temperaturas()
        {
            InitializeComponent();
        }

        private void generar_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            this.meses.Text = "";
            foreach (string month in months)
            {
                int num = random.Next(-20, 45);
                this.temperatures[i] = num;
                this.meses.Text += "\n\n" + month + ": " + num;
                i++;
            }
            i = 0;
        }

        private void mostrar_Click(object sender, EventArgs e)
        {
            this.min.Text = ""; this.max.Text = ""; this.average.Text = "";
            int max = this.temperatures.Max();
            int min = this.temperatures.Min();
            int average = this.temperatures.Sum() / this.temperatures.Length;
            this.min.Text = min.ToString();
            this.max.Text = max.ToString();
            this.average.Text = average.ToString();
        }
    }
}
