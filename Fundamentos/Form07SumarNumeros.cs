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
    public partial class Form07SumarNumeros : Form
    {
        public Form07SumarNumeros()
        {
            InitializeComponent();
        }

        private void sum_Click(object sender, EventArgs e)
        {
            string textNumeros = this.numbers.Text;
            int suma = 0;
            for (int i = 0; i < textNumeros.Length; i++)
            {
                char c = textNumeros[i];
                int numero = int.Parse(c.ToString());
                suma += numero;
            }
            this.result.Text = "La suma es: " + suma;
        }
    }
}
