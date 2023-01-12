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
    public partial class Form05Char : Form
    {
        public Form05Char()
        {
            InitializeComponent();
        }

        private void ascii_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 255; i++)
            {
                char c = (char)i;
                if (char.IsLetter(c) == true)
                {
                    this.letras.Text += c;
                } else if (char.IsNumber(c) == true)
                {
                    this.numeros.Text += c;
                }
                else if (char.IsSymbol(c) == true)
                {
                    this.simbolos.Text += c;
                }
                else if (char.IsPunctuation(c) == true)
                {
                    this.puntuacion.Text += c;
                }
            }
        }
    }
}
