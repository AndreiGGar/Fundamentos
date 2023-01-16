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
    public partial class Form14ListEvents : Form
    {
        List<Button> botones;
        int contador;
        public Form14ListEvents()
        {
            InitializeComponent();
            this.botones = new List<Button>();
            this.contador = 0;
            /*foreach (Button boton in botones)
            {
                this.botones.Add(boton);
                boton.BackColor = Color.Azure;
            }*/
            foreach (Control control in this.Controls)
            {
                if (control is Button)
                {
                    this.botones.Add((Button)control);
                    ((Button)control).BackColor = Color.Azure;
                }
            }
            foreach (Button boton in this.botones)
            {
                boton.Click += Boton_Click;
            }
        }

        private void Boton_Click(object sender, EventArgs e)
        {
            this.contador += 1;
            this.textBox1.Text = "Contador: " + this.contador;
        }
    }
}
