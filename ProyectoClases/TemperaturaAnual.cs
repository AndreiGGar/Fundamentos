using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class TemperaturaAnual
    {
        public TemperaturaAnual() {
            this.GenerarMeses();
        }
        public TemperaturaAnual(int year)
        {
            this.Year = year;
            this.GenerarMeses();
        }

        private void GenerarMeses()
        {
            string[] months = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
            Random random = new Random();
            this.Meses = new List<Temperatura>();
            int i = 0;

            foreach (string month in months)
            {
                int temp1 = random.Next(-20, 45);
                int temp2 = random.Next(-20, 45);
                if (temp1 > temp2)
                {
                    Temperatura temp = new(month, temp1, temp2);
                    this.Meses.Add(temp);
                }
                else
                {
                    Temperatura temp = new(month, temp2, temp1);
                    this.Meses.Add(temp);
                }
                if (temp1 == temp2)
                {
                    temp1 = random.Next(temp2, 45);
                    Temperatura temp = new(month, temp1, temp2);
                    this.Meses.Add(temp);
                }
                i++;
            }
            i = 0;
        }
        public int Year { get; set; }
        public List<Temperatura> Meses { get; set; }

        public int GetMax()
        {
            int max = 0;
            foreach (Temperatura mes in this.Meses)
            {
                max = Math.Max(max, mes.TMax);
            }
            return max;
        }

        public int GetMin()
        {
            int min = 0;
            foreach (Temperatura mes in this.Meses)
            {
                min = Math.Max(min, mes.TMin);
            }
            return min;
        }

        public float GetMediaAnual()
        {
            float suma = 0;
            foreach (Temperatura mes in this.Meses)
            {
                suma = mes.GetMedia();
            }
            return suma / this.Meses.Count;
        }
    }
}
