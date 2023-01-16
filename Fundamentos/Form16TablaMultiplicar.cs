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
    public partial class Form16TablaMultiplicar : Form
    {
        List<TextBox> textBoxes;
        // int i = 1;
        public Form16TablaMultiplicar()
        {
            InitializeComponent();
            this.textBoxes = new List<TextBox>();

            foreach (TextBox caja in this.tabla.Controls)
            {
                if (caja is TextBox)
                {
                    this.textBoxes.Add((TextBox)caja);
                }
            }

            this.textBoxes.Reverse();

        }

        private void mostrar_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(this.numero.Text);
            for (int i = 0; i < textBoxes.Count; i++)
            {
                int op = numero * (i + 1);
                this.textBoxes[i].Text = op.ToString();
            }
            /*foreach (TextBox textBox in this.textBoxes)
            {
                int numero = int.Parse(this.numero.Text) * i;
                textBox.Text = numero.ToString();
                i++;
            }*/
        }
    }
}
