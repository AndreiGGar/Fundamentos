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
    public partial class Form20TemperaturaAnual : Form
    {
        /*string[] months = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
        int[] Years = { 2017, 2018, 2019, 2020, 2021, 2022, 2023 };
        int i = 0;
        int j = 0;
        int maxTemp = 0;
        int minTemp = 0;
        List<Temperatura> temperaturas;*/

        List<TemperaturaAnual> years;
        TemperaturaAnual anyoSeleccionado;
        public Form20TemperaturaAnual()
        {
            InitializeComponent();
            //this.temperaturas = new List<Temperatura>();
            this.years = new List<TemperaturaAnual>();
        }

        private void generar_Click(object sender, EventArgs e)
        {
            int nYear = 2015;
            for (int i = 1; i<= 5; i++)
            {
                TemperaturaAnual year = new TemperaturaAnual(nYear);
                this.years.Add(year);
                this.anyos.Items.Add("Año " + nYear);
                nYear++;
            }
            /*Random random = new Random();
            this.meses.Items.Clear();
            this.anyos.Items.Clear();
            this.temperaturas.Clear();
            this.temperaturasAnual.Clear();
            this.maxTemp = 0;
            this.minTemp = 0;
            foreach (int year in years)
            {
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
                    this.maxTemp = this.temperaturas.Max(t => t.TMax);
                    this.minTemp = this.temperaturas.Min(t => t.TMin);
                    this.meses.Items.Add(month);
                    i++;
                }
                this.anyos.Items.Add(year);
                TemperaturaAnual tempAnual = new(year.ToString(), maxTemp, minTemp);
                this.temperaturasAnual.Add(tempAnual);
                i = 0;
                j++;
            }
            j = 0;*/
        }

        private void meses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.meses.SelectedIndex != -1)
            {
                int index = this.meses.SelectedIndex;
                Temperatura mes = this.anyoSeleccionado.Meses[index];
                this.max.Text = mes.TMax.ToString();
                this.min.Text = mes.TMin.ToString();
                this.average.Text = mes.GetMedia().ToString();
            }
        }

        private void anyos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.anyos.SelectedIndex;
            this.anyoSeleccionado = this.years[index];
            this.maxA.Text = this.anyoSeleccionado.GetMax().ToString();
            this.minA.Text = this.anyoSeleccionado.GetMin().ToString();
            this.averageA.Text = this.anyoSeleccionado.GetMediaAnual().ToString();
            this.meses.Items.Clear();
            foreach (Temperatura mes in this.anyoSeleccionado.Meses)
            {
                this.meses.Items.Add(mes.Mes);
            }
        }
    }
}
