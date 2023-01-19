using ProyectoClases;
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
    public partial class Form19TemperaturaPOO : Form
    {
        string[] months = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
        int[] temperatures = new int[12];
        int i = 0;

        public Form19TemperaturaPOO()
        {
            InitializeComponent();
        }

        private void generar_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            this.meses.Text = "";
            foreach (string month in months)
            {
                int temp1 = random.Next(-20, 45);
                int temp2 = random.Next(-20, 45);
                if (temp1 > temp2)
                {
                    Temperatura temp = new(month, temp1, temp2);
                } else
                {
                    Temperatura temp = new(month, temp2, temp1);
                }
                if (temp1 == temp2)
                {
                    temp1 = random.Next(temp2, 45);
                }
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
