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
    public partial class Form15SumarBotones : Form
    {
        List<Button> botones;
        int suma;
        public Form15SumarBotones()
        {
            InitializeComponent();
            this.botones = new List<Button>();
            this.suma = 0;

            foreach (Control control in this.groupBox1.Controls)
            {
                if (control is Button)
                {
                    this.botones.Add((Button)control);
                }
            }

            Random random = new Random();
            foreach (Button boton in this.botones)
            {
                int num = random.Next(1,200);
                boton.Text = num.ToString();
                boton.Click += SumarNumeros;
            }
        }

        private void SumarNumeros(object? sender, EventArgs e)
        {
            Button boton = (Button)sender;
            int numero = int.Parse(boton.Text);
            this.suma += numero;
            this.label1.Text = this.suma.ToString();
            boton.BackColor = Color.Azure;
        }

        private void reiniciar_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            this.suma = 0;
            this.label1.Text = "0";
            foreach (Button boton in this.botones)
            {
                int num = random.Next(1, 200);
                boton.Text = num.ToString();
                boton.BackColor = Color.FromKnownColor(KnownColor.Control);
            }
        }
    }
}
