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
    public partial class Form12Metodos : Form
    {
        public Form12Metodos()
        {
            InitializeComponent();
        }

        void GetDoble(int numero)
        {
            numero = numero * 2;
        }

        void getDobleRef(ref int numero)
        {
            numero = numero * 2;
        }
        int GetDobleNumero(int numero)
        {
            return numero * 2;
        }

        void CambiarColor(Button boton)
        {
            boton.BackColor = Color.Azure;
        }

        private void dobleValor_Click(object sender, EventArgs e)
        {
            int num = int.Parse(this.numero.Text);
            this.GetDoble(num);
            this.result.Text = num.ToString();
        }

        private void dobleRef_Click(object sender, EventArgs e)
        {
            /*int num = int.Parse(this.numero.Text);
            this.getDobleRef(ref num);
            this.result.Text = num.ToString();*/
            int num = int.Parse(this.numero.Text);
            int result = this.GetDobleNumero(num);
            this.result.Text = result.ToString();
        }

        private void objetoRef_Click(object sender, EventArgs e)
        {
            this.CambiarColor(this.dobleRef);
            this.CambiarColor(this.dobleValor);
        }
        private void Form12Metodos_Load(object sender, EventArgs e)
        {

        }
        private void Form12Metodos_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Form12Metodos_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void box_MouseMove(object sender, MouseEventArgs e)
        {
            this.box.Text = "X: " + e.X + ", Y: " + e.Y;
        }

        private void numbers_KeyPress(object sender, KeyPressEventArgs e)
        {
             char teclaBorrar = (char) Keys.Back; 
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != teclaBorrar)
            {
                e.Handled = true;
            }
        }

        private void chars_KeyPress(object sender, KeyPressEventArgs e)
        {
            char teclaBorrar = (char)Keys.Back;
            if (char.IsLetter(e.KeyChar) == false && e.KeyChar != teclaBorrar)
            {
                e.Handled = true;
            }
        }
    }
}
