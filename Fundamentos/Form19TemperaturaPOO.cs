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
        //int[] temperatures = new int[12];
        int i = 0;
        List<Temperatura> temperaturas;

        public Form19TemperaturaPOO()
        {
            InitializeComponent();
            this.temperaturas = new List<Temperatura>();
        }

        private void generar_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            this.meses.Items.Clear();
            this.temperaturas.Clear();
            foreach (string month in months)
            {
                int temp1 = random.Next(-20, 45);
                int temp2 = random.Next(-20, 45);
                if (temp1 > temp2)
                {
                    Temperatura temp = new(month, temp1, temp2);
                    this.temperaturas.Add(temp);
                }
                else
                {
                    Temperatura temp = new(month, temp2, temp1);
                    this.temperaturas.Add(temp);
                }
                if (temp1 == temp2)
                {
                    temp1 = random.Next(temp2, 45);
                    Temperatura temp = new(month, temp1, temp2);
                    this.temperaturas.Add(temp);
                }
                this.meses.Items.Add(month);
                i++;
            }
            i = 0;
        }

        private void meses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.meses.SelectedIndex != -1)
            {
                int indice = this.meses.SelectedIndex;
                Temperatura temp = this.temperaturas[indice];
                this.max.Text = temp.TMax.ToString();
                this.min.Text = temp.TMin.ToString();
                this.average.Text = temp.GetMedia().ToString();
            }
        }
    }
}
